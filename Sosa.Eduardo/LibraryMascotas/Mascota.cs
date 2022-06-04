using System;
using System.Text;

namespace LibraryMascotas
{
    public abstract class Mascota
    {
        //Campos

        private string nombre;
        private string raza;

        //Propiedades

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        //Metodos

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder().AppendFormat("{0} - {1}",this.nombre,this.raza);
            return sb.ToString();
        }

        protected abstract string Ficha();    

        //Constructor
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        //Sobreescritura

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            bool retorno = false;
            if (m1 is not null && m2 is not null && m1.nombre == m2.nombre && m1.raza == m2.raza)
            {
                retorno = true;
            }
            return retorno;
        }

       
    }
}
