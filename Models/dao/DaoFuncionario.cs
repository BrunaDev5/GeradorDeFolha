using ProjetoHumanity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.dao
{
    internal class DaoFuncionario
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;

        public string NovoFuncionario(int idEmpresa,
            string codFunc,
            string statusFunc,
            string nomeFunc,
            string genero,
            string estCivil,
            DateTime dtNasc,
            string cpf,
            string rg,
            string pis,
            DateTime dtAdmissao,
            string turnoFunc,
            string funcaoFunc,
            decimal salarioBase,
            string cepFunc,
            string ruaFunc,
            string numFunc,
            string bairroFunc,
            string cidadeFunc,
            string complemFunc,
            string ufFunc,
            string telFunc,
            string emailFunc,
            string agenciaPgto,
            string contaPgto,
            string tipoConta,
            string vlAlimentacao,
            string vlTransporte,
            string loginDemonstrativo,
            string senhaDemonstrativo,
            int idUsuario)
        {
            try
            {
                cmd.CommandText = "INSERT INTO FUNCIONARIO (ID_EMPRESA, COD_FUNC, STATUS_FUNC, NOME_FUNC, GENERO, EST_CIVIL, DT_NASC, CPF, RG, PIS, DT_ADMISSAO, TURNO_FUNC, FUNCAO_FUNC, SALARIO_BASE, CEP_FUNC, RUA_FUNC, NUM_FUNC, BAIRRO__FUNC,CIDADE_FUNC,COMPLEM__FUNC, UF_FUNC, TEL_FUNC, EMAIL_FUNC, AGENCIA_PGTO, CONTA_PGTO, TIPO_CONTA, VL_ALIMENTACAO, VL_TRANSPORTE, LOGIN_DEMONSTRATIVO, SENHA_DEMONSTRATIVO, ID_USUARIO) " +
                                  "VALUES(@idEmpresa,@codFunc,@statusFunc,@nomeFunc,@genero,@estCivil,@dtNasc,@cpf,@rg,@pis,@dtAdmissao,@turnoFunc,@funcaoFunc,@salarioBase,@cepFunc,@ruaFunc,@numFunc,@bairroFunc,@cidadeFunc,@complemFunc,@ufFunc,@telFunc,@emailFunc,@agenciaPgto,@contaPgto,@tipoConta,@vlAlimentacao,@vlTransporte,@loginDemonstrativo,@senhaDemonstrativo,@idUsuario)";

                cmd.Connection = con.conectar();

                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);
                cmd.Parameters.AddWithValue("@codFunc", codFunc);
                cmd.Parameters.AddWithValue("@statusFunc", statusFunc);
                cmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@estCivil", estCivil);
                cmd.Parameters.AddWithValue("@dtNasc", dtNasc);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@pis", pis);
                cmd.Parameters.AddWithValue("@dtAdmissao", dtAdmissao);
                cmd.Parameters.AddWithValue("@turnoFunc", turnoFunc);
                cmd.Parameters.AddWithValue("@funcaoFunc", funcaoFunc);
                cmd.Parameters.AddWithValue("@salarioBase", salarioBase);
                cmd.Parameters.AddWithValue("@cepFunc", cepFunc);
                cmd.Parameters.AddWithValue("@ruaFunc", ruaFunc);
                cmd.Parameters.AddWithValue("@numFunc", numFunc);
                cmd.Parameters.AddWithValue("@bairroFunc", bairroFunc);
                cmd.Parameters.AddWithValue("@cidadeFunc", cidadeFunc);
                cmd.Parameters.AddWithValue("@complemFunc", complemFunc);
                cmd.Parameters.AddWithValue("@ufFunc", ufFunc);
                cmd.Parameters.AddWithValue("@telFunc", telFunc);
                cmd.Parameters.AddWithValue("@emailFunc", emailFunc);
                cmd.Parameters.AddWithValue("@agenciaPgto", agenciaPgto);
                cmd.Parameters.AddWithValue("@contaPgto", contaPgto);
                cmd.Parameters.AddWithValue("@tipoConta", tipoConta);
                cmd.Parameters.AddWithValue("@vlAlimentacao", vlAlimentacao);
                cmd.Parameters.AddWithValue("@vlTransporte", vlTransporte);
                cmd.Parameters.AddWithValue("@loginDemonstrativo", loginDemonstrativo);
                cmd.Parameters.AddWithValue("@senhaDemonstrativo", senhaDemonstrativo);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                cmd.ExecuteNonQuery();

                // Após inserir o funcionário com sucesso, atualize a quantidade na tabela EMPRESA
                AtualizarQuantidadeFuncionarios(idEmpresa);

                mensagem = "Funcionário cadastrado com sucesso!";
                Tem = true;


            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar funcionário: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }

            return mensagem;
        }

        public FUNCIONARIO BuscarFuncionarioPorId(int idFuncionario)
        {
            FUNCIONARIO funcionario = null;

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @IdFuncionario";
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_FUNCIONARIO");
                        int colunaFuncionario = reader.GetOrdinal("NOME_FUNC");
                        int colunaAdmissao = reader.GetOrdinal("DT_ADMISSAO");
                        int colunaStatus = reader.GetOrdinal("STATUS_FUNC");
                        int colunaFuncao = reader.GetOrdinal("FUNCAO_FUNC");
                        int colunaSalario = reader.GetOrdinal("SALARIO_BASE");
                        int colunaCPF = reader.GetOrdinal("CPF");
                        int colunaEmpresa = reader.GetOrdinal("ID_EMPRESA");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaFuncionario) && !reader.IsDBNull(colunaAdmissao) &&
                            !reader.IsDBNull(colunaStatus) && !reader.IsDBNull(colunaFuncao) && !reader.IsDBNull(colunaSalario) &&
                            !reader.IsDBNull(colunaCPF) && !reader.IsDBNull(colunaEmpresa))
                        {
                            funcionario = new FUNCIONARIO(

                                reader.GetInt32(colunaId),
                                reader.GetString(colunaStatus),
                                reader.GetString(colunaFuncionario),
                                reader.GetDateTime(colunaAdmissao),
                                reader.GetString(colunaFuncao),
                                reader.GetDecimal(colunaSalario),
                                reader.GetString(colunaCPF),
                                reader.GetInt32(colunaEmpresa)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao buscar funcionário por ID: " + ex.Message);
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

            return funcionario;
        }

        public List<FUNCIONARIO> ListarFuncionarios()
        {
            List<FUNCIONARIO> listaFuncionarios = new List<FUNCIONARIO>();

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT ID_FUNCIONARIO, STATUS_FUNC, NOME_FUNC, DT_ADMISSAO, FUNCAO_FUNC, SALARIO_BASE, CPF, ID_EMPRESA FROM FUNCIONARIO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_FUNCIONARIO");
                        int colunaStatus = reader.GetOrdinal("STATUS_FUNC");
                        int colunaNome = reader.GetOrdinal("NOME_FUNC");
                        int colunaAdmissao = reader.GetOrdinal("DT_ADMISSAO");
                        int colunaFuncao = reader.GetOrdinal("FUNCAO_FUNC");
                        int colunaSalario = reader.GetOrdinal("SALARIO_BASE");
                        int colunaCPF = reader.GetOrdinal("CPF");
                        int colunaIdEmpresa = reader.GetOrdinal("ID_EMPRESA");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaNome) && !reader.IsDBNull(colunaAdmissao) &&
                            !reader.IsDBNull(colunaStatus) && !reader.IsDBNull(colunaFuncao) && !reader.IsDBNull(colunaSalario) &&
                            !reader.IsDBNull(colunaCPF) && !reader.IsDBNull(colunaIdEmpresa))
                        {
                            FUNCIONARIO funcionario = new FUNCIONARIO(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaStatus),
                                reader.GetString(colunaNome),
                                reader.GetDateTime(colunaAdmissao),
                                reader.GetString(colunaFuncao),
                                reader.GetDecimal(colunaSalario),
                                reader.GetString(colunaCPF),
                                reader.GetInt32(colunaIdEmpresa)
                            );

                            listaFuncionarios.Add(funcionario); // Adiciona o funcionário à lista
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar Funcionários: " + ex.Message);
                throw;
            }
            finally
            {
                con.desconectar();
            }

            return listaFuncionarios;
        }


        public FUNCIONARIO Alterar(FUNCIONARIO funcionarioAlterado)
        {

            FUNCIONARIO funcionarioAtualizado = null;


            try
            {
                cmd.Connection = con.conectar();

                // Lógica SQL para atualizar os dados da empresa no banco de dados

                cmd.CommandText = "UPDATE FUNCIONARIO SET ID_EMPRESA = @idEmpresa, COD_FUNC = @codFunc, STATUS_FUNC= @statusFunc ,NOME_FUNC = @NomeFunc,GENERO = @genero , EST_CIVIL = @estCivil, DT_NASC = @dtNasc, CPF = @Cpf, RG = @Rg,PIS = @Pis,DT_ADMISSAO = @DtAdmissao,TURNO_FUNC = @TurnoFunc, FUNCAO_FUNC = @FuncaoFunc, SALARIO_BASE = @SalarioBase, CEP_FUNC = @CepFunc,RUA_FUNC = @RuaFunc,  NUM_FUNC = @NumFunc,  BAIRRO__FUNC = @BairroFunc, CIDADE_FUNC = @CidadeFunc, COMPLEM__FUNC = @complemento, UF_FUNC = @UfFunc, TEL_FUNC = @TelFunc, EMAIL_FUNC = @EmailFunc, AGENCIA_PGTO = @AgenciaPgto,CONTA_PGTO = @ContaPgto, TIPO_CONTA = @TipoConta, VL_ALIMENTACAO = @VlAlimentacao, VL_TRANSPORTE = @VlTransporte, LOGIN_DEMONSTRATIVO = @LoginDemonstrativo, SENHA_DEMONSTRATIVO = @SenhaDemonstrativo WHERE ID_FUNCIONARIO = @IdFuncionario";

                cmd.Parameters.AddWithValue("@IdFuncionario", funcionarioAlterado.ID_FUNCIONARIO);
                cmd.Parameters.AddWithValue("@idEmpresa", funcionarioAlterado.ID_EMPRESA);
                cmd.Parameters.AddWithValue("@codFunc", funcionarioAlterado.COD_FUNC);
                cmd.Parameters.AddWithValue("@statusFunc", funcionarioAlterado.STATUS_FUNC);
                cmd.Parameters.AddWithValue("@nomeFunc", funcionarioAlterado.NOME_FUNC);
                cmd.Parameters.AddWithValue("@genero", funcionarioAlterado.GENERO);
                cmd.Parameters.AddWithValue("@estCivil", funcionarioAlterado.EST_CIVIL);
                cmd.Parameters.AddWithValue("@dtNasc", funcionarioAlterado.DT_NASC);
                cmd.Parameters.AddWithValue("@Cpf", funcionarioAlterado.CPF);
                cmd.Parameters.AddWithValue("@Rg", funcionarioAlterado.RG);
                cmd.Parameters.AddWithValue("@Pis", funcionarioAlterado.PIS);
                cmd.Parameters.AddWithValue("@DtAdmissao", funcionarioAlterado.DT_ADMISSAO);
                cmd.Parameters.AddWithValue("@TurnoFunc", funcionarioAlterado.TURNO_FUNC);
                cmd.Parameters.AddWithValue("@FuncaoFunc", funcionarioAlterado.FUNCAO_FUNC);
                cmd.Parameters.AddWithValue("@SalarioBase", funcionarioAlterado.SALARIO_BASE);
                cmd.Parameters.AddWithValue("@CepFunc", funcionarioAlterado.CEP_FUNC);
                cmd.Parameters.AddWithValue("@RuaFunc", funcionarioAlterado.RUA_FUNC);
                cmd.Parameters.AddWithValue("@NumFunc", funcionarioAlterado.NUM_FUNC);
                cmd.Parameters.AddWithValue("@BairroFunc", funcionarioAlterado.BAIRRO_FUNC);
                cmd.Parameters.AddWithValue("@CidadeFunc", funcionarioAlterado.CIDADE_FUNC);
                cmd.Parameters.AddWithValue("@complemento", funcionarioAlterado.COMPLEM_FUNC);
                cmd.Parameters.AddWithValue("@UfFunc", funcionarioAlterado.UF_FUNC);
                cmd.Parameters.AddWithValue("@TelFunc", funcionarioAlterado.TEL_FUNC);
                cmd.Parameters.AddWithValue("@EmailFunc", funcionarioAlterado.EMAIL_FUNC);
                cmd.Parameters.AddWithValue("@AgenciaPgto", funcionarioAlterado.AGENCIA_PGTO);
                cmd.Parameters.AddWithValue("@ContaPgto", funcionarioAlterado.CONTA_PGTO);
                cmd.Parameters.AddWithValue("@TipoConta", funcionarioAlterado.TIPO_CONTA);
                cmd.Parameters.AddWithValue("@VlAlimentacao", funcionarioAlterado.VL_ALIMENTACAO);
                cmd.Parameters.AddWithValue("@VlTransporte", funcionarioAlterado.VL_TRANSPORTE);
                cmd.Parameters.AddWithValue("@LoginDemonstrativo", funcionarioAlterado.LOGIN_DEMONSTRATIVO);
                cmd.Parameters.AddWithValue("@SenhaDemonstrativo", funcionarioAlterado.SENHA_DEMONSTRATIVO);



                // Execute o comando SQL para realizar a atualização
                cmd.ExecuteNonQuery();

                funcionarioAlterado = funcionarioAtualizado;
            }
            catch (Exception ex)
            {
                // Lide com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao atualizar empresa: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }

            return funcionarioAtualizado;
        }

        public FUNCIONARIO ObterDadosFuncionario(int idFuncionario)
        {
            FUNCIONARIO funcionario = null;

            try
            {
                cmd.Connection = con.conectar();

                // Ajuste a consulta SQL para incluir todas as colunas necessárias
                cmd.CommandText = "SELECT * FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @IdFuncionario";
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mapeia os dados do banco de dados para o objeto FUNCIONARIO
                        funcionario = new FUNCIONARIO
                        {
                            ID_FUNCIONARIO = reader.GetInt32(reader.GetOrdinal("ID_FUNCIONARIO")),
                            ID_EMPRESA = reader.GetInt32(reader.GetOrdinal("ID_EMPRESA")),
                            COD_FUNC = reader.GetString(reader.GetOrdinal("COD_FUNC")),
                            STATUS_FUNC = reader.GetString(reader.GetOrdinal("STATUS_FUNC")),
                            NOME_FUNC = reader.GetString(reader.GetOrdinal("NOME_FUNC")),
                            GENERO = reader.GetString(reader.GetOrdinal("GENERO")),
                            EST_CIVIL = reader.GetString(reader.GetOrdinal("EST_CIVIL")),
                            DT_NASC = reader.GetDateTime(reader.GetOrdinal("DT_NASC")),
                            CPF = reader.GetString(reader.GetOrdinal("CPF")),
                            RG = reader.GetString(reader.GetOrdinal("RG")),
                            PIS = reader.GetString(reader.GetOrdinal("PIS")),
                            DT_ADMISSAO = reader.GetDateTime(reader.GetOrdinal("DT_ADMISSAO")),
                            TURNO_FUNC = reader.GetString(reader.GetOrdinal("TURNO_FUNC")),
                            FUNCAO_FUNC = reader.GetString(reader.GetOrdinal("FUNCAO_FUNC")),
                            SALARIO_BASE = reader.GetDecimal(reader.GetOrdinal("SALARIO_BASE")),
                            CEP_FUNC = reader.GetString(reader.GetOrdinal("CEP_FUNC")),
                            RUA_FUNC = reader.GetString(reader.GetOrdinal("RUA_FUNC")),
                            NUM_FUNC = reader.GetString(reader.GetOrdinal("NUM_FUNC")),
                            BAIRRO_FUNC = reader.GetString(reader.GetOrdinal("BAIRRO__FUNC")),
                            CIDADE_FUNC = reader.GetString(reader.GetOrdinal("CIDADE_FUNC")),
                            COMPLEM_FUNC = reader.IsDBNull(reader.GetOrdinal("COMPLEM__FUNC")) ? null : reader.GetString(reader.GetOrdinal("COMPLEM__FUNC")),
                            UF_FUNC = reader.GetString(reader.GetOrdinal("UF_FUNC")),
                            TEL_FUNC = reader.GetString(reader.GetOrdinal("TEL_FUNC")),
                            EMAIL_FUNC = reader.GetString(reader.GetOrdinal("EMAIL_FUNC")),
                            AGENCIA_PGTO = reader.GetString(reader.GetOrdinal("AGENCIA_PGTO")),
                            CONTA_PGTO = reader.GetString(reader.GetOrdinal("CONTA_PGTO")),
                            TIPO_CONTA = reader.GetString(reader.GetOrdinal("TIPO_CONTA")),
                            VL_ALIMENTACAO = reader.GetString(reader.GetOrdinal("VL_ALIMENTACAO")),
                            VL_TRANSPORTE = reader.GetString(reader.GetOrdinal("VL_TRANSPORTE")),
                            LOGIN_DEMONSTRATIVO = reader.GetString(reader.GetOrdinal("LOGIN_DEMONSTRATIVO")),
                            SENHA_DEMONSTRATIVO = reader.GetString(reader.GetOrdinal("SENHA_DEMONSTRATIVO")),
                            ID_USUARIO = reader.GetInt32(reader.GetOrdinal("ID_USUARIO"))
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados do funcionário: " + ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear(); // Limpa os parâmetros antes de fechar a conexão
                con.desconectar();
            }

            return funcionario;
        }


        public List<FUNCIONARIO> ListarFuncionariosPorEmpresa(int idEmpresa)
        {
            List<FUNCIONARIO> listaFuncionarios = new List<FUNCIONARIO>();

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT ID_FUNCIONARIO, STATUS_FUNC, NOME_FUNC, DT_ADMISSAO, FUNCAO_FUNC, SALARIO_BASE, CPF, ID_EMPRESA FROM FUNCIONARIO WHERE ID_EMPRESA = @IdEmpresa";

                // Adiciona o parâmetro para o ID_EMPRESA
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_FUNCIONARIO");
                        int colunaStatus = reader.GetOrdinal("STATUS_FUNC");
                        int colunaNome = reader.GetOrdinal("NOME_FUNC");
                        int colunaAdmissao = reader.GetOrdinal("DT_ADMISSAO");
                        int colunaFuncao = reader.GetOrdinal("FUNCAO_FUNC");
                        int colunaSalario = reader.GetOrdinal("SALARIO_BASE");
                        int colunaCPF = reader.GetOrdinal("CPF");
                        int colunaIdEmpresa = reader.GetOrdinal("ID_EMPRESA");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaNome) && !reader.IsDBNull(colunaAdmissao) &&
                            !reader.IsDBNull(colunaStatus) && !reader.IsDBNull(colunaFuncao) && !reader.IsDBNull(colunaSalario) &&
                            !reader.IsDBNull(colunaCPF) && !reader.IsDBNull(colunaIdEmpresa))
                        {
                            FUNCIONARIO funcionario = new FUNCIONARIO(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaStatus),
                                reader.GetString(colunaNome),
                                reader.GetDateTime(colunaAdmissao),
                                reader.GetString(colunaFuncao),
                                reader.GetDecimal(colunaSalario),
                                reader.GetString(colunaCPF),
                                reader.GetInt32(colunaIdEmpresa)
                            );

                            listaFuncionarios.Add(funcionario); // Adiciona o funcionário à lista
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar Funcionários por Empresa: " + ex.Message);
                throw;
            }
            finally
            {
                con.desconectar();
            }

            return listaFuncionarios;
        }



        public void AtualizarQuantidadeFuncionarios(int idEmpresa)
        {
            try
            {

                cmd.CommandText = "UPDATE EMPRESA SET QTDE_FUNCIONARIOS = (SELECT COUNT(*) FROM FUNCIONARIO WHERE ID_EMPRESA = @idEmpresa) WHERE ID_EMPRESA = @idEmpresa";
                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Trate o erro conforme necessário, por exemplo, lançando uma exceção ou registrando em log
                Console.WriteLine("Erro ao atualizar quantidade de funcionários: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        public int ObterQuantidadeFuncionariosPorEmpresa(int idEmpresa)
        {
            int quantidade = 0;

            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM FUNCIONARIO WHERE ID_EMPRESA = @idEmpresa";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idEmpresa", idEmpresa);

                cmd.Connection = con.conectar();
                quantidade = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter a quantidade de funcionários por empresa: " + ex.Message);
                // Trate o erro conforme necessário, por exemplo, lançando uma exceção ou registrando em log
            }
            finally
            {
                con.desconectar();
            }

            return quantidade;
        }







    }
}

