using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto06
{
    class NoHaySuficienteSaldo : Exception
    {
        public NoHaySuficienteSaldo(string pMensaje) : base(pMensaje)
        { }
    }
}
