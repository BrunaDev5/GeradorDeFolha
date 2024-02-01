using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ProjetoHumanity.Models.dao
{


    internal class DaoRegistroPonto
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;

        public string NovoRegistroPonto(RegistroPonto registro)
        {
            try
            {
                cmd.Connection = con.conectar();

                // Consulta SQL para obter o ID_FOLHAPGTO
                cmd.CommandText = "SELECT ID_FOLHAPGTO FROM FOLHA_PGTO WHERE @DATA_REGISTRO BETWEEN DATA_INIC AND DATA_FIM";

                // Defina o parâmetro da data de registro
                cmd.Parameters.AddWithValue("@DATA_REGISTRO", registro.DATA_REGISTRO);

                // Execute a consulta para obter o ID_FOLHAPGTO correto
                int idFolhaPgto = (int)cmd.ExecuteScalar();

                // Agora que temos o ID_FOLHAPGTO, você pode usá-lo para inserir o registro de ponto
                cmd.Parameters.Clear(); // Limpar os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FUNCIONARIO", registro.ID_FUNCIONARIO);
                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto); // Use o ID_FOLHAPGTO obtido na consulta
                cmd.Parameters.AddWithValue("@DATA_REGISTRO", registro.DATA_REGISTRO);
                cmd.Parameters.AddWithValue("@TIPO_TRABALHO", registro.TIPO_TRABALHO);
                cmd.Parameters.AddWithValue("@H_ENTRADA", registro.H_ENTRADA);
                cmd.Parameters.AddWithValue("@INICIO_ALMOCO", registro.INICIO_ALMOCO);
                cmd.Parameters.AddWithValue("@FIM_ALMOCO", registro.FIM_ALMOCO);
                cmd.Parameters.AddWithValue("@H_SAIDA", registro.H_SAIDA);

                TimeSpan tempoTotalTrabalho = registro.H_SAIDA - registro.H_ENTRADA;
                TimeSpan tempoAlmoco = registro.FIM_ALMOCO - registro.INICIO_ALMOCO;
                TimeSpan tempoTrabalhadoMenosAlmoco = tempoTotalTrabalho - tempoAlmoco;

                // Converter o tempo de trabalho em horas (decimal)
                decimal horasTrabalhadas = (decimal)tempoTrabalhadoMenosAlmoco.TotalHours;

                if (registro.TIPO_TRABALHO == "Normal" && horasTrabalhadas < 8.0m)
                {
                    decimal minutosAtraso = (8.0m - horasTrabalhadas) * 60.0m; // Converter de horas para minutos
                    TimeSpan tempoAtraso = TimeSpan.FromMinutes((double)minutosAtraso);

                    cmd.Parameters.AddWithValue("@QTDE_ATRASOS", tempoAtraso);
                }
                else
                {
                    // Se não houver atrasos, registre 00:00 no banco de dados
                    cmd.Parameters.AddWithValue("@QTDE_ATRASOS", TimeSpan.Zero);
                }

                cmd.Parameters.AddWithValue("@H_REALIZADAS", horasTrabalhadas);


                // Verificação para definir FALTAS como 1 se o TIPO_TRABALHO for "Faltou", senão 0
                if (registro.TIPO_TRABALHO == "Faltou")
                {
                    cmd.Parameters.AddWithValue("@FALTAS", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@FALTAS", 0);
                }

                if (registro.TIPO_FALTA == "Injustificada" || registro.TIPO_FALTA == "Justificada")
                {
                    cmd.Parameters.AddWithValue("@TIPO_FALTA", registro.TIPO_FALTA);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TIPO_FALTA", "NDA"); // Define o valor padrão como "NDA"
                }

                cmd.Parameters.AddWithValue("@ID_USUARIO", registro.ID_USUARIO);

                // Agora, execute a inserção do registro de ponto
                cmd.CommandText = "INSERT INTO REGISTRO_PONTO (ID_FUNCIONARIO, ID_FOLHAPGTO, DATA_REGISTRO, TIPO_TRABALHO, H_ENTRADA, INICIO_ALMOCO, FIM_ALMOCO, H_SAIDA, H_REALIZADAS,QTDE_ATRASOS, FALTAS, TIPO_FALTA, ID_USUARIO ) " +
                                  "VALUES (@ID_FUNCIONARIO, @ID_FOLHAPGTO, @DATA_REGISTRO, @TIPO_TRABALHO, @H_ENTRADA, @INICIO_ALMOCO, @FIM_ALMOCO, @H_SAIDA, @H_REALIZADAS,@QTDE_ATRASOS, @FALTAS, @TIPO_FALTA, @ID_USUARIO)";

                cmd.ExecuteNonQuery();

                mensagem = "Registro de ponto cadastrado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar registro de ponto: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }

            return mensagem;
        }

        public List<RegistroPonto> BuscarRegistrosPontoPorMesEAno(int mes, int ano, int idFuncionario)
        {
            List<RegistroPonto> registrosPonto = new List<RegistroPonto>();

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT * FROM REGISTRO_PONTO WHERE MONTH(DATA_REGISTRO) = @Mes AND YEAR(DATA_REGISTRO) = @Ano AND ID_FUNCIONARIO = @IdFuncionario ORDER BY DATA_REGISTRO";
                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Ano", ano);
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaDataRegistro = reader.GetOrdinal("DATA_REGISTRO");
                        int colunaHEntrada = reader.GetOrdinal("H_ENTRADA");
                        int colunaTipoTrabalho = reader.GetOrdinal("TIPO_TRABALHO");
                        int colunaInicioAlmoco = reader.GetOrdinal("INICIO_ALMOCO");
                        int colunaFimAlmoco = reader.GetOrdinal("FIM_ALMOCO");
                        int colunaHSaida = reader.GetOrdinal("H_SAIDA");
                        int colunaHRealizadas = reader.GetOrdinal("H_REALIZADAS");
                        int colunaQtdeAtrasos = reader.GetOrdinal("QTDE_ATRASOS");
                        int colunaFaltas = reader.GetOrdinal("FALTAS");
                        int colunaTipoFalta = reader.GetOrdinal("TIPO_FALTA");

                        if (!reader.IsDBNull(colunaDataRegistro) && !reader.IsDBNull(colunaTipoTrabalho) &&
                            !reader.IsDBNull(colunaHEntrada) && !reader.IsDBNull(colunaInicioAlmoco) &&
                            !reader.IsDBNull(colunaFimAlmoco) && !reader.IsDBNull(colunaHSaida) &&
                            !reader.IsDBNull(colunaHRealizadas) && !reader.IsDBNull(colunaQtdeAtrasos) &&
                            !reader.IsDBNull(colunaFaltas) && !reader.IsDBNull(colunaTipoFalta))
                        {
                            RegistroPonto registro = new RegistroPonto
                            {
                                DATA_REGISTRO = reader.GetDateTime(colunaDataRegistro),
                                TIPO_TRABALHO = reader.GetString(colunaTipoTrabalho),
                                H_ENTRADA = reader.GetTimeSpan(colunaHEntrada),
                                INICIO_ALMOCO = reader.GetTimeSpan(colunaInicioAlmoco),
                                FIM_ALMOCO = reader.GetTimeSpan(colunaFimAlmoco),
                                H_SAIDA = reader.GetTimeSpan(colunaHSaida),
                                H_REALIZADAS = reader.GetDecimal(colunaHRealizadas),
                                QTDE_ATRASOS = reader.GetTimeSpan(colunaQtdeAtrasos),
                                FALTAS = reader.GetInt32(colunaFaltas),
                                TIPO_FALTA = reader.GetString(colunaTipoFalta)
                            };
                            registrosPonto.Add(registro);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar registros de ponto: " + ex.Message);
            }
            finally
            {
                try
                {
                    con.desconectar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao desconectar: " + ex.Message);
                }
            }

            return registrosPonto;
        }

        public bool RegistroPontoJaExiste(DateTime dataRegistro, string tipoTrabalho, int idFuncionario)
        {
            try
            {

                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT COUNT(*) FROM REGISTRO_PONTO WHERE DATA_REGISTRO = @DataRegistro AND TIPO_TRABALHO = @TipoTrabalho AND ID_FUNCIONARIO = @IdFuncionario";
                    
                    cmd.Parameters.AddWithValue("@DataRegistro", dataRegistro);
                    cmd.Parameters.AddWithValue("@TipoTrabalho", tipoTrabalho);
                    cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                    int count = (int)cmd.ExecuteScalar();

                    return count > 0;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o registro de ponto já existe: " + ex.Message);
                // Lida com exceções apropriadamente
                return false;
            }
        }
















    }
}
