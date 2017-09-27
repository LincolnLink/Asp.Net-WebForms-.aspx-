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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se a página esta sendo carregada pela 1/vez
            if ( ! IsPostBack)
            {
                try
                {
                    //recuperar o usuario da sessão (autenticado..)
                    Usuario u = (Usuario) Session["usuario"];

                    //instanciar a camada de negócio..
                    TarefaBusiness business = new TarefaBusiness();

                    //recuperar a data de inicio e termino da semana
                    txtDataIni.Text = StartOfWeek(DateTime.Now)
                        .ToString("dd/MM/yyyy HH:mm");
                    txtDataFim.Text = EndOfWeek(DateTime.Now)
                        .ToString("dd/MM/yyyy HH:mm");

                    //executar a consulta..
                    List<Tarefa> lista = business.Consultar(StartOfWeek
                        (DateTime.Now), EndOfWeek(DateTime.Now),
                        u.IdUsuario);

                    //carregar os dados no listview
                    listTarefas.DataSource = lista;
                    listTarefas.DataBind();
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        private DateTime StartOfWeek(DateTime dt)
        {
            int diff = dt.DayOfWeek - DayOfWeek.Sunday;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        private DateTime EndOfWeek(DateTime dt)
        {
            return StartOfWeek(dt)
                .AddDays(6)
                .AddHours(23)
                .AddMinutes(59);
        }
    }
}