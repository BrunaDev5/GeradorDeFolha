// Importa os namespaces necessários
using System;
using ProjetoHumanity.Models.Classes; // Supondo que este namespace contenha as classes necessárias
using ProjetoHumanity.Models.dao; // Supondo que este namespace contenha as classes necessárias

// Declaração do namespace e da classe ControleCadastroUser
namespace ProjetoHumanity.Controller
{
    // Declaração da classe ControleCadastroUser
    internal class ControleCadastroUser
    {
        // Declaração de variáveis públicas para armazenar mensagens e um indicador de existência (Tem)
        public string mensagem = "";
        public bool Tem = false;

        // Método para cadastrar um novo usuário
        public string NovoUsuario(string NomeUser, string EmailUser, string LoginUser, string NivelUser, string StatusUser, byte[] SenhaUser, byte[] Salt)
        {


            // Cria uma instância da classe CadastroUserDao
            CadastroUserDao cadastroUserDao = new CadastroUserDao();

            // Chama o método NovoUsuario da instância CadastroUserDao, passando os parâmetros recebidos
            // A mensagem retornada é armazenada na variável mensagem desta classe
            this.mensagem = cadastroUserDao.NovoUsuario(NomeUser, EmailUser, LoginUser, NivelUser, StatusUser, SenhaUser, Salt);

            // Verifica se o usuário foi cadastrado com sucesso (se a propriedade Tem da classe CadastroUserDao é true)
            if (cadastroUserDao.Tem)
            {
                // Atualiza a propriedade Tem desta classe
                this.Tem = true;



                // Retorna uma mensagem de sucesso
                return "Usuário cadastrado com sucesso!";
            }
            else
            {
                // Se houve algum erro no cadastro, retorna uma mensagem de erro
                return "Erro ao cadastrar usuário: " + cadastroUserDao.mensagem;
            }
        }
    }
}

