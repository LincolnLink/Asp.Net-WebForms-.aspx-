using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Tarefas
{
    class DataHoraInvalidaException : Exception
    {
        public override string Message
        {
            get
            {
                return "Data e Hora da tarefa são inválidos";
            }
        }
    }
}
