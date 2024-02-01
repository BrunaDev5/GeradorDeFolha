using ProjetoHumanity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.dao
{
    internal class DaoFolhaPag
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;


        public string NovaFolhaPagamento(string codFolha, DateTime dataInic, DateTime dataFim, DateTime dataCredito, int idUsuario)
        {
            string mensagem = "";

            try
            {

                // Define o comando SQL para inserir uma nova folha de pagamento na tabela FOLHA_PGTO
                cmd.CommandText = "INSERT INTO FOLHA_PGTO (COD_FOLHA, DATA_INIC, DATA_FIM, DATA_CREDITO, ID_USUARIO) " +
                                 "VALUES (@CodFolha, @DataInic, @DataFim, @DataCredito, @IdUsuario)";

                // Estabelece a conexão
                cmd.Connection = con.conectar();

                // Adicione os parâmetros
                cmd.Parameters.AddWithValue("@CodFolha", codFolha);
                cmd.Parameters.AddWithValue("@DataInic", dataInic);
                cmd.Parameters.AddWithValue("@DataFim", dataFim);
                cmd.Parameters.AddWithValue("@DataCredito", dataCredito);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

              
                // Executa o comando SQL para inserir a nova empresa
                cmd.ExecuteNonQuery();

                mensagem = "Folha de pagamento cadastrada com sucesso!";
                Tem = true;

            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar folha de pagamento: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }

            return mensagem;
        }

        public FolhaPag BuscarFolhaporId(int idFolhaPgto)
        {
            FolhaPag folhaPag  = null;

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT ID_FOLHAPGTO,COD_FOLHA,DATA_INIC,DATA_FIM,DATA_CREDITO FROM FOLHA_PGTO WHERE ID_FOLHAPGTO = @idFolhaPgto";
                cmd.Parameters.AddWithValue("@idFolhaPgto", idFolhaPgto);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_FOLHAPGTO");
                        int colunaCodigo = reader.GetOrdinal("COD_FOLHA");
                        int colunaDtInicio = reader.GetOrdinal("DATA_INIC");
                        int colunaDtFinal = reader.GetOrdinal("DATA_FIM");
                        int colunaDtCredito = reader.GetOrdinal("DATA_CREDITO");
                        

                   

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaCodigo) && !reader.IsDBNull(colunaDtInicio) &&
                            !reader.IsDBNull(colunaDtFinal) && !reader.IsDBNull(colunaDtCredito))
                        {
                            folhaPag = new FolhaPag(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaCodigo),
                                reader.GetDateTime(colunaDtInicio),
                                reader.GetDateTime(colunaDtFinal),
                                reader.GetDateTime(colunaDtCredito)

                            ); 
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                // Lide com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar Folha por ID: " + ex.Message);
            }
            finally
            {
                try
                {
                    con.desconectar();
                }
                catch (Exception ex)
                {
                    // Lide com a exceção de desconexão de alguma forma apropriada
                    Console.WriteLine("Erro ao desconectar: " + ex.Message);
                }
            }

            return folhaPag;
        }

        public List<FolhaPag> ListarFolhasPagamento()
        {
            List<FolhaPag> listaFolhasPagamento = new List<FolhaPag>();

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT ID_FOLHAPGTO, COD_FOLHA, DATA_INIC, DATA_FIM, DATA_CREDITO FROM FOLHA_PGTO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_FOLHAPGTO");
                        int colunaCodigo = reader.GetOrdinal("COD_FOLHA");
                        int colunaDtInicio = reader.GetOrdinal("DATA_INIC");
                        int colunaDtFinal = reader.GetOrdinal("DATA_FIM");
                        int colunaDtCredito = reader.GetOrdinal("DATA_CREDITO");
                        

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaCodigo) && !reader.IsDBNull(colunaDtInicio) &&
                            !reader.IsDBNull(colunaDtFinal) && !reader.IsDBNull(colunaDtCredito))
                        {
                           

                            FolhaPag folhaPag = new FolhaPag(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaCodigo),
                                reader.GetDateTime(colunaDtInicio),
                                reader.GetDateTime(colunaDtFinal),
                                reader.GetDateTime(colunaDtCredito)
                                
                            );

                            listaFolhasPagamento.Add(folhaPag); // Adiciona a folha de pagamento à lista
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar Folhas de Pagamento: " + ex.Message);
                throw;
            }
            finally
            {
                con.desconectar();
            }

            return listaFolhasPagamento;
        }


        public FolhaPag ObterDadosdaFolha(int idFolhaPgto)
        {
            FolhaPag folhaPag = null;

            try
            {
                cmd.Connection = con.conectar();

                // Ajuste a consulta SQL para incluir todas as colunas necessárias
                cmd.CommandText = "SELECT * FROM FOLHA_PGTO WHERE ID_FOLHAPGTO = @IdFolhaPgto";
                cmd.Parameters.AddWithValue("@IdFolhaPgto", idFolhaPgto); // Corrigi o nome do parâmetro

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mapeia os dados do banco de dados para o objeto FolhaPag
                        folhaPag = new FolhaPag
                        {
                            ID_FOLHAPGTO = reader.GetInt32(reader.GetOrdinal("ID_FOLHAPGTO")),
                            COD_FOLHA = reader.GetString(reader.GetOrdinal("COD_FOLHA")),
                            DATA_INIC = reader.GetDateTime(reader.GetOrdinal("DATA_INIC")), // Supondo que a coluna seja uma data
                            DATA_FIM = reader.GetDateTime(reader.GetOrdinal("DATA_FIM")),   // Supondo que a coluna seja uma data
                            DATA_CREDITO = reader.GetDateTime(reader.GetOrdinal("DATA_CREDITO")) // Supondo que a coluna seja uma data
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados da folha de pagamento: " + ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear(); // Limpa os parâmetros antes de fechar a conexão
                con.desconectar();
            }

            return folhaPag;
        }





    }
}
