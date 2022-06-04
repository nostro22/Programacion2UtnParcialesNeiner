using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPruebasUnitarias
{
    public class NegatioNoPermitidoException : Exception
    {
        public NegatioNoPermitidoException(string mensaje) : base(mensaje) { }
    }
}
