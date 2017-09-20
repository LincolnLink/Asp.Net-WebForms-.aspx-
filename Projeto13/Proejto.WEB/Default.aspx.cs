using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Projeto.Entidades;
using Projeto.BLL;
using System.Drawing; //paleta de desenho


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
                if(ValidarUpload())
                { 
                    //resgatar os dados do usuario
                    Usuario u = new Usuario();

                    u.Nome = txtNome.Text;
                    u.Login = txtLoginAcesso.Text;
                    u.Senha = txtSenhaAcesso.Text;

                    string nomeArquivo = Guid.NewGuid().ToString()
                        + Path.GetExtension(txtFoto.FileName);

                    u.Foto = u.Login + "/" + nomeArquivo;

                    UsuarioBusiness rep = new UsuarioBusiness();
                    rep.Cadastrar(u);

                    //UPLOAD da imagem.
                    string path = HttpContext.Current.Server.MapPath("/Imagens/");

                    Directory.CreateDirectory(path + u.Login);
                    //criando/Imagens/meuusuario
                    txtFoto.SaveAs(path + u.Foto);
                    //upload -> /Imagens/meuusuario/minhafoto.jpg

                    //mensagem de sucesso..
                    lblMessagem.Text = "Seja bem vindo " + u.Nome + " , sua conta foi " +
                        " criada com sucesso. ";
                    lblMessagem.ForeColor = Color.Black;

                    //limpar os campos...
                    txtNome.Text = string.Empty;
                    txtLoginAcesso.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                //imprimir mensagem de erro..
                lblMessagem.Text = ex.Message;
                lblMessagem.ForeColor = Color.Red;
            }
        }

        private bool ValidarUpload()
        {
            bool resultado = true;

            //obter a extensão do arquivo
            string extensao = Path.GetExtension(txtFoto.FileName);
            int tamanho = txtFoto.PostedFile.ContentLength; //em bytes..

            if (!extensao.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                && !extensao.Equals(".png", StringComparison.OrdinalIgnoreCase)
                && !extensao.Equals(".gif", StringComparison.OrdinalIgnoreCase))
            {
                lblMessagem.Text = "Por favor, envie apenas imagens" +
                    "jpg, png ou gif";
                lblMessagem.ForeColor = Color.Red;
                resultado = false; //erro
            }
            else if(tamanho > Math.Pow(1024, 2)) //até 1MB
            {
                lblMessagem.Text = "Por favor, envie imagens de até 1MB" +
                    "de tamanho";
                lblMessagem.ForeColor = Color.Red;

                resultado = false; //erro

            }
            //retornando..
            return resultado;

        }

        protected void BtnAcesso_Click(object sender, EventArgs e)
        {

        }
    }
}