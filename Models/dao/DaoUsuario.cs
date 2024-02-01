using ProjetoHumanity.Models.Classes;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHumanity.Models.dao
{
    internal class DaoUsuario
    {
        public string mensagem = ""; // Mensagem de erro ou sucesso;
        SqlCommand cmd = new SqlCommand(); // Comando SQL para interação com o banco de dados
        ConexaoLogin con = new ConexaoLogin(); // Instância da classe de conexão com o banco de dados
        SqlDataReader dr; // Leitor de dados retornado pela execução de comandos SQL
        public bool Tem = false; // Indica se as credenciais de login foram encontradas no banco de dados

        public int ObterNivelPermissaoUsuario(int idUsuario)
        {
            int nivelPermissao = 0;

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT NIVEL_PERM FROM USUARIO WHERE ID_USUARIO = @Id";
                    cmd.Parameters.AddWithValue("@Id", idUsuario);

                    var result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        nivelPermissao = Convert.ToInt32(result);
                        Console.WriteLine($"Nível de permissão obtido para o usuário {idUsuario}: {nivelPermissao}");
                    }
                    else
                    {
                        Console.WriteLine($"Valor retornado do banco de dados é nulo ou DBNull.Value para o usuário {idUsuario}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter nível de permissão do usuário: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }

            return nivelPermissao;
        }


        public Usuario BuscarUsuarioPorID(int id)
        {
            Usuario usuario = null;

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT * FROM USUARIO WHERE ID_USUARIO = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_USUARIO");
                        int colunaNome = reader.GetOrdinal("NOME_USER");
                        int colunaEmail = reader.GetOrdinal("EMAIL_USER");
                        int colunaLogin = reader.GetOrdinal("LOGIN_USER");
                        int colunaNivel = reader.GetOrdinal("NIVEL_PERM");
                        int colunaStatus = reader.GetOrdinal("STATUS_USER");
                        

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaNome) && !reader.IsDBNull(colunaEmail) && !reader.IsDBNull(colunaLogin) && !reader.IsDBNull(colunaNivel) && !reader.IsDBNull(colunaStatus))
                        {
                            usuario = new Usuario(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaNome),
                                reader.GetString(colunaEmail),
                                reader.GetString(colunaLogin),
                                reader.GetString(colunaNivel),
                                reader.GetString(colunaStatus)
                                
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
                // Fecha a conexão no bloco finally para garantir que seja fechada mesmo em caso de exceção
                con.desconectar();
            }

            return usuario;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT * FROM USUARIO";

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int colunaId = reader.GetOrdinal("ID_USUARIO");
                        int colunaNome = reader.GetOrdinal("NOME_USER");
                        int colunaEmail = reader.GetOrdinal("EMAIL_USER");
                        int colunaLogin = reader.GetOrdinal("LOGIN_USER");
                        int colunaNivel = reader.GetOrdinal("NIVEL_PERM");
                        int colunaStatus = reader.GetOrdinal("STATUS_USER");

                        if (!reader.IsDBNull(colunaId) && !reader.IsDBNull(colunaNome) && !reader.IsDBNull(colunaEmail) && !reader.IsDBNull(colunaLogin)&& !reader.IsDBNull(colunaNivel) && !reader.IsDBNull(colunaStatus))
                        {
                            Usuario usuario = new Usuario(
                                reader.GetInt32(colunaId),
                                reader.GetString(colunaNome),
                                reader.GetString(colunaEmail),
                                reader.GetString(colunaLogin),
                                reader.GetString(colunaNivel),
                                reader.GetString(colunaStatus)
                            );

                            listaUsuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao listar usuários: " + ex.Message);
                throw;
            }
            finally
            {
                con.desconectar();
            }

            return listaUsuarios;
        }

        public Usuario Alterar(Usuario usuarioAlterado)
        {
            Usuario usuarioAtualizado = null;

            try
            {
                cmd.Connection = con.conectar();

                // Aqui você precisa escrever a lógica SQL para atualizar os dados do usuário no banco de dados
                cmd.CommandText = "UPDATE USUARIO SET NOME_USER = @Nome, EMAIL_USER = @Email, LOGIN_USER = @Login, SENHA_USER = @Senha, NIVEL_PERM = @Nivel, STATUS_USER = @Status ,SALT = @Salt WHERE ID_USUARIO = @Id";

                // Exemplo hipotético:
                cmd.Parameters.AddWithValue("@Id", usuarioAlterado.ID_USUARIO);
                cmd.Parameters.AddWithValue("@Nome", usuarioAlterado.NOME_USER);
                cmd.Parameters.AddWithValue("@Email", usuarioAlterado.EMAIL_USER);
                cmd.Parameters.AddWithValue("@Login", usuarioAlterado.LOGIN_USER);
                cmd.Parameters.AddWithValue("@Senha", usuarioAlterado.SENHA_USER);
                cmd.Parameters.AddWithValue("@Nivel", usuarioAlterado.NIVEL_PERM);
                cmd.Parameters.AddWithValue("@Status", usuarioAlterado.STATUS_USER);
                // Se o salt estiver no formato byte[], você deve usar SqlDbType.VarBinary
                cmd.Parameters.Add("@Salt", SqlDbType.VarBinary).Value = usuarioAlterado.SALT;


                // Execute o comando SQL para realizar a atualização
                cmd.ExecuteNonQuery();

                usuarioAtualizado = usuarioAlterado;
            }
            catch (Exception ex)
            {
                // Lide com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao alterar usuário no banco de dados: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }

            return usuarioAtualizado;
        }

        public void AtualizarSenhaUsuario(int idUsuario, byte[] novaSenhaHash, byte[] novoSalt)
        {
            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "UPDATE USUARIO SET SENHA_USER = @SenhaHash, SALT = @Salt WHERE ID_USUARIO = @Id";
                cmd.Parameters.AddWithValue("@SenhaHash", novaSenhaHash);
                cmd.Parameters.AddWithValue("@Salt", novoSalt);
                cmd.Parameters.AddWithValue("@Id", idUsuario);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Lide com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao atualizar senha do usuário: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão no bloco finally para garantir que seja fechada mesmo em caso de exceção
                con.desconectar();
            }
        }





    }

}