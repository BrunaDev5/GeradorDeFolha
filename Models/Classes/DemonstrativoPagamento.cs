using ProjetoHumanity.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    public class DemonstrativoPagamento
    {
       // Dados do Funcionário
        public string COD_FUNC { get; set; }
        public string NOME_FUNC { get; set; }
        public DateTime DT_ADMISSAO { get; set; }
        public string TURNO_FUNC { get; set; }
        public string FUNCAO_FUNC { get; set; }
        public decimal SALARIO_BASE { get; set; }

        // Dados da Folha de Pagamento
        public DateTime DATA_INIC { get; set; }
        public DateTime DATA_FIM { get; set; }
        public DateTime DATA_CREDITO { get; set; }

        // Dados do Cálculo de Salário
        public decimal TOTAL_HRSTRAB { get; set; }
        public decimal VALOR_HRSTRAB { get; set; }
        public decimal H_EXTRAS50 { get; set; }
        public decimal VALOR_HEXTRAS50 { get; set; }
        public decimal H_EXTRAS100 { get; set; }
        public decimal VALOR_HEXTRAS100 { get; set; }
        public decimal BENEFICIO { get; set; }
        public decimal SAL_BRUTO { get; set; }
        public int QTD_FALTAS { get; set; }
        public decimal DSCT_FALTAS { get; set; }
        public decimal DSCT_BENEF { get; set; }
        public decimal DSCT_INSS { get; set; }
        public string FAIXA_INSS { get; set; }
        public decimal DSCT_FGTS { get; set; }
        public string FAIXA_FGTS { get; set; }
        public decimal DSCT_IRRF { get; set; }
        public string FAIXA_IRRF { get; set; }
        public decimal TOTAL_DESCONTOS { get; set; }
        public decimal SALARIO_LIQUIDO { get; set; }

        // Construtor padrão
        public DemonstrativoPagamento()
        {
        }

        // Construtor com dados essenciais do Funcionário
        public DemonstrativoPagamento(string codFunc, string nomeFunc, DateTime dtAdmissao, string turnoFunc, string funcaoFunc, decimal salarioBaseFunc)
        {
            COD_FUNC = codFunc;
            NOME_FUNC = nomeFunc;
            DT_ADMISSAO = dtAdmissao;
            TURNO_FUNC = turnoFunc;
            FUNCAO_FUNC = funcaoFunc;
            SALARIO_BASE = salarioBaseFunc;
        }

        // Construtor com todos os dados
        public DemonstrativoPagamento(
            // Dados do Funcionário
            string codFunc, string nomeFunc, DateTime dtAdmissao, string turnoFunc, string funcaoFunc, decimal salarioBaseFunc,
            // Dados da Folha de Pagamento
            DateTime dataInicio, DateTime dataFim, DateTime dataCredito,
            // Dados do Cálculo de Salário
            decimal totalHorasTrabalhadas, decimal valorHoraTrabalhada,
            decimal horasExtras50, decimal valorHorasExtras50, decimal horasExtras100, decimal valorHorasExtras100,
            decimal beneficio, decimal salarioBruto, int qtdFaltas, decimal descontoFaltas,
            decimal descontoBeneficio, decimal descontoINSS, string faixaINSS,
            decimal descontoFGTS, string faixaFGTS, decimal descontoIRRF, string faixaIRRF,
            decimal totalDescontos, decimal salarioLiquido)
            : this(codFunc, nomeFunc, dtAdmissao, turnoFunc, funcaoFunc, salarioBaseFunc)
        {
            // Atribuir os valores correspondentes
            DATA_INIC = dataInicio;
            DATA_FIM = dataFim;
            DATA_CREDITO = dataCredito;
            TOTAL_HRSTRAB = totalHorasTrabalhadas;
            VALOR_HRSTRAB = valorHoraTrabalhada;
            H_EXTRAS50 = horasExtras50;
            VALOR_HEXTRAS50 = valorHorasExtras50;
            H_EXTRAS100 = horasExtras100;
            VALOR_HEXTRAS100 = valorHorasExtras100;
            BENEFICIO = beneficio;
            SAL_BRUTO = salarioBruto;
            QTD_FALTAS = qtdFaltas;
            DSCT_FALTAS = descontoFaltas;
            DSCT_BENEF = descontoBeneficio;
            DSCT_INSS = descontoINSS;
            FAIXA_INSS = faixaINSS;
            DSCT_FGTS = descontoFGTS;
            FAIXA_FGTS = faixaFGTS;
            DSCT_IRRF = descontoIRRF;
            FAIXA_IRRF = faixaIRRF;
            TOTAL_DESCONTOS = totalDescontos;
            SALARIO_LIQUIDO = salarioLiquido;
        }

       

    }
}