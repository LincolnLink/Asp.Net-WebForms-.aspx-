using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Tarefa
    {
        private int idTarefa;
        private string nomeTarefa;
        private DateTime dataHora;
        private string descricao;
        private Usuario usuario; //Associação (TER-1)


        //Construtor defaut
        public Tarefa()
        {

        }

        public Tarefa(int idTarefa, string nomeTarefa, DateTime dataHora, string descricao)
        {
            IdTarefa = idTarefa;
            NomeTarefa = nomeTarefa;
            DataHora = dataHora;
            Descricao = descricao;
        }

        public int IdTarefa
        {
            set { idTarefa = value; }
            get { return idTarefa;  }
        }

        public string NomeTarefa
        {
            set { nomeTarefa = value; }
            get { return nomeTarefa;  }
        }

        public DateTime DataHora
        {
            set { dataHora = value; }
            get { return dataHora;  }
        }

        public string Descricao
        {
            set { descricao = value; }
            get { return descricao;  }
        }

        public Usuario Usuario
        {
            set { usuario = value; }
            get { return usuario;  }
        }

        public override string ToString()
        {
            return "Id: " + idTarefa + " Nome: " + nomeTarefa +
                " DataHora Hora: " + dataHora + "Descrição: " + descricao +
                "Usuario: "+ usuario ;                
        }
    }
}
