using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    public class FolhaPag
    {
        public int ID_FOLHAPGTO { get; set; }
        public string COD_FOLHA { get; set; }
        public DateTime DATA_INIC { get; set; }
        public DateTime DATA_FIM { get; set; }
        public DateTime DATA_CREDITO { get; set; }
        public int ID_USUARIO { get; set; }



        // Construtor padrão (sem parâmetros)
        public FolhaPag()
        {
            
        }

        // Construtor que aceita parâmetros para inicializar as propriedades
        public FolhaPag(int idFolhaPgto, string codFolha, DateTime dataInic, DateTime dataFim, DateTime dataCredito, int idUsuario)
        {
            ID_FOLHAPGTO = idFolhaPgto;
            COD_FOLHA = codFolha;
            DATA_INIC = dataInic;
            DATA_FIM = dataFim;
            
            DATA_CREDITO = dataCredito;
            ID_USUARIO = idUsuario;

        }

        public FolhaPag(int idFolhaPgto, string codFolha, DateTime dataInic, DateTime dataFim,DateTime dataCredito)
        {
            ID_FOLHAPGTO = idFolhaPgto;
            COD_FOLHA = codFolha;
            DATA_INIC = dataInic;
            DATA_FIM = dataFim;
            DATA_CREDITO = dataCredito;
          

        }








    }
}
