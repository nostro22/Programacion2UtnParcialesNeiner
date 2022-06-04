using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMascotas
{
   public class Gato:Mascota
    {

        //Constructor
        public Gato(string nombre, string raza)
            : base(nombre, raza) { }

        //Metodos  //sobreEscritura 

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.GetType().Name.ToLower()} - ").Append(base.DatosCompletos());
            
            return sb.ToString();
        }      

        public static bool operator ==(Gato g1, Gato g2)
        {
            return ((Mascota)g1) == g2;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            return (obj is Gato gato && this == gato);
        }

    }
}
