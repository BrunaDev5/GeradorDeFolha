using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.dao
{
    internal class DaoFolhaEmpresas
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;


        public string InserirEmpresaFolha(int idEmpresa, int idFolhaPgto, decimal valorTotal, int totalFuncionarios)
        {
            try
            {

                // Defina o comando SQL para inserir um novo registro na tabela EMPRESA_FOLHA
                cmd.CommandText = "INSERT INTO EMPRESA_FOLHA (ID_EMPRESA, ID_FOLHAPGTO, VALOR_TOTAL_fOLHA, TOTAL_FUNCIONARIOS) " +
                                  "VALUES (@IdEmpresa, @IdFolhaPgto, @ValorTotal, @TotalFuncionarios)";

                // Estabelece a conexão
                cmd.Connection = con.conectar();

                cmd.Parameters.AddWithValue("@IdEmpresa", idEmpresa);
                cmd.Parameters.AddWithValue("@IdFolhaPgto", idFolhaPgto);
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal);
                cmd.Parameters.AddWithValue("@TotalFuncionarios", totalFuncionarios);

                cmd.ExecuteNonQuery();

                mensagem = "Empresas selecionadas com sucesso!";
                Tem = true;

            }
            catch (Exception ex)
            {
                mensagem = "Erro ao vincular empresas: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }


    }
}
