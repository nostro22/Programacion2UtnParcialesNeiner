using System;
using System.Text;

namespace Entidades.Primer.Parcial
{
    public class Fabricante
    {

        //campos

        private string marca;
        private EPais pais;

        //Methods

        public Fabricante(String marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        public static implicit operator String(Fabricante f)
        {
            return $"{f.marca} - {f.pais}";
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {

            return (a is Fabricante && b is Fabricante && a.marca == b.marca && a.pais == b.pais);               
         
        }



        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }
    }
}
