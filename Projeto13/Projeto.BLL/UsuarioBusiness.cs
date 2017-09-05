using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Exceptions.Usuario;
using Projeto.Util;



namespace Projeto.BLL
{
    public class UsuarioBusiness
    {

        public void Cadastrar(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();
            
            //verifica se o login do usuario existe no banco de dados
            if ( ! rep.HasUsuario(u.Login))
            {   //se não existir
                //encriptar a senha do usuario..
                Criptografia c = new Criptografia();
                u.Senha = c.EncriptarSenha(u.Senha);

                rep.Insert(u); //Gravado
            }
            else
            {
                throw new LoginJaExisteException();
            }
        }

        public Usuario Autenticar(string Login, string Senha)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();

            Usuario u = rep.Find(Login, Senha);

            if ( u != null)
            {
                return u;
            }
            else
            {
                throw new LoginJaExisteException();
            }
        }
    }
}
