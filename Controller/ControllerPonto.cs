// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar as operações relacionadas aos registros de ponto
    internal class ControllerPonto
    {
        // Propriedades públicas da classe
        public string mensagem = "";
        public bool Tem = false;
        public DaoRegistroPonto daoRegistroPonto;

        // Método para cadastrar um novo registro de ponto
        public string NovoRegistroPonto(RegistroPonto registro)
        {
            // Cria uma instância do DaoRegistroPonto
            daoRegistroPonto = new DaoRegistroPonto();

            // Chama o método NovoRegistroPonto do objeto daoRegistroPonto
            this.mensagem = daoRegistroPonto.NovoRegistroPonto(registro);

            // Verifica se o registro de ponto foi cadastrado com sucesso
            if (daoRegistroPonto.Tem)
            {
                this.Tem = true;
                return "Registro Cadastrado com Sucesso!";
            }
            else
            {
                // Retorna uma mensagem de erro em caso de falha no cadastro
                return "Erro ao registrar Registro de Ponto: " + daoRegistroPonto.mensagem;
            }
        }

        // Construtor da classe, inicializa o objeto DaoRegistroPonto
        public ControllerPonto()
        {
            daoRegistroPonto = new DaoRegistroPonto(); // Assumindo que você tem um construtor padrão em DaoUsuario
        }

        // Método para buscar registros de ponto por mês, ano e ID do funcionário
        public List<RegistroPonto> BuscarRegistrosPontoPorMesEAno(int mes, int ano, int idFuncionario)
        {
            try
            {
                // Chama o método BuscarRegistrosPontoPorMesEAno do objeto daoRegistroPonto
                return daoRegistroPonto.BuscarRegistrosPontoPorMesEAno(mes, ano, idFuncionario);
            }
            catch (Exception ex)
            {
                // Lida com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar registros de ponto: " + ex.Message);
                return null;
            }
        }

        // Método para verificar se um registro de ponto já existe
        public bool ExisteRegistroPonto(int idFuncionario, DateTime dataRegistro, string tipoTrabalho)
        {
            try
            {
                // Chame o método RegistroPontoJaExiste do objeto daoRegistroPonto para verificar a existência do registro
                return daoRegistroPonto.RegistroPontoJaExiste(dataRegistro, tipoTrabalho, idFuncionario);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar se o registro de ponto já existe: " + ex.Message);
                // Lida com exceções apropriadamente
                return false;
            }
        }
    }
}
