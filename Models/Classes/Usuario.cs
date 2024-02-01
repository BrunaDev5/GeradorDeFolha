using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHumanity.Models.Classes
{
    internal class Usuario
    {
        public int ID_USUARIO { get; set; }
        public string NOME_USER { get; set; } = string.Empty;
        public string EMAIL_USER { get; set; } = string.Empty;
        public string LOGIN_USER { get; set; } = string.Empty;
        public string NIVEL_PERM { get; set; } = string.Empty;
        public string STATUS_USER { get; set; } = string.Empty;
        public byte[] SENHA_USER { get; set; } = Array.Empty<byte>();
        public byte[] SALT { get; set; } = Array.Empty<byte>(); // Nova propriedade para armazenar o SALT

        public Usuario()
        {
        }

        // Construtor personalizado para criar um usuário com os dados fornecidos
        public Usuario(int Id_Usuario, string NomeUser, string EmailUser, string LoginUser, string NivelUser, string StatusUser, byte[] SenhaUser, byte[] Salt)
        {
            ID_USUARIO = Id_Usuario;
            NOME_USER = NomeUser;
            EMAIL_USER = EmailUser;
            LOGIN_USER = LoginUser;
            NIVEL_PERM = NivelUser;
            STATUS_USER = StatusUser;
            SENHA_USER = SenhaUser;
            SALT = Salt;

        }

        public Usuario(int Id_Usuario, string NomeUser, string EmailUser, string LoginUser, string NivelUser, string StatusUser)
        {
            ID_USUARIO = Id_Usuario;
            NOME_USER = NomeUser;
            EMAIL_USER = EmailUser;
            LOGIN_USER = LoginUser;
            NIVEL_PERM = NivelUser;
            STATUS_USER = StatusUser;

        }

        public Usuario(int Id_Usuario, string NomeUser, string EmailUser, string LoginUser, string NivelUser, string StatusUser, byte[] SenhaUser)
        {
            ID_USUARIO = Id_Usuario;
            NOME_USER = NomeUser;
            EMAIL_USER = EmailUser;
            LOGIN_USER = LoginUser;
            NIVEL_PERM = NivelUser;
            STATUS_USER = StatusUser;
            SENHA_USER = SenhaUser;

        }



    }
}
