using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3ClassLibrary
{
    public class Afiliado : Persona
    {
        private eTipoAfiliado tipoAfiliado;
        private DateTime fechaContratacion;
       

        public Afiliado() : base()
        {
        }


        public Afiliado(int dni, string nombre, DateTime fechaNacimiento, DateTime fechaContratacion) : base(dni,nombre,fechaNacimiento)
        {
            this.FechaContratacion = fechaContratacion;
        }

        public eTipoAfiliado TipoVendendor
        {
            get
            {
                eTipoAfiliado tipoVendedor;
                
                int antiguedad = CalcularAntiguedad();
               
                tipoVendedor = eTipoAfiliado.trainee;
                
                if (antiguedad <= 2 && antiguedad > 4)
                {
                    tipoVendedor = eTipoAfiliado.junior;
                }
                else if (antiguedad >= 4 )
                {
                    tipoVendedor = eTipoAfiliado.senior;
                }

                return tipoVendedor;
            }
          
        }

        public DateTime FechaContratacion
        {
            get
            {
                return fechaContratacion;
            }

            set
            {
                fechaContratacion = value;
            }
        }

        private int CalcularAntiguedad()
        {
            DateTime today = DateTime.Today;
          
            int antiguedad = today.Year - FechaContratacion.Year;


            if (FechaContratacion.Date > today.AddYears(-antiguedad))
            {
                antiguedad--;
            }
            
            return antiguedad;
        }

        public static List<string> GetNamesDni(List<Persona> listaVendedores)
        {
            List<string> listaVendoresActivos = new List<string>();
            foreach (Persona item in listaVendedores)
            {
                if(item is Afiliado unVendedor)
                listaVendoresActivos.Add($"{unVendedor.dni} - {unVendedor.nombre}");
            }

            return listaVendoresActivos;
        }
       
    }
   
}
