using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoHumanity.Controller;
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Views;

namespace ProjetoHumanity.Models.dao
{

    internal class LoginDaoComandos
    {
        public string mensagem = ""; // Mensagem de erro ou sucesso;
        public bool Tem = false; // Indica se as credenciais de login foram encontradas no banco de dados
        SqlCommand cmd = new SqlCommand(); // Comando SQL para interação com o banco de dados
        ConexaoLogin con = new ConexaoLogin(); // Instância da classe de conexão com o banco de dados
        SqlDataReader dr; // Leitor de dados retornado pela execução de comandos SQL

        // Método para verificar as credenciais de login

        public bool VerificarLogin(string LoginUser, string SenhaUser)
        {
            cmd.CommandText = "SELECT * FROM USUARIO WHERE LOGIN_USER = @nomeUsuario";
            cmd.Parameters.AddWithValue("@nomeUsuario", LoginUser);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();

                    //int tentativasFalhas = Convert.ToInt32(dr["TENTATIVAS_FALHAS"]);

                    // Recupera as informações do usuário
                    int idUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    byte[] senhaHash = (byte[])dr["SENHA_USER"];
                    byte[] salt = (byte[])dr["SALT"];

                    // Converte a senha fornecida para bytes
                    byte[] senhaBytes = Encoding.UTF8.GetBytes(SenhaUser);

                    // Converte senhaHash e salt para strings base64
                    string senhaHashString = Convert.ToBase64String(senhaHash);
                    string saltString = Convert.ToBase64String(salt);


                    // Verifica a senha usando o PasswordHasher
                    bool senhaCorreta = PasswordHasher.VerifyPassword(Encoding.UTF8.GetString(senhaBytes), senhaHash, salt);

                    if (senhaCorreta)
                    {
                        // Senha correta, o login é bem-sucedido
                        Tem = true;

                        // Resetar tentativas falhas
                        ResetarTentativasFalhas(LoginUser);

                        // Agora você pode passar o idUsuario para a tela do menu principal

                        BuscarIdUsuarioPorLogin(LoginUser);
                        // Agora você pode passar o idUsuario para a tela do menu principal
                        TelaMenu telaMenu = new TelaMenu(idUsuario);
                        telaMenu.Show();
                    }
                    else
                    {
                        // Senha incorreta
                        AumentarTentativasFalhas(LoginUser);
                        ExibirMensagemLoginFalho(LoginUser);
                    }
                }
                else
                {
                    // Usuário não encontrado
                    ExibirMensagemLoginFalho(LoginUser);
                }
            }
            catch (SqlException ex)
            {
                mensagem = "Erro com o banco de dados: " + ex.Message;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.desconectar();
                cmd.Parameters.Clear();
                dr?.Close();
            }

            return Tem;
        }

        private void ResetarTentativasFalhas(string LoginUser)
        {
            try
            {
                using (SqlCommand updateCmd = new SqlCommand())
                {
                    updateCmd.Connection = con.conectar();
                    updateCmd.CommandText = "UPDATE USUARIO SET TENTATIVAS_FALHAS = 0 WHERE LOGIN_USER = @Login";
                    updateCmd.Parameters.AddWithValue("@Login", LoginUser);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao resetar tentativas falhas: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        private void AumentarTentativasFalhas(string LoginUser)
        {
            try
            {
                using (SqlCommand updateCmd = new SqlCommand())
                {
                    updateCmd.Connection = con.conectar();
                    updateCmd.CommandText = "UPDATE USUARIO SET TENTATIVAS_FALHAS = TENTATIVAS_FALHAS + 1 WHERE LOGIN_USER = @Login";
                    updateCmd.Parameters.AddWithValue("@Login", LoginUser);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao aumentar tentativas falhas: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        private void ExibirMensagemLoginFalho(string LoginUser)
        {
            int Erros = ObterTentativasFalhas(LoginUser);

            if (Erros >= 3)
            {
                MessageBox.Show($"Sua conta foi bloqueada devido a {Erros} tentativas de login malsucedidas. Entre em contato com o suporte.");
                BloquearUsuario(LoginUser); // Bloqueia o usuário
            }
            else
            {
                MessageBox.Show($"Login ou senha incorretos! Tentativa {Erros} de 3.");
                // Aqui você pode adicionar lógica adicional para lidar com tentativas falhas menores que 3, se necessário.
                // Por exemplo, exibir uma mensagem de erro, aguardar um tempo antes de permitir novas tentativas, etc.
            }
        }

        private int ObterTentativasFalhas(string LoginUser)
        {
            int tentativasFalhas = 0;

            try
            {
                using (SqlCommand selectCmd = new SqlCommand())
                {
                    selectCmd.Connection = con.conectar();
                    selectCmd.CommandText = "SELECT TENTATIVAS_FALHAS FROM USUARIO WHERE LOGIN_USER = @Login";
                    selectCmd.Parameters.AddWithValue("@Login", LoginUser);
                    object result = selectCmd.ExecuteScalar();

                    if (result != null)
                    {
                        tentativasFalhas = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter tentativas falhas: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }

            return tentativasFalhas;
        }

        private void BloquearUsuario(string login)
        {
            try
            {
                using (SqlCommand updateCmd = new SqlCommand())
                {
                    updateCmd.Connection = con.conectar();
                    updateCmd.CommandText = "UPDATE USUARIO SET STATUS_USER = 'B' WHERE LOGIN_USER = @Login";
                    updateCmd.Parameters.AddWithValue("@Login", login);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao bloquear usuário: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }


        // Método para buscar o ID do usuário pelo login
        public int BuscarIdUsuarioPorLogin(string LoginUser)
        {
            int idUsuario = 0;  // Valor padrão se nenhum usuário for encontrado

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    using (SqlCommand command = new SqlCommand("SELECT ID_USUARIO FROM USUARIO WHERE LOGIN_USER = @Login", connection))
                    {
                        command.Parameters.AddWithValue("@Login", LoginUser);
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out idUsuario))
                        {
                            // A conversão para int foi bem-sucedida
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro ao buscar ID de usuário por login: " + ex.Message);
                // Considere lançar a exceção novamente se você não pode lidar com ela aqui
                throw new Exception("Erro ao buscar ID de usuário por login.", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro geral ao buscar ID de usuário por login: " + ex.Message);
                // Considere lançar a exceção novamente se você não pode lidar com ela aqui
                throw;
            }
            return idUsuario;
        }

        public string ObterStatusUsuario(string LoginUser)
        {
            string statusUsuario = "";

            try
            {
                using (SqlConnection connection = con.conectar())
                {
                    using (SqlCommand command = new SqlCommand("SELECT STATUS_USER FROM USUARIO WHERE LOGIN_USER = @Login", connection))
                    {

                        command.Parameters.AddWithValue("@Login", LoginUser);
                        using (SqlDataReader dr = command.ExecuteReader())  // Corrigido para usar 'command' ao invés de 'cmd'
                        {
                            if (dr.Read())
                            {
                                statusUsuario = dr.GetString(dr.GetOrdinal("STATUS_USER"));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter status do usuário: " + ex.Message);
            }
            finally
            {
                // Certifica-se de que a conexão é fechada, independentemente do resultado
                // dr.Close(); // Não é necessário fechar explicitamente o DataReader aqui, pois está dentro de um bloco 'using'
                con.desconectar();
            }
            return statusUsuario;
        }








































    }
}























