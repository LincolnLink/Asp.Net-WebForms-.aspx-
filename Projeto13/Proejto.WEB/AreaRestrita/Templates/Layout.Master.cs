using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using System.Web.Security;

namespace Proejto.WEB.AreaRestrita.Templates
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        //Evento quando é carregado quando a pagina é carregada
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verificar se a pagina esta sendo carregada pela primeira vez!
            if ( ! IsPostBack )
            {
                //Trazendo o usuario da sessão..
                Usuario u = new Usuario();
                u = (Usuario) Session["usuario"]; //casting...
                
                //Exibir dados do Usuario.                
                lblNomeUsuario.Text = u.Nome;
                lblLoginUsuario.Text = u.Login;
                imgUsuario.ImageUrl = "/Imagens/" + u.Foto;
            }
        }

        //Evento executa quando o botão é clicado
        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            //Destruindo o ticket de acesso do usuario.
            FormsAuthentication.SignOut();

            //Remover o conteudo do usuario de sessão
            Session.Remove("usuario");
            Session.Abandon();

            //retorna a pagina de login
            Response.Redirect("\\Default.aspx");
        }
    }
}