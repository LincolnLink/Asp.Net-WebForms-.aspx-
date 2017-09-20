using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Usuario
{
    public class AcessoNegadoException : Exception
    {
        public override string Message
        {

            get
            {
                return "Acesso negado, usuario invalido";
            }
        }
    }
}
