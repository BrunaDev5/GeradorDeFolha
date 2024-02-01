using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    public class FUNCIONARIO
    {
        // Propriedades correspondentes às colunas na tabela FUNCIONARIO
        public int ID_FUNCIONARIO { get; set; }
        public int ID_EMPRESA { get; set; }
        public string COD_FUNC { get; set; }
        public string STATUS_FUNC { get; set; }
        public string NOME_FUNC { get; set; }
        public string GENERO { get; set; }
        public string EST_CIVIL { get; set; }
        public DateTime DT_NASC { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string PIS { get; set; }
        public DateTime DT_ADMISSAO { get; set; }
        public string TURNO_FUNC { get; set; }
        public string FUNCAO_FUNC { get; set; }
        public decimal SALARIO_BASE { get; set; }
        public string CEP_FUNC { get; set; }
        public string RUA_FUNC { get; set; }
        public string NUM_FUNC { get; set; }
        public string BAIRRO_FUNC { get; set; }
        public string CIDADE_FUNC { get; set; }
        public string COMPLEM_FUNC { get; set; }
        public string UF_FUNC { get; set; }
        public string TEL_FUNC { get; set; }
        public string EMAIL_FUNC { get; set; }
        public string AGENCIA_PGTO { get; set; }
        public string CONTA_PGTO { get; set; }
        public string TIPO_CONTA { get; set; }
        public string VL_ALIMENTACAO { get; set; }
        public string VL_TRANSPORTE { get; set; }
        public string LOGIN_DEMONSTRATIVO { get; set; }
        public string SENHA_DEMONSTRATIVO { get; set; }
        public int ID_USUARIO { get; set; }

        // Construtor vazio
        public FUNCIONARIO()
        {
        }

        public FUNCIONARIO(int idFuncionario, int idEmpresa, string codFunc, string statusFunc, string nomeFunc, string genero, string estCivil, DateTime dtNasc, string cpf, string rg, string pis, DateTime dtAdmissao, string turnoFunc, string funcaoFunc, decimal salarioBase, string cepFunc, string ruaFunc, string numFunc, string bairroFunc, string cidadeFunc, string complemFunc, string ufFunc, string telFunc, string emailFunc, string agenciaPgto, string contaPgto, string tipoConta, string vlAlimentacao, string vlTransporte, string loginDemonstrativo, string senhaDemonstrativo)
        {
            ID_FUNCIONARIO = idFuncionario;
            ID_EMPRESA = idEmpresa;
            COD_FUNC = codFunc;
            STATUS_FUNC = statusFunc;
            NOME_FUNC = nomeFunc;
            GENERO = genero;
            EST_CIVIL = estCivil;
            DT_NASC = dtNasc;
            CPF = cpf;
            RG = rg;
            PIS = pis;
            DT_ADMISSAO = dtAdmissao;
            TURNO_FUNC = turnoFunc;
            FUNCAO_FUNC = funcaoFunc;
            SALARIO_BASE = salarioBase;
            CEP_FUNC = cepFunc;
            RUA_FUNC = ruaFunc;
            NUM_FUNC = numFunc;
            BAIRRO_FUNC = bairroFunc;
            CIDADE_FUNC = cidadeFunc;
            COMPLEM_FUNC = complemFunc;
            UF_FUNC = ufFunc;
            TEL_FUNC = telFunc;
            EMAIL_FUNC = emailFunc;
            AGENCIA_PGTO = agenciaPgto;
            CONTA_PGTO = contaPgto;
            TIPO_CONTA = tipoConta;
            VL_ALIMENTACAO = vlAlimentacao;
            VL_TRANSPORTE = vlTransporte;
            LOGIN_DEMONSTRATIVO = loginDemonstrativo;
            SENHA_DEMONSTRATIVO = senhaDemonstrativo;

        }
        public FUNCIONARIO(
            int idFuncionario,
            int idEmpresa,
            string codFunc,
            string statusFunc, 
            string nomeFunc,
            string genero,
            string estCivil,
            DateTime dtNasc,
            string cpf,
            string rg, 
            string pis,
            DateTime dtAdmissao,
            string turnoFunc,
            string funcaoFunc,
            decimal salarioBase,
            string cepFunc,
            string ruaFunc,
            string numFunc,
            string bairroFunc,
            string cidadeFunc,
            string complemFunc,
            string ufFunc,
            string telFunc,
            string emailFunc,
            string agenciaPgto,
            string contaPgto,
            string tipoConta, 
            string vlAlimentacao,
            string vlTransporte,
            string loginDemonstrativo, 
            string senhaDemonstrativo,
            int idUsuario)
        {
            ID_FUNCIONARIO = idFuncionario;
            ID_EMPRESA = idEmpresa;
            COD_FUNC = codFunc;
            STATUS_FUNC = statusFunc;
            NOME_FUNC = nomeFunc;
            GENERO = genero;
            EST_CIVIL = estCivil;
            DT_NASC = dtNasc;
            CPF = cpf;
            RG = rg;
            PIS = pis;
            DT_ADMISSAO = dtAdmissao;
            TURNO_FUNC = turnoFunc;
            FUNCAO_FUNC = funcaoFunc;
            SALARIO_BASE = salarioBase;
            CEP_FUNC = cepFunc;
            RUA_FUNC = ruaFunc;
            NUM_FUNC = numFunc;
            BAIRRO_FUNC = bairroFunc;
            CIDADE_FUNC = cidadeFunc;
            COMPLEM_FUNC = complemFunc;
            UF_FUNC = ufFunc;
            TEL_FUNC = telFunc;
            EMAIL_FUNC = emailFunc;
            AGENCIA_PGTO = agenciaPgto;
            CONTA_PGTO = contaPgto;
            TIPO_CONTA = tipoConta;
            VL_ALIMENTACAO = vlAlimentacao;
            VL_TRANSPORTE = vlTransporte;
            LOGIN_DEMONSTRATIVO = loginDemonstrativo;
            SENHA_DEMONSTRATIVO = senhaDemonstrativo;
            ID_USUARIO = idUsuario;
        }

        // Construtor
        public FUNCIONARIO(int idFuncionario, string status, string nome, DateTime admissao, string funcao, decimal salario, string cpf, int idEmpresa)
        {
            ID_FUNCIONARIO = idFuncionario;
            STATUS_FUNC = status;
            NOME_FUNC = nome;
            DT_ADMISSAO = admissao;
            FUNCAO_FUNC = funcao;
            SALARIO_BASE = salario;
            CPF = cpf;
            ID_EMPRESA = idEmpresa;
        }

      
       


    }
}
