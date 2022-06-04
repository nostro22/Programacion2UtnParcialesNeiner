using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMascotas
{
   public class Perro : Mascota
    {

        //Campos

        private int edad;
        private bool esAlfa;

        //Metodos

        public override bool Equals(object obj)
        {
            return (obj is Perro perro && this == perro);
        }

        public static explicit operator int(Perro p)
        {
        return p.edad;
        }

        //Constructor

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false) { }




        //sobreEscritura

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.GetType().Name.ToLower()} - ").Append(base.DatosCompletos());
            if (this.esAlfa)
            {
                sb.Append($", alfa de la manada,");
            }
            sb.Append($" edad {this.edad}");
            return sb.ToString();
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (((Mascota)p1) == p2 && p1.edad == p2.edad);
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        
        public override string ToString()
        {
            return this.Ficha();
        }
       
    }
}
