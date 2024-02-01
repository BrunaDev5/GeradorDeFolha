// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Models.dao
{
    // Classe responsável por controlar a inserção de empresas em uma folha de pagamento
    internal class ControllerFolhaEmpresa
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoFolhaEmpresas daoFolhaEmpresas;

        // Construtor da classe, inicializa o objeto DaoFolhaEmpresas
        public ControllerFolhaEmpresa()
        {
            daoFolhaEmpresas = new DaoFolhaEmpresas();
        }

        // Método para inserir empresas em uma folha de pagamento
        public string InserirEmpresaFolha(int idEmpresa, int idFolhaPgto, decimal valorTotal, int totalFuncionarios)
        {
            // Chama o método InserirEmpresaFolha do objeto daoFolhaEmpresas
            string mensagem = daoFolhaEmpresas.InserirEmpresaFolha(
                idEmpresa,
                idFolhaPgto,
                valorTotal,
                totalFuncionarios
            );

            // Verifica se as empresas foram vinculadas com sucesso
            if (daoFolhaEmpresas.Tem)
            {
                this.Tem = true;
                return "Empresas vinculadas com sucesso!";
            }
            else
            {
                // Retorna uma mensagem de erro em caso de falha no vínculo
                return "Erro ao vincular Empresas para geração de Folha: " + mensagem;
            }
        }
    }
}
