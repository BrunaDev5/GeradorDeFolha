
using ProjetoHumanity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoHumanity.Models.dao
{
    internal class DaoEmpresa
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             

        public string NovaEmpresa(string razaoSocial, string cnpj, string codEmpresa, string nomeFantasia,string inscEstadual, string ruaEmpresa, string numeroEmpresa, 
                                  string bairroEmpresa, string cidadeEmpresa, string ufEmpresa, string compleEmpresa, string contatoEmpresa, string emailEmpresa,string responsEmpresa, string statusEmpresa, int idUsuario)
        {
            try
            {
                // Define o comando SQL para inserir uma nova empresa na tabela EMPRESA
                cmd.CommandText = "INSERT INTO EMPRESA (STATUS_EMPRESA, RAZAO_SOCIAL, CODIGO_EMP, CNPJ_EMPRESA, INSC_ESTADUAL, NOME_FANTASIA, RUA_EMP, NUM_EMP, BAIRRO_EMP, CIDADE_EMP, UF_EMP, COMPLE_EMP, CONTATO_EMP, EMAIL_EMP, RESPONS_EMP, QTDE_FUNCIONARIOS, ID_USUARIO, DATA_CADASTRO) " +
                     "VALUES (@StatusEmpresa, @RazaoSocial, @CodigoEmpresa, @CnpjEmpresa, @InscEstadual, @NomeFantasia, @RuaEmpresa, @NumEmpresa, @BairroEmpresa, @CidadeEmpresa, @UfEmpresa, @CompleEmpresa, @ContatoEmpresa, @EmailEmpresa, @ResponsEmpresa, 0, @IdUsuario, @DataCadastro)";

                // Estabelece a conexão
                cmd.Connection = con.conectar();

                // Adiciona os parâmetros
                cmd.Parameters.AddWithValue("@RazaoSocial", razaoSocial);
                cmd.Parameters.AddWithValue("@CodigoEmpresa", codEmpresa);
                cmd.Parameters.AddWithValue("@CnpjEmpresa", cnpj);
                cmd.Parameters.AddWithValue("@InscEstadual", inscEstadual);
                cmd.Parameters.AddWithValue("@NomeFantasia", nomeFantasia);
                cmd.Parameters.AddWithValue("@RuaEmpresa", ruaEmpresa);
                cmd.Parameters.AddWithValue("@NumEmpresa", numeroEmpresa);
                cmd.Parameters.AddWithValue("@BairroEmpresa", bairroEmpresa);
                cmd.Parameters.AddWithValue("@CidadeEmpresa", cidadeEmpresa);
                cmd.Parameters.AddWithValue("@UfEmpresa", ufEmpresa);
                cmd.Parameters.AddWithValue("@CompleEmpresa", compleEmpresa);
                cmd.Parameters.AddWithValue("@ContatoEmpresa", contatoEmpresa);
                cmd.Parameters.AddWithValue("@EmailEmpresa", emailEmpresa);
                cmd.Parameters.AddWithValue("@ResponsEmpresa", responsEmpresa);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@StatusEmpresa", statusEmpresa);
                cmd.Parameters.AddWithValue("@DataCadastro", DateTime.Now);

                // Executa o comando SQL para inserir a nova empresa
                cmd.ExecuteNonQuery();

                mensagem = "Empresa cadastrada com sucesso!";
                Tem = true;

                // Aqui você pode adicionar a lógica para registrar a auditoria
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao cadastrar empresa: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }


        public EMPRESA BuscarEmpresaPorid(int idEmpresa)
        {
            EMPRESA empresa = null;

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT ID_EMPRESA,STATUS_EMPRESA,RAZAO_SOCIAL,CNPJ_EMPRESA,DATA_CADASTRO FROM EMPRESA WHERE ID_EMPRESA = @Id";
                cmd.Parameters.AddWithValue("@Id", idEmpresa);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_EMPRESA");
                        int colunaStatus = reader.GetOrdinal("STATUS_EMPRESA");
                        int colunaRazaoSocial = reader.GetOrdinal("RAZAO_SOCIAL");
                        int colunaCnpj = reader.GetOrdinal("CNPJ_EMPRESA");
                        int colunaDataCadastro = reader.GetOrdinal("DATA_CADASTRO");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaRazaoSocial) && !reader.IsDBNull(colunaCnpj) &&
                            !reader.IsDBNull(colunaStatus) && !reader.IsDBNull(colunaDataCadastro))
                        {
                            empresa = new EMPRESA(

                                reader.GetInt32(colunaId),
                                reader.GetString(colunaStatus),
                                reader.GetString(colunaRazaoSocial),
                                reader.GetString(colunaCnpj),
                                reader.GetDateTime(colunaDataCadastro)
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Lide com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar usuário por ID: " + ex.Message);
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

            return empresa;
        }


        public List<EMPRESA> ListarEmpresas()
        {
            List<EMPRESA> listaEmpresa = new List<EMPRESA>();

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT ID_EMPRESA,STATUS_EMPRESA,RAZAO_SOCIAL,CNPJ_EMPRESA,DATA_CADASTRO FROM EMPRESA ";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_EMPRESA");
                        int colunaStatus = reader.GetOrdinal("STATUS_EMPRESA");
                        int colunaRazaoSocial = reader.GetOrdinal("RAZAO_SOCIAL");
                        int colunaCnpj = reader.GetOrdinal("CNPJ_EMPRESA");
                        int colunaDataCadastro = reader.GetOrdinal("DATA_CADASTRO");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaRazaoSocial) && !reader.IsDBNull(colunaCnpj) &&
                            !reader.IsDBNull(colunaStatus) && !reader.IsDBNull(colunaDataCadastro))
                        {
                            EMPRESA empresa = new EMPRESA(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaStatus),
                                reader.GetString(colunaRazaoSocial),
                                reader.GetString(colunaCnpj),
                                reader.GetDateTime(colunaDataCadastro)
                            );

                            listaEmpresa.Add(empresa); // Adiciona a empresa à lista
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar Empresas: " + ex.Message);
                throw;
            }
            finally
            {
                con.desconectar();
            }

            return listaEmpresa;
        }


        public EMPRESA Alterar(EMPRESA empresaAlterada)
        {
            EMPRESA empresaAtualizada = null;

            try
            {
                cmd.Connection = con.conectar();
               

                // Lógica SQL para atualizar os dados da empresa no banco de dados

                cmd.CommandText = "UPDATE EMPRESA SET STATUS_EMPRESA = @Status, RAZAO_SOCIAL = @RazaoSocial, CNPJ_EMPRESA = @Cnpj, INSC_ESTADUAL = @InscEstadual, NOME_FANTASIA = @NomeFantasia, RUA_EMP = @Rua, NUM_EMP = @Num, BAIRRO_EMP = @Bairro, CIDADE_EMP = @Cidade, UF_EMP = @Uf, COMPLE_EMP = @Comple, CONTATO_EMP = @Contato, EMAIL_EMP = @Email, RESPONS_EMP = @Respons WHERE ID_EMPRESA = @IdEmpresa";

                // Removendo o parâmetro para o ID_EMPRESA da lista de parâmetros
                cmd.Parameters.AddWithValue("@IdEmpresa", empresaAlterada.ID_EMPRESA);
                cmd.Parameters.AddWithValue("@Status", empresaAlterada.STATUS_EMPRESA);
                cmd.Parameters.AddWithValue("@RazaoSocial", empresaAlterada.RAZAO_SOCIAL);
                cmd.Parameters.AddWithValue("@Cnpj", empresaAlterada.CNPJ_EMPRESA);
                cmd.Parameters.AddWithValue("@InscEstadual", empresaAlterada.INSC_ESTADUAL);
                cmd.Parameters.AddWithValue("@NomeFantasia", empresaAlterada.NOME_FANTASIA);
                cmd.Parameters.AddWithValue("@Rua", empresaAlterada.RUA_EMP);
                cmd.Parameters.AddWithValue("@Num", empresaAlterada.NUM_EMP);
                cmd.Parameters.AddWithValue("@Bairro", empresaAlterada.BAIRRO_EMP);
                cmd.Parameters.AddWithValue("@Cidade", empresaAlterada.CIDADE_EMP);
                cmd.Parameters.AddWithValue("@Uf", empresaAlterada.UF_EMP);
                cmd.Parameters.AddWithValue("@Comple", empresaAlterada.COMPLE_EMP);
                cmd.Parameters.AddWithValue("@Contato", empresaAlterada.CONTATO_EMP);
                cmd.Parameters.AddWithValue("@Email", empresaAlterada.EMAIL_EMP);
                cmd.Parameters.AddWithValue("@Respons", empresaAlterada.RESPONS_EMP);
                
                // Execute o comando SQL para realizar a atualização
                cmd.ExecuteNonQuery();

                empresaAlterada = empresaAtualizada;
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

            return empresaAtualizada;
        }

       
        public EMPRESA ObterDadosEmpresa(int idEmpresa)
        {
            EMPRESA empresa = null;

            try
            {
                cmd.Connection = con.conectar();

                // Ajuste a consulta SQL para incluir todas as colunas necessárias
                cmd.CommandText = "SELECT * FROM EMPRESA WHERE ID_EMPRESA = @IdEmpresa";
                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Mapeia os dados do banco de dados para o objeto EMPRESA
                        empresa = new EMPRESA
                        {
                            ID_EMPRESA = reader.GetInt32(reader.GetOrdinal("ID_EMPRESA")),
                            STATUS_EMPRESA = reader.GetString(reader.GetOrdinal("STATUS_EMPRESA")),
                            CODIGO_EMP = reader.GetString(reader.GetOrdinal("CODIGO_EMP")),
                            RAZAO_SOCIAL = reader.GetString(reader.GetOrdinal("RAZAO_SOCIAL")),
                            CNPJ_EMPRESA = reader.GetString(reader.GetOrdinal("CNPJ_EMPRESA")),
                            INSC_ESTADUAL = reader.GetString(reader.GetOrdinal("INSC_ESTADUAL")),
                            NOME_FANTASIA = reader.GetString(reader.GetOrdinal("NOME_FANTASIA")),
                            RUA_EMP = reader.GetString(reader.GetOrdinal("RUA_EMP")),
                            NUM_EMP = reader.GetString(reader.GetOrdinal("NUM_EMP")),
                            BAIRRO_EMP = reader.GetString(reader.GetOrdinal("BAIRRO_EMP")),
                            CIDADE_EMP = reader.GetString(reader.GetOrdinal("CIDADE_EMP")),
                            UF_EMP = reader.GetString(reader.GetOrdinal("UF_EMP")),
                            COMPLE_EMP = reader.GetString(reader.GetOrdinal("COMPLE_EMP")),
                            CONTATO_EMP = reader.GetString(reader.GetOrdinal("CONTATO_EMP")),
                            EMAIL_EMP = reader.GetString(reader.GetOrdinal("EMAIL_EMP")),
                            RESPONS_EMP = reader.GetString(reader.GetOrdinal("RESPONS_EMP")),
                            QTDE_FUNCIONARIOS = reader.GetInt32(reader.GetOrdinal("QTDE_FUNCIONARIOS")),
                            DATA_CADASTRO = reader.GetDateTime(reader.GetOrdinal("DATA_CADASTRO"))
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados da empresa: " + ex.Message);
                throw;

            }
            finally
            {
                cmd.Parameters.Clear(); // Limpa os parâmetros antes de fechar a conexão
                con.desconectar();
            }

            return empresa;
        }

        public List<FUNCIONARIO> buscarFuncionariosdaEmpresa(int idEmpresa)
        {
            List<FUNCIONARIO> listaFuncionarios = new List<FUNCIONARIO>();

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = "SELECT * FROM Funcionarios WHERE ID_EMPRESA = @IdEmpresa";

                // Certifique-se de criar um novo SqlCommand para evitar conflitos com o comando anterior
                using (SqlCommand command = new SqlCommand(cmd.CommandText, cmd.Connection))
                {
                    command.Parameters.AddWithValue("@IdEmpresa", idEmpresa);

                    using (SqlDataReader reader = command.ExecuteReader())
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

    }

}









