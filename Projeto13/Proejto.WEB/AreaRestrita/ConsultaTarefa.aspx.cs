using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;

namespace Proejto.WEB.AreaRestrita
{
    public partial class ConsultaTarefa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                //recuperar o usuario de sessão
                Usuario u = new Usuario();
                u = (Usuario) Session["usuario"]; //casting

                //resgatar as datas informadas nos campos
                DateTime dataIni = DateTime.Parse(txtDataIni.Text);
                DateTime dataFim = DateTime.Parse(txtDataFim.Text);

                //executar a consulta..
                TarefaBusiness business = new TarefaBusiness();
                List<Tarefa> lista = new List<Tarefa>();
                lista = business.Consultar(dataIni, dataFim, u.IdUsuario);

                //popular o gridview
                gridTarefas.DataSource = lista; //popular o grif
                gridTarefas.DataBind(); //exibindo o conteudo

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}