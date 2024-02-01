using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;

namespace ProjetoHumanity.Models.Classes
{
    public class PasswordHasher
    {
        public static (byte[] hash, byte[] salt) HashPassword(string password)
        {
            // Gera um salt aleatório
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            // Combina a senha com o salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);

            // Gera a senha criptografada (hash)
            byte[] hash = pbkdf2.GetBytes(20);

            return (hash, salt);
        }

        public static bool VerifyPassword(string enteredPassword, byte[] storedHash, byte[] storedSalt)
        {
            // Combina a senha fornecida com o salt armazenado
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, storedSalt, 10000);

            // Gera o hash
            byte[] enteredHash = pbkdf2.GetBytes(20);

            // Compara os hashes
            return enteredHash.SequenceEqual(storedHash);
        }


    }


}

