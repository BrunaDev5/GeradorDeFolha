// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.dao;
using System;
using System.Windows.Forms;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar o cálculo da folha de pagamento
    internal class ControllerCalculoFolha
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoCalculoFolha daoCalculoFolha;

        // Construtor da classe, inicializa o objeto DaoCalculoFolha
        public ControllerCalculoFolha()
        {
            daoCalculoFolha = new DaoCalculoFolha();
        }

        // Método para inserir registros na folha de pagamento
        public string InserirRegistros(int idFolhaPgto, int idUsuario)
        {
            try
            {
                // Chama o método InserirRegistros do objeto daoCalculoFolha
                return daoCalculoFolha.InserirRegistros(idFolhaPgto, idUsuario);
            }
            catch (Exception ex)
            {
                // Lida com exceções durante a execução e imprime uma mensagem de erro
                Console.WriteLine("Erro ao registrar ID: " + ex.Message);
                return null; // ou outra mensagem de erro, conforme necessário
            }
        }

        // Método para atualizar o salário base
        public string AtualizarSalarioBase(int idFolhaPgto)
        {
            try
            {
                // Cria uma nova instância do ControllerCalculoFolha
                ControllerCalculoFolha controllerCalculoFolha = new ControllerCalculoFolha();
                // Chama recursivamente o método AtualizarSalarioBase
                string resultado = controllerCalculoFolha.AtualizarSalarioBase(idFolhaPgto);
                // Exibe um MessageBox com o resultado obtido
                MessageBox.Show(resultado);
                // Retorna o resultado obtido do método chamado
                return resultado;
            }
            catch (Exception ex)
            {
                // Lida com exceções durante a execução e imprime uma mensagem de erro
                Console.WriteLine("Erro ao atualizar salário base: " + ex.Message);
                return "Erro ao atualizar salário base.";
            }
        }
    }
}
