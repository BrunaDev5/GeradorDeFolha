using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using ProjetoHumanity.Views;
using System;
using System.Windows.Forms;

namespace ProjetoHumanity.Controller
{
    public class ControleLoginUser
    {
        public bool Tem; // Flag indicando se o login foi bem-sucedido
        public string mensagem = ""; // Mensagem para armazenar informações sobre o login
        private LoginDaoComandos loginDao = new LoginDaoComandos();// Método para verificar o login


        // Método para verificar o login
        public bool Acessar(string LoginUser, string SenhaUser)
        {
            
            // Tenta autenticar o usuário
            bool credenciaisValidas = loginDao.VerificarLogin(LoginUser, SenhaUser);

            if (credenciaisValidas)
            {
                // Autenticação bem-sucedida, você pode adicionar lógica adicional aqui se necessário
            }
            else
            {
                // Autenticação falhou, você pode adicionar lógica adicional aqui se necessário
            }

            return credenciaisValidas;
        }

        public bool ObterStatusUsuario(string LoginUser)
        {
            // Cria uma instância de LoginDaoComandos para interagir com o banco de dados
            LoginDaoComandos loginDao = new LoginDaoComandos();

            string statusUsuario = loginDao.ObterStatusUsuario(LoginUser);
            return statusUsuario == "B"; // Retorna true se estiver bloqueado, false se estiver ativo
        }


        public int ObterIdUsuario(string LoginUser)
        {
            // Cria uma instância de LoginDaoComandos para interagir com o banco de dados
            LoginDaoComandos loginDao = new LoginDaoComandos();

            // Chama o método BuscarIdUsuarioPorLogin da instância LoginDaoComandos
            // para obter o ID do usuário associado ao login
            int idUsuario = loginDao.BuscarIdUsuarioPorLogin(LoginUser);

            return idUsuario;
        }





    }
}




