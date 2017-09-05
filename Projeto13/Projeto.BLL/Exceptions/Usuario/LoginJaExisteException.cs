using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.BLL.Exceptions.Usuario
{
    public class LoginJaExisteException : Exception
    {
        public override string Message
        {
            get
            {
                return "Este login ja encontra-se em uso. Tente outro."; 
            }
        }
    }
}
