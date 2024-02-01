// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;


// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar as operações relacionadas aos funcionários
    internal class ControllerFuncionario
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoFuncionario daoFuncionario;

        // Método para cadastrar um novo funcionário
        public string NovoFuncionario(int idEmpresa, string codFunc, string statusFunc, string nomeFunc, string genero, string estCivil, DateTime dtNasc, string cpf, string rg, string pis, DateTime dtAdmissao, string turnoFunc, string funcaoFunc, decimal salarioBase,
        string cepFunc, string ruaFunc, string numFunc, string bairroFunc, string cidadeFunc, string complemFunc, string ufFunc, string telFunc, string emailFunc, string agenciaPgto, string contaPgto, string tipoConta, string vlAlimentacao, string vlTransporte, string loginDemonstrativo, string senhaDemonstrativo, int idUsuario)
        {
            // Cria uma instância do DaoFuncionario
            DaoFuncionario daoFuncionario = new DaoFuncionario();

            // Chama o método NovoFuncionario do objeto daoFuncionario
            this.mensagem = daoFuncionario.NovoFuncionario(idEmpresa,codFunc,statusFunc, nomeFunc,genero,estCivil,dtNasc,cpf,rg,pis,
            dtAdmissao,turnoFunc,funcaoFunc,salarioBase,cepFunc,ruaFunc,numFunc,bairroFunc,cidadeFunc, complemFunc,ufFunc,telFunc,emailFunc,agenciaPgto,contaPgto,tipoConta,
            vlAlimentacao,vlTransporte,loginDemonstrativo,senhaDemonstrativo,idUsuario
            );

            // Verifica se o funcionário foi cadastrado com sucesso
            if (daoFuncionario.Tem)
            {
                this.Tem = true;
                return "Funcionário cadastrado com sucesso!";
            }
            else
            {
                // Retorna uma mensagem de erro em caso de falha no cadastro
                return "Erro ao cadastrar funcionário: " + daoFuncionario.mensagem;
            }
        }

        // Construtor da classe, inicializa o objeto DaoFuncionario
        public ControllerFuncionario()
        {
            daoFuncionario = new DaoFuncionario(); // Assumindo que você tem um construtor padrão em DaoUsuario
        }

        // Método para buscar um funcionário por ID
        public FUNCIONARIO BuscarFuncionarioPorId(int IdFuncionario)
        {
            try
            {
                // Chama o método BuscarFuncionarioPorId do objeto daoFuncionario
                return daoFuncionario.BuscarFuncionarioPorId(IdFuncionario);
            }
            catch (Exception ex)
            {
                // Lida com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar Funcionário por Id: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        // Método para listar todos os funcionários
        public List<FUNCIONARIO> ListarTodos()
        {
            // Chama o método ListarFuncionarios do objeto daoFuncionario
            return daoFuncionario.ListarFuncionarios();
        }

        // Método para alterar informações do funcionário
        public FUNCIONARIO Alterar(FUNCIONARIO funcionarioAlterado)
        {
            try
            {
                // Chama o método Alterar do objeto daoFuncionario
                FUNCIONARIO funcionarioAtualizado = daoFuncionario.Alterar(funcionarioAlterado);

                // Retorna o funcionário após a alteração.
                return funcionarioAtualizado;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, lida com ela de alguma forma apropriada para o seu aplicativo.
                Console.WriteLine("Erro ao alterar os dados do Funcionário: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        // Método para obter informações do funcionário por ID
        public FUNCIONARIO ObterFuncionarioPorId(int idFuncionario)
        {
            try
            {
                // Chama o método ObterDadosFuncionario do objeto daoFuncionario
                FUNCIONARIO funcionario = daoFuncionario.ObterDadosFuncionario(idFuncionario);

                return funcionario;
            }
            catch (Exception ex)
            {
                // Trate a exceção de acordo com a sua lógica de tratamento de erros
                Console.WriteLine("Erro no Controller ao obter Funcionário por ID: " + ex.Message);

                // Propaga a exceção para ser tratada em um nível superior, se necessário
                throw;
            }
        }

        // Método para listar funcionários por empresa
        public List<FUNCIONARIO> ListarFuncionariosPorEmpresa(int idEmpresa)
        {
            try
            {
                // Chama o método ListarFuncionariosPorEmpresa do objeto daoFuncionario
                return daoFuncionario.ListarFuncionariosPorEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter lista de funcionários por empresa: " + ex.Message);
                throw;
            }
        }
    }
}
