
using ProjetoHumanity.Models.Classes;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Text;

namespace ProjetoHumanity.Models.dao
{
    internal class CadastroUserDao
    {

        public string mensagem = ""; // Mensagem de erro ou sucesso;
        SqlCommand cmd = new SqlCommand(); // Comando SQL para interação com o banco de dados
        ConexaoLogin con = new ConexaoLogin(); // Instância da classe de conexão com o banco de dados
        SqlDataReader dr; // Leitor de dados retornado pela execução de comandos SQL
        public bool Tem = false; // Indica se as credenciais de login foram encontradas no banco de dados

        public string NovoUsuario(string NomeUser, string EmailUser, string LoginUser, string NivelUser, string StatusUser, byte[] SenhaUser, byte[] Salt)
        {
            // Converte os bytes da senha e do salt para strings
            var senhaString = Encoding.UTF8.GetString(SenhaUser);
            var saltString = Encoding.UTF8.GetString(Salt);

            // Gera a senha criptografada
            var senhaCriptografada = PasswordHasher.HashPassword(senhaString);


            // Define o comando SQL para inserir um novo usuário na tabela USUARIO
            cmd.CommandText = "INSERT INTO USUARIO (NOME_USER, EMAIL_USER, LOGIN_USER,  NIVEL_PERM, STATUS_USER,SENHA_USER,SALT) " +
                                  "VALUES (@NomeUser, @EmailUser, @LoginUser, @NivelUser, @StatusUser, @SenhaUser,@salt)";

            // Adiciona os parâmetros ao comando
            cmd.Parameters.AddWithValue("@NomeUser", NomeUser);
            cmd.Parameters.AddWithValue("@EmailUser", EmailUser);
            cmd.Parameters.AddWithValue("@LoginUser", LoginUser);
            cmd.Parameters.AddWithValue("@NivelUser", NivelUser);
            cmd.Parameters.AddWithValue("@StatusUser", StatusUser);
            cmd.Parameters.Add("@SenhaUser", SqlDbType.VarBinary).Value = SenhaUser; // Use a senha criptografada como VARBINARY
            cmd.Parameters.Add("@Salt", SqlDbType.VarBinary).Value = Salt; // Adiciona o parâmetro para o salt



            try
            {
                // Estabelece a conexão
                cmd.Connection = con.conectar();

                // Executa o comando SQL para inserir o novo usuário
                cmd.ExecuteNonQuery();

                mensagem = "Usuário cadastrado com sucesso!";
                Tem = true;

            }
            catch (Exception ex)
            {
                // Em caso de erro, define a mensagem de erro
                mensagem = "Erro ao cadastrar usuário: " + ex.Message;
            }
            finally
            {
                // Certifica-se de fechar a conexão após o uso
                con.desconectar();
            }

            return mensagem;
        }

        public int ObterIdUsuarioPeloLogin(string login)
        {
            int ID_USUARIO = 0;  // Valor padrão caso não seja encontrado

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ID_USUARIO FROM USUARIO WHERE LOGIN_USER = @Login";
            cmd.Parameters.AddWithValue("@Login", login);

            try
            {
                cmd.Connection = con.conectar();
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    ID_USUARIO = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                // Tratar exceção ou logar se necessário
                Console.WriteLine("Erro ao obter ID do usuário: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }

            return ID_USUARIO;
        }

       

        












        public void RegistrarAuditoria(int idUsuario, string acao, string tabelaAlterada, string campoAlterado, string valorAntigo, string valorNovo)
        {
            SqlCommand cmdAuditoria = new SqlCommand();

            cmdAuditoria.CommandText = "INSERT INTO AUDITORIA (ID_USUARIO, AÇÃO, TABELA_ALTERADA, CAMPO_ALTERADO, VALOR_ANTIGO, VALOR_NOVO, DATA_ALTERACAO) " +
                                       "VALUES (@IdUsuario, @Acao, @TabelaAlterada, @CampoAlterado, @ValorAntigo, @ValorNovo, GETDATE())";

            cmdAuditoria.Parameters.AddWithValue("@IdUsuario", idUsuario);
            cmdAuditoria.Parameters.AddWithValue("@Acao", acao);
            cmdAuditoria.Parameters.AddWithValue("@TabelaAlterada", tabelaAlterada);
            cmdAuditoria.Parameters.AddWithValue("@CampoAlterado", campoAlterado);
            cmdAuditoria.Parameters.AddWithValue("@ValorAntigo", valorAntigo);
            cmdAuditoria.Parameters.AddWithValue("@ValorNovo", valorNovo);

            try
            {
                cmdAuditoria.Connection = con.conectar();
                cmdAuditoria.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Lide com o erro ou registre em algum log, se necessário
                Console.WriteLine("Erro ao registrar auditoria: " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }



        // Adicionar um novo método para cadastrar uma nova empresa
        public string NovaEmpresa(string NomeEmpresa, string CNPJ, string EmailEmpresa, string TelefoneEmpresa, string StatusEmpresa)
        {
            cmd.CommandText = "INSERT INTO EMPRESA (NOME_EMPRESA, CNPJ, EMAIL_EMPRESA, TELEFONE_EMPRESA, STATUS_EMPRESA) " +
                              "VALUES (@NomeEmpresa, @CNPJ, @EmailEmpresa, @TelefoneEmpresa, @StatusEmpresa)";

            cmd.Parameters.AddWithValue("@NomeEmpresa", NomeEmpresa);
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
            cmd.Parameters.AddWithValue("@EmailEmpresa", EmailEmpresa);
            cmd.Parameters.AddWithValue("@TelefoneEmpresa", TelefoneEmpresa);
            cmd.Parameters.AddWithValue("@StatusEmpresa", StatusEmpresa);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                mensagem = "Empresa cadastrada com sucesso!";
                Tem = true;
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








































    }
}
