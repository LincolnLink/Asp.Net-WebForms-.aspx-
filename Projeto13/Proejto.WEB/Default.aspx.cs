using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto.Entidades;
using Projeto.BLL;




namespace Proejto.WEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
            
            try
            {
                //resgatar os dados do usuario
                Usuario u = new Usuario();
                u.Nome = txtNome.Text;
                u.Login = txtLoginAcesso.Text;
                u.Senha = txtSenhaAcesso.Text;
                u.Foto = u.Login + "/" + txtFoto.FileName;

                UsuarioBusiness rep = new UsuarioBusiness();
                rep.Cadastrar(u);
                

                //UPLOAD da imagem.
                string path = HttpContext.Current.Server.MapPath("/Imagens/");

                Directory.CreateDirectory(path + u.Login);
                //criando/Imagens/meuusuario
                txtFoto.SaveAs(path + u.Foto);
                //upload -> /Imagens/meuusuario/minhafoto.jpg

                //mensagem de sucesso..
                lblMessagem.Text = "Seja bem vindo " + u.Nome + ", sua conta foi " +
                    " criada com sucesso. ";

                //limpar os campos...
                txtNome.Text = string.Empty;
                txtLoginAcesso.Text = string.Empty;

            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro..
                lblMessagem.Text = ex.Message;
            }
        }
    }
}