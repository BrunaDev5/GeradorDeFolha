// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar o Demonstrativo de Pagamento
    internal class ControllerDemonstrativo
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoDemonstrativoPagamento daoDemonstrativoPagamento;

        // Método para obter o Demonstrativo de Pagamento por ID, mês e ano
        public DemonstrativoPagamento ObterDemonstrativoporIDeMesAno(int mes, int ano, int idFuncionario)
        {
            try
            {
                // Chama o método ObterDemonstrativoPagamento do objeto daoDemonstrativoPagamento
                DemonstrativoPagamento demonstrativoPagamento = daoDemonstrativoPagamento.ObterDemonstrativoPagamento(mes, ano, idFuncionario);

                // Retorna o DemonstrativoPagamento obtido
                return demonstrativoPagamento;
            }
            catch (Exception ex)
            {
                // Lida com exceções durante a execução e imprime uma mensagem de erro
                Console.WriteLine("Erro no Controller ao obter Demonstrativo ID: " + ex.Message);
                // Propaga a exceção para ser tratada em um nível superior, se necessário
                throw;
            }
        }
    }
}
