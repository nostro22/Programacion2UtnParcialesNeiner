using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3ClassLibrary
{
    public class Cliente : Persona
    { 
        private EtipoCliente tipo;

        public EtipoCliente TipoCliente
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
        public Cliente():base()
        {
        }

        public Cliente(int dni, string nombre, DateTime fechaNacimiento,EtipoCliente tipo) : base(dni, nombre, fechaNacimiento)
        {
            this.tipo = tipo;
            if (tipo == EtipoCliente.all)
            {
                this.tipo = EtipoCliente.particular;
            }
        }

     
    }
  


}
