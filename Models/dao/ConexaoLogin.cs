using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.dao
{
    internal class ConexaoLogin
    {
        // Instância de SqlConnection que representa a conexão com o banco de dados;
        SqlConnection con = new SqlConnection();

        // Construtor da classe, é chamado quando uma instância da classe é criada;
        public ConexaoLogin()
        {
            // Configuração da string de conexão
            con.ConnectionString = "Server=DESKTOP-VCRGFKI\\SQLEXPRESS;Database=GROUP_HUMANITY;Integrated Security=True;TrustServerCertificate=true;MultipleActiveResultSets=True;";

        }

        // Método para abrir a conexão com o banco de dados
        public SqlConnection conectar()
        {
            // Verifica se a conexão está fechada antes de abrir
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open(); // Abre a conexão
            }
            return con; // Retorna a instância da conexão aberta
        }

        // Método para fechar a conexão com o banco de dados
        public void desconectar()
        {
            // Verifica se a conexão está aberta antes de fechar
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close(); // Fecha a conexão
            }
        }

    }
}
