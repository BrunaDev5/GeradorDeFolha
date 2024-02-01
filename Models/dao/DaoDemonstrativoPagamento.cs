using ProjetoHumanity.Models.Classes;
using System;

using System.Data.SqlClient;


namespace ProjetoHumanity.Models.dao
{
    internal class DaoDemonstrativoPagamento
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;

        
        public DemonstrativoPagamento ObterDemonstrativoPagamento(int mes, int ano, int idFuncionario)
        {
            
            DemonstrativoPagamento demonstrativoPagamento = null;

            try
            {
                cmd.Connection = con.conectar();

                cmd.CommandText = "SELECT F.COD_FUNC, F.NOME_FUNC, F.DT_ADMISSAO, F.TURNO_FUNC, F.FUNCAO_FUNC, " +
                         "FP.DATA_INIC, FP.DATA_FIM, FP.DATA_CREDITO, " +
                         "C.SALARIO_BASE, C.TOTAL_HRSTRAB, C.VALOR_HRSTRAB, C.H_EXTRAS50, " +
                         "C.VALOR_HEXTRAS50, C.H_EXTRAS100, C.VALOR_HEXTRAS100, C.BENEFICIO, C.SAL_BRUTO, " +
                         "C.QTD_FALTAS, C.DSCT_FALTAS, C.DSCT_BENEF, C.DSCT_INSS, C.FAIXA_INSS, C.DSCT_FGTS, " +
                         "C.FAIXA_FGTS, C.DSCT_IRRF, C.FAIXA_IRRF, C.TOTAL_DESCONTOS, C.SALARIO_LIQUIDO " +
                         "FROM FUNCIONARIO F " +
                         "JOIN CALCULO_SALARIO C ON F.ID_FUNCIONARIO = C.ID_FUNCIONARIO " +
                         "JOIN FOLHA_PGTO FP ON C.ID_FOLHAPGTO = FP.ID_FOLHAPGTO " +
                         "WHERE F.ID_FUNCIONARIO = @IdFuncionario AND MONTH(FP.DATA_INIC) = @Mes AND YEAR(FP.DATA_INIC) = @Ano ORDER BY F.COD_FUNC, FP.DATA_INIC";

                cmd.Parameters.AddWithValue("@Mes", mes);
                cmd.Parameters.AddWithValue("@Ano", ano);
                cmd.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
               
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        demonstrativoPagamento = new DemonstrativoPagamento
                        {
                            COD_FUNC = reader.GetString(reader.GetOrdinal("COD_FUNC")),
                            NOME_FUNC = reader.GetString(reader.GetOrdinal("NOME_FUNC")),
                            DT_ADMISSAO = reader.GetDateTime(reader.GetOrdinal("DT_ADMISSAO")),
                            TURNO_FUNC = reader.GetString(reader.GetOrdinal("TURNO_FUNC")),
                            FUNCAO_FUNC = reader.GetString(reader.GetOrdinal("FUNCAO_FUNC")),
                            SALARIO_BASE = reader.GetDecimal(reader.GetOrdinal("SALARIO_BASE")),
                            DATA_INIC = reader.GetDateTime(reader.GetOrdinal("DATA_INIC")),
                            DATA_FIM = reader.GetDateTime(reader.GetOrdinal("DATA_FIM")),
                            DATA_CREDITO = reader.GetDateTime(reader.GetOrdinal("DATA_CREDITO")),
                            TOTAL_HRSTRAB = reader["TOTAL_HRSTRAB"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("TOTAL_HRSTRAB")) : 0m,
                            VALOR_HRSTRAB = reader["VALOR_HRSTRAB"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("VALOR_HRSTRAB")) : 0m,
                            H_EXTRAS50 = reader["H_EXTRAS50"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("H_EXTRAS50")) : 0m,
                            VALOR_HEXTRAS50 = reader["VALOR_HEXTRAS50"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("VALOR_HEXTRAS50")) : 0m,
                            H_EXTRAS100 = reader["H_EXTRAS100"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("H_EXTRAS100")) : 0m,
                            VALOR_HEXTRAS100 = reader["VALOR_HEXTRAS100"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("VALOR_HEXTRAS100")) : 0m,
                            BENEFICIO = reader["BENEFICIO"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("BENEFICIO")) : 0m,
                            SAL_BRUTO = reader["SAL_BRUTO"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("SAL_BRUTO")) : 0m,
                            QTD_FALTAS = reader["QTD_FALTAS"] != DBNull.Value ? reader.GetInt32(reader.GetOrdinal("QTD_FALTAS")) : 0,
                            DSCT_FALTAS = reader["DSCT_FALTAS"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("DSCT_FALTAS")) : 0m,
                            DSCT_BENEF = reader["DSCT_BENEF"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("DSCT_BENEF")) : 0m,
                            DSCT_INSS = reader["DSCT_INSS"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("DSCT_INSS")) : 0m,
                            FAIXA_INSS = reader["FAIXA_INSS"] as string ?? "",
                            DSCT_FGTS = reader["DSCT_FGTS"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("DSCT_FGTS")) : 0m,
                            FAIXA_FGTS = reader["FAIXA_FGTS"] as string ?? "",
                            DSCT_IRRF = reader["DSCT_IRRF"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("DSCT_IRRF")) : 0m,
                            FAIXA_IRRF = reader["FAIXA_IRRF"] as string ?? "",
                            TOTAL_DESCONTOS = reader.GetDecimal(reader.GetOrdinal("TOTAL_DESCONTOS")),
                            SALARIO_LIQUIDO = reader.GetDecimal(reader.GetOrdinal("SALARIO_LIQUIDO")),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter dados do Demonstrativo: " + ex.Message);
                throw;
            }
            finally
            {
                cmd.Parameters.Clear(); // Limpa os parâmetros antes de fechar a conexão
                con.desconectar();
            }

            return demonstrativoPagamento;
        }


    }
}
