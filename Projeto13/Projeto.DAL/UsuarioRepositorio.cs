using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto.Entidades;

namespace Projeto.DAL
{
    public class UsuarioRepositorio : Conexao
    {

        #region Insert
        public void Insert(Usuario u)
        {
            OpenConnection();

            string query = " INSERT INTO Usuario(Nome, Login, Senha, Foto, DataCadastro) " +
                " VALUES(@Nome, @Login, @Senha, @Foto, GetDate()) ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Nome", u.Nome);
            cmd.Parameters.AddWithValue("@Login", u.Login);
            cmd.Parameters.AddWithValue("@Senha", u.Senha);
            cmd.Parameters.AddWithValue("@Foto", u.Foto);
            cmd.ExecuteNonQuery();

            CloseConnection();
        }
        #endregion

        #region Buscar Usuario - Login e senha
        public Usuario Find(string Login, string Senha)
        {
            OpenConnection();

            string query = " SELECT * FROM Usuario " +
                " where Login = @Login and Senha = @Senha ";

            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", Login);
            cmd.Parameters.AddWithValue("@Senha", Senha);
            dr = cmd.ExecuteReader();

            Usuario u = null;

            if (dr.Read())
            {
                u = new Usuario();
                u.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                u.Nome = Convert.ToString(dr["Nome"]);
                u.Login = Convert.ToString(dr["Login"]);
                u.Senha = Convert.ToString(dr["Senha"]);
                u.Foto = Convert.ToString(dr["Foto"]);
                u.DataCadastro = Convert.ToDateTime(dr["DataCadastro"]);
            }
            CloseConnection();
            return u;
        }
        #endregion

        #region pesquisa se existe por login
        public bool HasUsuario(string Login)
        {
            OpenConnection();

            string query = " SELECT Count(*) FROM Usuario " +
                " where Login = @Login ";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Login", Login);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            
            CloseConnection();

            if ( count > 0)
                return true;
            else
                return false;
        }
        #endregion

    }
}
