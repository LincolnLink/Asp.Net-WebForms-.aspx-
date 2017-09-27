using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using System.Data.SqlClient;

namespace Projeto.DAL
{
    public class TarefasRepositorio : Conexao
    {
        #region Inserindo a Tarefa
        
        public void Insert(Tarefa t)
        {
            OpenConnection();

            string query = " INSERT INTO Tarefa(NomeTarefa, DataHora, Descricao, IdUsuario) " +
                " VALUES(@NomeTarefa, @DataHora, @Descricao, @IdUsuario ) ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NomeTarefa", t.NomeTarefa);
            cmd.Parameters.AddWithValue("@DataHora", t.DataHora);
            cmd.Parameters.AddWithValue("@Descricao", t.Descricao);
            cmd.Parameters.AddWithValue("@IdUsuario", t.Usuario.IdUsuario);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        #endregion

        #region ListandoTarefas
        
        public List<Tarefa> Find(DateTime dataIni, DateTime dataFim, int IdUsuario)
        {
            OpenConnection();

            string query = " Select * From Tarefa " +
                            " where DataHora Between @DataIni and @DataFim " +
                            " and IdUsuario = @IdUsuario " +
                            " order by DataHora asc ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@DataIni", dataIni);
            cmd.Parameters.AddWithValue("@DataFim", dataFim);
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            dr = cmd.ExecuteReader();

            List<Tarefa> lista = new List<Tarefa>();

            while (dr.Read())
            {
                Tarefa t = new Tarefa();

                t.IdTarefa = Convert.ToInt32(dr["IdTarefa"]);
                t.NomeTarefa = Convert.ToString(dr["NomeTarefa"]);
                t.DataHora = Convert.ToDateTime(dr["DataHora"]);
                t.Descricao = Convert.ToString(dr["Descricao"]);               

                lista.Add(t);
            }

            CloseConnection();
            return lista;
        }

        #endregion




    }

}
