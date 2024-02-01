using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    internal class FolhaEmpresas
    {
        public int ID_EMPRESA_FOLHA { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_FOLHAPGTO { get; set; }
        public decimal VALOR_TOTAL_FOLHA { get; set; }
        public int TOTAL_FUNCIONARIOS { get; set; }

        public FolhaEmpresas()
        {
            // Construtor vazio
        }

        public FolhaEmpresas(int idEmpresaFolha, int idEmpresa, int idFolhaPgto, decimal valorTotalFolha, int totalFuncionarios)
        {
            ID_EMPRESA_FOLHA = idEmpresaFolha;
            ID_EMPRESA = idEmpresa;
            ID_FOLHAPGTO = idFolhaPgto;
            VALOR_TOTAL_FOLHA = valorTotalFolha;
            TOTAL_FUNCIONARIOS = totalFuncionarios;
        }




    }
}
