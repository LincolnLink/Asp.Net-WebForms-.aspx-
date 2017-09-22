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

        #region CadastrarUsuario
        public void Cadastrar(Usuario u)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();

            //verifica se o login do usuario existe no banco de dados
            if (!rep.HasUsuario(u.Login))
            {   //se não existir no banco de dados.
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
        #endregion



        #region AutenticarUsuario
        public Usuario Autenticar(string Login, string Senha)
        {
            UsuarioRepositorio rep = new UsuarioRepositorio();

            Criptografia c = new Criptografia();
            //Busca o usuario do banco de dados
            Usuario u = rep.Find(Login, c.EncriptarSenha(Senha));

            if (u != null)
            {
                return u;
            }
            else
            {
                throw new AcessoNegadoException();
            }
        }
        #endregion

    }
}
