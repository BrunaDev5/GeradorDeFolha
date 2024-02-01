// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;


// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar as operações relacionadas à empresa
    internal class ControllerEmpresa
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoEmpresa daoEmpresa;

        // Construtor da classe
        public ControllerEmpresa()
        {
            daoEmpresa = new DaoEmpresa(); // Assumindo que você tem um construtor padrão em DaoUsuario
        }

        // Método para cadastrar uma nova empresa
        public string NovaEmpresa(string razaoSocial, string codEmpresa, string cnpj, string inscEstadual, string nomeFantasia, string ruaEmpresa, string numeroEmpresa, string bairroEmpresa, string cidadeEmpresa, string ufEmpresa, string compleEmpresa, string contatoEmpresa, string emailEmpresa, string responsEmpresa, string statusEmpresa, int idUsuario)
        {
            // Cria uma instância do DaoEmpresa
            DaoEmpresa daoEmpresa = new DaoEmpresa();

            // Chama o método NovaEmpresa do objeto daoEmpresa
            this.mensagem = daoEmpresa.NovaEmpresa(
                razaoSocial,
                cnpj,
                codEmpresa,
                inscEstadual,
                nomeFantasia,
                ruaEmpresa,
                numeroEmpresa,
                bairroEmpresa,
                cidadeEmpresa,
                ufEmpresa,
                compleEmpresa,
                contatoEmpresa,
                emailEmpresa,
                responsEmpresa,
                statusEmpresa,
                idUsuario
            );

            // Verifica se a empresa foi cadastrada com sucesso
            if (daoEmpresa.Tem)
            {
                this.Tem = true;
                return "Empresa cadastrada com sucesso!";
            }
            else
            {
                // Retorna uma mensagem de erro em caso de falha no cadastro
                return "Erro ao cadastrar empresa: " + daoEmpresa.mensagem;
            }
        }

        // Método para buscar uma empresa por ID
        public EMPRESA BuscarEmpresaporId(int IdEmpresa)
        {
            try
            {
                // Chama o método BuscarEmpresaPorid do objeto daoEmpresa
                return daoEmpresa.BuscarEmpresaPorid(IdEmpresa);
            }
            catch (Exception ex)
            {
                // Lida com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar empresa por ID: " + ex.Message);
                return null;
            }
        }

        // Método para listar todas as empresas
        public List<EMPRESA> ListarTodos()
        {
            // Chama o método ListarEmpresas do objeto daoEmpresa
            return daoEmpresa.ListarEmpresas();
        }

        // Método para alterar informações da empresa
        public EMPRESA Alterar(EMPRESA empresaAlterada)
        {
            Debug.WriteLine($"Alterando empresa controller : {empresaAlterada}");

            try
            {
                // Chama o método Alterar do objeto daoEmpresa
                EMPRESA empresaAtualizada = daoEmpresa.Alterar(empresaAlterada);

                // Retorna a empresa após a alteração.
                return empresaAtualizada;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, lida com ela de alguma forma apropriada para o seu aplicativo.
                Console.WriteLine("Erro ao alterar empresa: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        // Método para obter informações da empresa por ID
        public EMPRESA ObterEmpresaPorId(int idEmpresa)
        {
            try
            {
                // Chama o método ObterDadosEmpresa do objeto daoEmpresa
                EMPRESA empresa = daoEmpresa.ObterDadosEmpresa(idEmpresa);
                return empresa;
            }
            catch (Exception ex)
            {
                // Trata a exceção de acordo com a lógica de tratamento de erros
                Console.WriteLine("Erro no Controller ao obter empresa por ID: " + ex.Message);
                throw;
            }
        }

        // Método para listar funcionários de uma empresa
        public List<FUNCIONARIO> ListaFuncionariosEmpresa(int idEmpresa)
        {
            try
            {
                // Chama o método buscarFuncionariosdaEmpresa no daoEmpresa
                return daoEmpresa.buscarFuncionariosdaEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                // Imprime uma mensagem de erro em caso de exceção
                Console.WriteLine("Erro ao obter lista de funcionários da empresa: " + ex.Message);
                throw;
            }
        }

        // Método para atualizar a quantidade de funcionários para todas as empresas
        public void AtualizarQuantidadeFuncionariosParaTodasEmpresas()
        {
            try
            {
                // Cria uma instância do DaoFuncionario
                DaoFuncionario daoFuncionario = new DaoFuncionario();

                // Obtém a lista de todas as empresas
                List<EMPRESA> todasEmpresas = daoEmpresa.ListarEmpresas();

                // Para cada empresa, obtém a quantidade de funcionários e atualiza no banco de dados
                foreach (EMPRESA empresa in todasEmpresas)
                {
                    int idEmpresa = empresa.ID_EMPRESA;
                    int quantidadeFuncionarios = daoFuncionario.ObterQuantidadeFuncionariosPorEmpresa(idEmpresa);

                    // Atualiza a quantidade de funcionários na tabela EMPRESA
                    daoFuncionario.AtualizarQuantidadeFuncionarios(idEmpresa);
                }

                Console.WriteLine("Quantidade de funcionários atualizada para todas as empresas com sucesso.");
            }
            catch (Exception ex)
            {
                // Imprime uma mensagem de erro em caso de exceção
                Console.WriteLine("Erro ao atualizar a quantidade de funcionários: " + ex.Message);
                throw;
            }
        }
    }
}
