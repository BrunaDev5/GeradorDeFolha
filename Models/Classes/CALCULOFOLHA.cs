using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    internal class CALCULOFOLHA
    {
        public int ID_CALCULO { get; set; }
        public int ID_FOLHAPGTO { get; set; }
        public int ID_FUNCIONARIO { get; set; }
        public decimal SALARIO_BASE { get; set; }
        public decimal TOTAL_HRSTRAB { get; set; }
        public decimal VALOR_HRSTRAB { get; set; }
        public decimal H_EXTRAS50 { get; set; }
        public decimal VALOR_HEXTRAS50 { get; set; }
        public decimal H_EXTRAS100 { get; set; }
        public decimal VALOR_HEXTRAS100 { get; set; }
        public decimal BENEFICIO { get; set; }
        public decimal SAL_BRUTO { get; set; }
        public int QTD_FALTAS { get; set; }
        public decimal DSCT_FALTAS { get; set;}
        public decimal DSCT_BENEF { get; set; }
        public decimal DSCT_INSS { get; set; }
        public string FAIXA_INSS { get; set; }
        public decimal DSCT_FGTS { get; set; }
        public string FAIXA_FGTS { get; set; }
        public decimal DSCT_IRRF { get; set; }
        public string FAIXA_IRRF { get; set; }
        public decimal TOTAL_DESCONTOS { get; set; }
        public decimal SALARIO_LIQUIDO { get; set; }
        public int ID_USUARIO { get; set; }

        public CALCULOFOLHA()
        {
        }

        public CALCULOFOLHA(int idCalculo, int idFolhaPgto, int idFuncionario, decimal salarioBase, decimal totalHorasTrab,
                      decimal valorHorasTrab, decimal horasExtras50, decimal valorHorasExtras50, decimal horasExtras100,
                      decimal valorHorasExtras100, decimal beneficio, decimal salarioBruto, int qtdFaltas,
                      decimal dsctFaltas, decimal dsctBeneficio, decimal dsctInss, string faixaInss, decimal dsctFgts,
                      string faixaFgts, decimal dsctIrrf, string faixaIrrf, decimal totalDescontos,
                      decimal salarioLiquido, int idUsuario)
        {
            // Atribui os valores passados às propriedades existentes
            ID_CALCULO = idCalculo;
            ID_FOLHAPGTO = idFolhaPgto;
            ID_FUNCIONARIO = idFuncionario;
            SALARIO_BASE = salarioBase;
            TOTAL_HRSTRAB = totalHorasTrab;
            VALOR_HRSTRAB = valorHorasTrab;
            H_EXTRAS50 = horasExtras50;
            VALOR_HEXTRAS50 = valorHorasExtras50;
            H_EXTRAS100 = horasExtras100;
            VALOR_HEXTRAS100 = valorHorasExtras100;
            BENEFICIO = beneficio;
            SAL_BRUTO = salarioBruto;
            QTD_FALTAS = qtdFaltas;
            DSCT_FALTAS = dsctFaltas;
            DSCT_BENEF = dsctBeneficio;
            DSCT_INSS = dsctInss;
            FAIXA_INSS = faixaInss;
            DSCT_FGTS = dsctFgts;
            FAIXA_FGTS = faixaFgts;
            DSCT_IRRF = dsctIrrf;
            FAIXA_IRRF = faixaIrrf;
            TOTAL_DESCONTOS = totalDescontos;
            SALARIO_LIQUIDO = salarioLiquido;
            ID_USUARIO = idUsuario;
        }
    }

}

