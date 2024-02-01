// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar as operações relacionadas à folha de pagamento
    internal class ControllerFolhaPag
    {
        // Propriedades públicas da classe
        public DaoFolhaPag daoFolhaPag;
        public string mensagem = "";
        public bool Tem = false;

        // Construtor da classe, inicializa o objeto DaoFolhaPag
        public ControllerFolhaPag()
        {
            daoFolhaPag = new DaoFolhaPag();
        }

        // Método para cadastrar uma nova folha de pagamento
        public string NovaFolhaPagamento(string codFolha, DateTime dataInic, DateTime dataFim, DateTime dataCredito, int idUsuario)
        {
            // Cria uma instância do DaoFolhaPag
            DaoFolhaPag daoFolhaPag = new DaoFolhaPag();

            // Chama o método NovaFolhaPagamento do objeto daoFolhaPag
            string mensagem = daoFolhaPag.NovaFolhaPagamento(
                codFolha,
                dataInic,
                dataFim,
                dataCredito,
                idUsuario
            );

            // Verifica se a folha de pagamento foi cadastrada com sucesso
            if (daoFolhaPag.Tem)
            {
                this.Tem = true;
                return "Folha de pagamento cadastrada com sucesso!";
            }
            else
            {
                // Retorna uma mensagem de erro em caso de falha no cadastro
                return "Erro ao cadastrar folha de pagamento: " + mensagem;
            }
        }

        // Método para buscar uma folha de pagamento por ID
        public FolhaPag BuscarFolhaporId(int idFolhaPgto)
        {
            try
            {
                // Chama o método BuscarFolhaporId do objeto daoFolhaPag
                return daoFolhaPag.BuscarFolhaporId(idFolhaPgto);
            }
            catch (Exception ex)
            {
                // Lida com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar Folha por ID: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        // Método para listar todas as folhas de pagamento
        public List<FolhaPag> ListarTodos()
        {
            // Chama o método ListarFolhasPagamento do objeto daoFolhaPag
            return daoFolhaPag.ListarFolhasPagamento();
        }

        // Método para obter informações da folha de pagamento por ID
        public FolhaPag ObterFolhaPagtoPorId(int idFolhaPgto)
        {
            try
            {
                // Chama o método ObterDadosdaFolha do objeto daoFolhaPag
                FolhaPag folhaPag = daoFolhaPag.ObterDadosdaFolha(idFolhaPgto);

                return folhaPag;
            }
            catch (Exception ex)
            {
                // Trata a exceção de acordo com a sua lógica de tratamento de erros
                Console.WriteLine("Erro no Controller ao obter Folha por ID: " + ex.Message);

                // Propaga a exceção para ser tratada em um nível superior, se necessário
                throw;
            }
        }
    }
}
