
using ProjetoHumanity.Models.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ProjetoHumanity.Models.dao
{
    internal class DaoCalculoFolha
    {
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoLogin con = new ConexaoLogin();
        public bool Tem = false;


        // Método para inserir registros na tabela CALCULO_SALARIO e atualizar informações relacionadas
        public string InserirRegistros(int idFolhaPgto, int idUsuario)
        {
            try
            {
                // Comando SQL para inserir registros na tabela CALCULO_SALARIO
                cmd.CommandText = "INSERT INTO CALCULO_SALARIO (ID_FOLHAPGTO, ID_FUNCIONARIO, ID_USUARIO) " +
                                  "SELECT EF.ID_FOLHAPGTO, F.ID_FUNCIONARIO, @ID_USUARIO FROM FUNCIONARIO F " +
                                  "JOIN EMPRESA_FOLHA EF ON F.ID_EMPRESA = EF.ID_EMPRESA " +
                                  "WHERE EF.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                // Estabelece a conexão
                cmd.Connection = con.conectar();

                // Adiciona parâmetros
                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);
                cmd.Parameters.AddWithValue("@ID_USUARIO", idUsuario);

                // Executa o comando SQL para inserir os registros
                cmd.ExecuteNonQuery();

                // Chamadas de métodos para atualizar diversas informações relacionadas ao cálculo de salário
                string resultadoAtualizacao = AtualizarSalarioBase(idFolhaPgto);
                string resultadoHorasTrabalhadas = AtualizarTotalHorasTrabalhadas(idFolhaPgto);
                string resultadoValorHora = AtualizarValorHoraTrabalhada(idFolhaPgto);
                string resultadoHextra50 = AtualizarHorasExtras50(idFolhaPgto);
                string resultadoHextra100 = AtualizarHorasExtras100(idFolhaPgto);
                string atualizaHextra50 = AtualizarValorHorasExtras50(idFolhaPgto);
                string atualizaHextra100 = AtualizarValorHorasExtras100(idFolhaPgto);
                string atualizaFaltas = AtualizarFaltas(idFolhaPgto);
                string atualizarBeneficio = AtualizarBeneficio(idFolhaPgto);
                string atualizaSalarioBruto = AtualizarSalarioBruto(idFolhaPgto);
                string atualizaDescontoFaltas = DescontoPorFaltas(idFolhaPgto);
                string atualizaDescontoBeneficio = AtualizarDescontoBeneficio(idFolhaPgto);
                string atualizaDescontosInss = AtualizarINSS(idFolhaPgto);
                string atualizaFaixaInss = AtualizarFaixaINSS(idFolhaPgto);
                string atualizaDescontoFgts = AtualizarDescontoFGTS(idFolhaPgto);
                string atualizaFaixaFgts = AtualizarFaixaFGTS(idFolhaPgto);
                string atualizaDescontoIrrf = AtualizarDescontoIRRF(idFolhaPgto);
                string atualizaFaixaIrrf = AtualizarFaixaIRRF(idFolhaPgto);
                string atualizaDescontosTotais = AtualizarTotalDescontos(idFolhaPgto);
                string atualizaSalarioLiquido = AtualizarSalarioLiquido(idFolhaPgto);
                int AtualizarDadosTabelaEmpresaFolha = AtualizarEmpresaFolha(idFolhaPgto);

                // Monta a mensagem de sucesso, incluindo o resultado das atualizações
                mensagem = "ID e funcionários registrados. " + resultadoAtualizacao;
                Tem = true;
            }
            catch (Exception ex)
            {
                // Em caso de erro, define a mensagem de erro
                mensagem = "Erro ao registrar ID e funcionários: " + ex.Message;
            }
            finally
            {
                // Certifica-se de fechar a conexão após o uso
                con.desconectar();
            }

            return mensagem;
        }



        public string AtualizarSalarioBase(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS SET CS.SALARIO_BASE = F.SALARIO_BASE " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN FUNCIONARIO F ON CS.ID_FUNCIONARIO = F.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";
                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Salários Atualizados corretamente";
                Tem = true;

            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar salário base: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarTotalHorasTrabalhadas(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.TOTAL_HRSTRAB = RP.TotalHorasRealizadas " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN ( " +
                                  "      SELECT ID_FUNCIONARIO, SUM(H_REALIZADAS) AS TotalHorasRealizadas " +
                                  "      FROM REGISTRO_PONTO " +
                                  "      WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO " +
                                  "      GROUP BY ID_FUNCIONARIO " +
                                  "     ) RP ON CS.ID_FUNCIONARIO = RP.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";
                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Total de horas trabalhadas atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar total de horas trabalhadas: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarValorHoraTrabalhada(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET VALOR_HRSTRAB = ROUND(CS.SALARIO_BASE / (22 * 8), 2) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN FUNCIONARIO F ON CS.ID_FUNCIONARIO = F.ID_FUNCIONARIO " +
                                  "JOIN EMPRESA_FOLHA EF ON F.ID_EMPRESA = EF.ID_EMPRESA " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Valor da hora trabalhada atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar valor da hora trabalhada: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarHorasExtras50(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.H_EXTRAS50 = RP.TotalHorasExtras50 " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN (" +
                                  "    SELECT ID_FUNCIONARIO, SUM(H_REALIZADAS) AS TotalHorasExtras50 " +
                                  "    FROM REGISTRO_PONTO " +
                                  "    WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO AND TIPO_TRABALHO = 'Extra50' " +
                                  "    GROUP BY ID_FUNCIONARIO" +
                                  ") RP ON CS.ID_FUNCIONARIO = RP.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Horas extras 50 atualizadas com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar horas extras 50: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarHorasExtras100(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.H_EXTRAS100 = RP.TotalHorasExtras100 " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN (" +
                                  "    SELECT ID_FUNCIONARIO, SUM(H_REALIZADAS) AS TotalHorasExtras100 " +
                                  "    FROM REGISTRO_PONTO " +
                                  "    WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO AND TIPO_TRABALHO = 'Extra100' " +
                                  "    GROUP BY ID_FUNCIONARIO" +
                                  ") RP ON CS.ID_FUNCIONARIO = RP.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Horas extras 100 atualizadas com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar horas extras 100: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarValorHorasExtras50(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.VALOR_HEXTRAS50 = ROUND(CAST(CS.H_EXTRAS50 * (CS.VALOR_HRSTRAB * 1.5) AS DECIMAL(10, 2)), 2) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Valor das horas extras 50 atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar valor das horas extras 50: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarValorHorasExtras100(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.VALOR_HEXTRAS100 = ROUND(CAST(CS.H_EXTRAS100 * (CS.VALOR_HRSTRAB * 2) AS DECIMAL(10, 2)), 2) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "Valor das horas extras 100 atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar valor das horas extras 100: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarFaltas(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.QTD_FALTAS = ISNULL(RP.TotalFaltas, 0) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "LEFT JOIN (" +
                                  "    SELECT ID_FUNCIONARIO, COUNT(*) AS TotalFaltas " +
                                  "    FROM REGISTRO_PONTO " +
                                  "    WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO AND FALTAS = 1 AND TIPO_FALTA = 'INJUSTIFICADA' " +
                                  "    GROUP BY ID_FUNCIONARIO" +
                                  ") RP ON CS.ID_FUNCIONARIO = RP.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "Faltas atualizadas com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar faltas: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarBeneficio(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.BENEFICIO = " +
                                  "    CASE " +
                                  "        WHEN F.VL_ALIMENTACAO = 1 AND F.VL_TRANSPORTE = 2 THEN '1' " +
                                  "        ELSE '2' " +
                                  "    END " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "JOIN FUNCIONARIO F ON CS.ID_FUNCIONARIO = F.ID_FUNCIONARIO " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "Benefício atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar benefício: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarSalarioBruto(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.SAL_BRUTO = ISNULL((CS.TOTAL_HRSTRAB * ISNULL(CS.VALOR_HRSTRAB, 0)) + ISNULL(CS.VALOR_HEXTRAS50, 0) + ISNULL(CS.VALOR_HEXTRAS100, 0), 0) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "Salário base atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar salário base: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string DescontoPorFaltas(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET CS.DSCT_FALTAS = ROUND((CS.QTD_FALTAS * 8 * CS.VALOR_HRSTRAB), 2) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "Desconto por faltas atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar desconto por faltas: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarDescontoBeneficio(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                                  "SET DSCT_BENEF = ROUND((CS.SALARIO_BASE * 0.06), 2) " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                mensagem = "Desconto de Benefício atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar Desconto de Benefício: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarINSS(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                              "SET DSCT_INSS = " +
                              "CASE " +
                              "    WHEN CS.SAL_BRUTO <= 1100.00 THEN CS.SAL_BRUTO * 0.075 " +
                              "    WHEN CS.SAL_BRUTO <= 2203.48 THEN CS.SAL_BRUTO * 0.09 " +
                              "    WHEN CS.SAL_BRUTO <= 3305.22 THEN CS.SAL_BRUTO * 0.12 " +
                              "    WHEN CS.SAL_BRUTO <= 6433.57 THEN CS.SAL_BRUTO * 0.14 " +
                              "    ELSE 6433.57 * 0.14 " +
                              "END " +
                              "FROM CALCULO_SALARIO CS " +
                              "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                mensagem = "INSS atualizado com sucesso!";
                Tem = true;
            }
            catch (Exception ex)
            {
                mensagem = "Erro ao atualizar INSS: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
            return mensagem;
        }

        public string AtualizarFaixaINSS(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CS " +
                              "SET FAIXA_INSS = " +
                              "CASE " +
                              "    WHEN CS.SAL_BRUTO <= 1100.00 THEN '7.5%' " +
                              "    WHEN CS.SAL_BRUTO <= 2203.48 THEN '9%' " +
                              "    WHEN CS.SAL_BRUTO <= 3305.22 THEN '12%' " +
                              "    WHEN CS.SAL_BRUTO <= 6433.57 THEN '14%' " +
                              "    ELSE '14%' " +
                              "END " +
                              "FROM CALCULO_SALARIO CS " +
                              "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Faixa de INSS atualizada com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar faixa de INSS: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarDescontoFGTS(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CALCULO_SALARIO " +
                                  "SET DSCT_FGTS = " +
                                  "CASE " +
                                  "    WHEN SAL_BRUTO <= 1100.00 THEN SAL_BRUTO * 0.08 " +
                                  "    WHEN SAL_BRUTO <= 2203.48 THEN SAL_BRUTO * 0.09 " +
                                  "    WHEN SAL_BRUTO <= 3305.22 THEN SAL_BRUTO * 0.12 " +
                                  "    WHEN SAL_BRUTO <= 6433.57 THEN SAL_BRUTO * 0.11 " +
                                  "    ELSE SAL_BRUTO * 0.11 " +
                                  "END " +
                                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Desconto de FGTS atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar desconto de FGTS: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarFaixaFGTS(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CALCULO_SALARIO " +
                  "SET FAIXA_FGTS = '8%' " +
                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Faixa de FGTS atualizada com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar faixa de FGTS: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarDescontoIRRF(int idFolhaPgto)
        {
            try
            {

                cmd.CommandText = "UPDATE CS " +
                                  "SET DSCT_IRRF = " +
                                  "CASE " +
                                  "    WHEN CS.SAL_BRUTO <= 1903.98 THEN 0 " +
                                  "    WHEN CS.SAL_BRUTO <= 2826.65 THEN (CS.SAL_BRUTO * 0.075) - 142.80 " +
                                  "    WHEN CS.SAL_BRUTO <= 3751.05 THEN (CS.SAL_BRUTO * 0.15) - 354.80 " +
                                  "    WHEN CS.SAL_BRUTO <= 4664.68 THEN (CS.SAL_BRUTO * 0.225) - 636.13 " +
                                  "    ELSE (CS.SAL_BRUTO * 0.275) - 869.36 " +
                                  "END " +
                                  "FROM CALCULO_SALARIO CS " +
                                  "WHERE CS.ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


                return "Desconto de IRRF atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar desconto de IRRF: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarFaixaIRRF(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CALCULO_SALARIO " +
                                  "SET FAIXA_IRRF = " +
                                  "CASE " +
                                  "    WHEN SAL_BRUTO <= 1903.98 THEN 'Isento' " +
                                  "    WHEN SAL_BRUTO <= 2826.65 THEN '7.5%' " +
                                  "    WHEN SAL_BRUTO <= 3751.05 THEN '15%' " +
                                  "    WHEN SAL_BRUTO <= 4664.68 THEN '22.5%' " +
                                  "    ELSE '27.5%' " +
                                  "END " +
                                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Faixa de IRRF atualizada com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar faixa de IRRF: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarTotalDescontos(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CALCULO_SALARIO " +
                                  "SET TOTAL_DESCONTOS = ISNULL(DSCT_FALTAS, 0) + ISNULL(DSCT_BENEF, 0) + ISNULL(DSCT_INSS, 0) +  ISNULL(DSCT_IRRF, 0) " +
                                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Total de descontos atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar total de descontos: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }
        }

        public string AtualizarSalarioLiquido(int idFolhaPgto)
        {
            try
            {
                cmd.CommandText = "UPDATE CALCULO_SALARIO " +
                                  "SET SALARIO_LIQUIDO = SAL_BRUTO - TOTAL_DESCONTOS " +
                                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpe os parâmetros anteriores

                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                return "Salário líquido atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                return "Erro ao atualizar salário líquido: " + ex.Message;
            }
            finally
            {
                con.desconectar();
            }


        }

        // Método separado para atualizar a tabela EMPRESA_FOLHA
        private int AtualizarEmpresaFolha(int idFolhaPgto)
        {
            int rowsAffected = 0;

            try
            {
                cmd.CommandText = "UPDATE EMPRESA_FOLHA " +
                                  "SET VALOR_TOTAL_fOLHA = (SELECT SUM(SALARIO_LIQUIDO) FROM CALCULO_SALARIO WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO), " +
                                  "    TOTAL_FUNCIONARIOS = (SELECT COUNT(DISTINCT ID_FUNCIONARIO) FROM CALCULO_SALARIO WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO) " +
                                  "WHERE ID_FOLHAPGTO = @ID_FOLHAPGTO;";

                cmd.Parameters.Clear(); // Limpa os parâmetros antes de adicioná-los novamente
                cmd.Parameters.AddWithValue("@ID_FOLHAPGTO", idFolhaPgto);

                // Executa o comando SQL para atualizar os registros na tabela EMPRESA_FOLHA
                rowsAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Lida com a exceção, se necessário
                Console.WriteLine("Erro ao atualizar EMPRESA_FOLHA: " + ex.Message);
            }

            return rowsAffected;
        }


    }



}

