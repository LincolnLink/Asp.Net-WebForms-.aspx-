using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL;
using Projeto.BLL.Exceptions.Tarefas;


namespace Projeto.BLL
{
    public class TarefaBusiness
    {

        public void Cadastrar(Tarefa t)
        {
            if (t.DataHora >= DateTime.Now)
            {
                TarefasRepositorio rep = new TarefasRepositorio();
                rep.Insert(t);
            }
            else
            {
                throw new DataHoraInvalidaException();
            }
        }

        public List<Tarefa> Consultar(DateTime inicio, DateTime fim, int id)
        {
            if (inicio < fim)
            {
                TarefasRepositorio rep = new TarefasRepositorio();
                return rep.Find(inicio, fim, id);
            }
            else
            {
                throw new DataHoraInvalidaException();
            }
        }  
    }
}
