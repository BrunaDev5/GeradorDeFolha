using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    internal class RegistroPonto
    {
    
            public int ID_REGISTRO { get; set; }
            public int ID_FUNCIONARIO { get; set; }
            public int ID_FOLHAPGTO { get; set; }
            public DateTime DATA_REGISTRO { get; set; }
            public TimeSpan H_ENTRADA { get; set; }
            public TimeSpan INICIO_ALMOCO { get; set; }
            public TimeSpan FIM_ALMOCO { get; set; }
            public TimeSpan H_SAIDA { get; set; }
            public decimal H_REALIZADAS { get; set; }
            public TimeSpan QTDE_ATRASOS { get; set; }
            public string TIPO_TRABALHO { get; set; }
            public int FALTAS { get; set; }
            public string TIPO_FALTA { get; set; }
            public int ID_USUARIO { get; set; }
       

        // Construtor vazio
        public RegistroPonto()
        {
        }

            // Construtor com todos os dados
        public RegistroPonto(int idRegistro, int idFuncionario, int idFolhaPagamento, DateTime dataRegistro,
                                 TimeSpan hEntrada, TimeSpan inicioAlmoco, TimeSpan fimAlmoco, TimeSpan hSaida,
                                 decimal hRealizadas, TimeSpan qtdeAtrasos,string tipoTrabalho, int faltas, string tipoFalta,
                                 int idUsuario)
        {
                ID_REGISTRO = idRegistro;
                ID_FUNCIONARIO = idFuncionario;
                ID_FOLHAPGTO = idFolhaPagamento;
                DATA_REGISTRO = dataRegistro;
                H_ENTRADA = hEntrada;
                INICIO_ALMOCO = inicioAlmoco;
                FIM_ALMOCO = fimAlmoco;
                H_SAIDA = hSaida;
                H_REALIZADAS = hRealizadas;
                QTDE_ATRASOS = qtdeAtrasos;
                TIPO_TRABALHO = tipoTrabalho;
                FALTAS = faltas;
                TIPO_FALTA = tipoFalta;
                ID_USUARIO = idUsuario;
        }

        public RegistroPonto(int idFuncionario,DateTime dataRegistro,TimeSpan hEntrada, TimeSpan inicioAlmoco, TimeSpan fimAlmoco, TimeSpan hSaida,
                              string tipoTrabalho, string tipoFalta,int idUsuario)
        {
            
            ID_FUNCIONARIO = idFuncionario;
            DATA_REGISTRO = dataRegistro;
            H_ENTRADA = hEntrada;
            INICIO_ALMOCO = inicioAlmoco;
            FIM_ALMOCO = fimAlmoco;
            H_SAIDA = hSaida;
            TIPO_TRABALHO = tipoTrabalho;
            TIPO_FALTA = tipoFalta;
            ID_USUARIO = idUsuario;
        }

            


    }


}
