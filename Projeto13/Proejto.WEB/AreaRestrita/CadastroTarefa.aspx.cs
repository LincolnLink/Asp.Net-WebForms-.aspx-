using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto.Entidades;
using Projeto.BLL;
using System.Drawing;

namespace Proejto.WEB.AreaRestrita
{
    public partial class CadastroTarefa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {

            try
            {
                Tarefa t = new Tarefa();
                t.NomeTarefa = txtNome.Text;
                t.DataHora = DateTime.Parse(txtDataHora.Text);
                t.Descricao = txtDescricao.Text;
                t.Usuario = (Usuario)Session["usuario"]; //usuario autenticado
                
                TarefaBusiness business = new TarefaBusiness();
                business.Cadastrar(t);

                lblMessangem.Text = "Tarefa " + t.NomeTarefa 
                    + " cadastrado com sucesso. ";
                //limpar os campos do formulário
                txtNome.Text = string.Empty;
                txtDataHora.Text = string.Empty;
                txtDescricao.Text = string.Empty;

            }
            catch (Exception ex)
            {
                lblMessangem.Text = ex.Message;
            }
        }
    }
}