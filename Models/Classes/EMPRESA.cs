using System;

namespace ProjetoHumanity.Models.Classes
{
    internal class EMPRESA
    {
        public int ID_EMPRESA { get; set; }
        public string STATUS_EMPRESA { get; set; }
        public string CODIGO_EMP { get; set; }
        public string RAZAO_SOCIAL { get; set; }
        public string CNPJ_EMPRESA { get; set; }
        public string INSC_ESTADUAL { get; set; }
        public string NOME_FANTASIA { get; set; }
        public string RUA_EMP { get; set; }
        public string NUM_EMP { get; set; }
        public string BAIRRO_EMP { get; set; }
        public string CIDADE_EMP { get; set; }
        public string UF_EMP { get; set; }
        public string COMPLE_EMP { get; set; }
        public string CONTATO_EMP { get; set; }
        public string EMAIL_EMP { get; set; }
        public string RESPONS_EMP { get; set; }
        public int QTDE_FUNCIONARIOS { get; set; }
        public int ID_USUARIO { get; set; }
        public DateTime DATA_CADASTRO { get; set; }

        // Construtor da Empresa
        public EMPRESA(

            int idEmpresa,
            string statusEmpresa,
            string codEmpresa,
            string razaoSocial,
            string cnpj,
            string inscEstadual,
            string nomeFantasia,
            string ruaEmpresa,
            string numeroEmpresa,
            string bairroEmpresa,
            string cidadeEmpresa,
            string ufEmpresa,
            string compleEmpresa,
            string contatoEmpresa,
            string emailEmpresa,
            string responsEmpresa,
            int qtdeFuncionarios,
            DateTime dataCadastro)
        {
            ID_EMPRESA = idEmpresa;
            STATUS_EMPRESA = statusEmpresa;
            CODIGO_EMP = codEmpresa;
            RAZAO_SOCIAL = razaoSocial;
            CNPJ_EMPRESA = cnpj;
            INSC_ESTADUAL = inscEstadual;
            NOME_FANTASIA = nomeFantasia;
            RUA_EMP = ruaEmpresa;
            NUM_EMP = numeroEmpresa;
            BAIRRO_EMP = bairroEmpresa;
            CIDADE_EMP = cidadeEmpresa;
            UF_EMP = ufEmpresa;
            COMPLE_EMP = compleEmpresa;
            CONTATO_EMP = contatoEmpresa;
            EMAIL_EMP = emailEmpresa;
            RESPONS_EMP = responsEmpresa;
            QTDE_FUNCIONARIOS = qtdeFuncionarios;
            DATA_CADASTRO = dataCadastro;
        }

        public EMPRESA(
            int idEmpresa,
            string statusEmpresa,
            string razaoSocial,
            string cnpj,
            DateTime dataCadastro)
        {
            ID_EMPRESA = idEmpresa;
            STATUS_EMPRESA = statusEmpresa;
            RAZAO_SOCIAL = razaoSocial;
            CNPJ_EMPRESA = cnpj;
            DATA_CADASTRO = dataCadastro;
        }

        public EMPRESA(
            int idEmpresa,
            string statusEmpresa,
            string razaoSocial,
            string cnpj,
            string inscEstadual,
            string nomeFantasia,
            string ruaEmpresa,
            string numeroEmpresa,
            string bairroEmpresa,
            string cidadeEmpresa,
            string ufEmpresa,
            string compleEmpresa,
            string contatoEmpresa,
            string emailEmpresa,
            string responsEmpresa)
        {
            ID_EMPRESA = idEmpresa;
            STATUS_EMPRESA = statusEmpresa;
            RAZAO_SOCIAL = razaoSocial;
            CNPJ_EMPRESA = cnpj;
            INSC_ESTADUAL = inscEstadual;
            NOME_FANTASIA = nomeFantasia;
            RUA_EMP = ruaEmpresa;
            NUM_EMP = numeroEmpresa;
            BAIRRO_EMP = bairroEmpresa;
            CIDADE_EMP = cidadeEmpresa;
            UF_EMP = ufEmpresa;
            COMPLE_EMP = compleEmpresa;
            CONTATO_EMP = contatoEmpresa;
            EMAIL_EMP = emailEmpresa;
            RESPONS_EMP = responsEmpresa;
        }

        public EMPRESA()
        {
            // Lógica do construtor sem parâmetros, se necessário
        }


    }


    
}
