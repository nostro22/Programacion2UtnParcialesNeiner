using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;


        public Cuenta(string nombreRazonSocial)
        {
            this.titular = nombreRazonSocial;       
        }
        public Cuenta(string nombreRazonSocial, float cantidadDinero):this(nombreRazonSocial)
        {          
            this.cantidad = cantidadDinero;
        }       

        #region property
        public string RazonSocial
        {
            get{ return titular;}
            set { titular = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        #endregion property;

        #region Fuctions
        public void Mostrar()
        {
            Console.WriteLine("Razon Social:{0}\nCantidad:{1}", this.RazonSocial, this.Cantidad);
        }
        public void ingresar(float deposito)
        {
            if(deposito>0)
            {
                this.Cantidad += deposito; 
            }
        }
        public void retirar(float retiro)
        {
            if (retiro > 0)
            {
                this.Cantidad -= retiro;
            }
        }
        #endregion Functions

    }

}
