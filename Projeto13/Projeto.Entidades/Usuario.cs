using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Usuario
    {
        //Atributo
        private int idUsuario;
        private string nome;
        private string login;
        private string senha;
        private string foto;
        private DateTime dataCadastro;

        public Usuario()
        {

        }
        public Usuario(int idUsuario, string nome, string login, string senha, string foto, DateTime dataCadastro)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Login = login;
            Senha = senha;
            Foto = foto;
            DataCadastro = dataCadastro;
        }

        public int IdUsuario
        {
            set { idUsuario = value; }
            get { return idUsuario;  }
        }
        public string Nome
        {
            set { nome = value; }
            get { return nome;  }
        }
        public string Login
        {
            set { login = value; }
            get { return login;  }
        }
        public string Senha
        {
            set { senha = value; }
            get { return senha;  }
        }
        public string Foto
        {
            set { foto = value; }
            get { return foto;  }
        }
        public DateTime DataCadastro
        {
            set { dataCadastro = value; }
            get { return dataCadastro;  }
        }

        public override string ToString()
        {
            return "Id: " + idUsuario + "Nome: " + nome + "Login: " + login +
                "Senha " + senha + "Foto: " + foto + "Data Time: " + dataCadastro;
        }
    }
}
