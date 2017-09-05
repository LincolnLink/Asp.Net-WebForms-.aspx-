using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Projeto.Util
{
    public class Criptografia
    {
        //método para receber uma senha e retornala
        //encriptada no padrão MD5
        public string EncriptarSenha(string senha)
        {
            //classe para criptografia em MD5..
            MD5 md5 = new MD5CryptoServiceProvider();

            //converter o valor a ser criptografado em bytes
            byte[] senhaBytes = Encoding.UTF8.GetBytes(senha);

            //Encriptar senha
            byte[] hash = md5.ComputeHash(senhaBytes); //Criptografando

            //Converter o hash em string..
            string resultado = string.Empty; //vazio

            //percorrer o vetor hash
            foreach (byte b in hash)
            {
                resultado += b.ToString("X"); //X-> Hexadecimal..
            }

            //retornando
            return resultado;
        }
    }
}
