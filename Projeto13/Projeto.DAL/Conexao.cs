using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class Conexao
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        protected void OpenConnection()
        {
            
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\COTI informatica\GitHub 2\Projeto13\Proejto.WEB\App_Data\Banco.mdf;Integrated Security=True");
            con.Open();
        }
        protected void CloseConnection()
        {
            con.Close();
        }
    }
}
