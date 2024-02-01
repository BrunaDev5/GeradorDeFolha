// Importação de namespaces necessários para o código
using ProjetoHumanity.Models.Classes;
using ProjetoHumanity.Models.dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

// Namespace que contém a classe do controlador
namespace ProjetoHumanity.Controller
{
    // Classe responsável por controlar as operações relacionadas aos usuários
    internal class ControllerUsuario
    {
        // Propriedade privada que representa o objeto DaoUsuario
        private DaoUsuario daoUsuario;
        private int idUsuario; // Vamos assumir que você tenha esse valor já disponível no seu ControllerMenu

        // Construtor da classe, inicializa o objeto DaoUsuario
        public ControllerUsuario()
        {
            daoUsuario = new DaoUsuario(); // Assumindo que você tem um construtor padrão em DaoUsuario
        }
        
        // Método para buscar um usuário por ID
        public Usuario BuscarUsuarioPorID(int IDUser)
        {
            try
            {
                // Chama o método BuscarUsuarioPorID do objeto daoUsuario
                return daoUsuario.BuscarUsuarioPorID(IDUser);
            }
            catch (Exception ex)
            {
                // Lida com a exceção de alguma forma apropriada para o seu aplicativo
                Console.WriteLine("Erro ao buscar usuário por ID: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        // Método para listar todos os usuários
        public List<Usuario> ListarTodos()
        {
            // Chama o método Listar do objeto daoUsuario
            return daoUsuario.Listar();
        }

        // Método para alterar informações do usuário
        public Usuario Alterar(Usuario usuarioAlterado)
        {
            try
            {
                // Cria uma nova instância do DaoUsuario (isso pode ser otimizado, dependendo do seu caso)
                daoUsuario = new DaoUsuario();

                // Chama o método Alterar do objeto daoUsuario
                Usuario usuarioAtualizado = daoUsuario.Alterar(usuarioAlterado);

                // Retorna o usuário após a alteração.
                return usuarioAtualizado;
            }
            catch (Exception ex)
            {
                // Em caso de exceção, lida com ela de alguma forma apropriada para o seu aplicativo.
                Console.WriteLine("Erro ao alterar usuário: " + ex.Message);

                // Retorna null em caso de erro, mas é recomendável incluir lógica para lidar com a falha.
                return null;
            }
        }

        public int ObterNivelPermissaoUsuario(int idUsuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ObterNivelPermissaoUsuario(idUsuario);
        }



    }
}
