using System;
using System.Text;

namespace Lavadero2016
{
    public abstract class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;

        public enum EMarcas
        {
            Honda, Ford, Zanella, Scania, Iveco, Fiat
        }

        public EMarcas Marca
        {
            get;
        }

        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }

        

        ///Metodos
        ///



        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca:{0} \nPatente:{1} \nRuedas:{2}", this.Marca, this.patente, this.cantRuedas.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1 is not null && v2 is not null && v1.patente == v2.patente && v1.marca == v2.marca);       
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Vehiculo)
            {
                retorno = (this == (Vehiculo)obj);
            }
            return retorno;
        }

        

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
