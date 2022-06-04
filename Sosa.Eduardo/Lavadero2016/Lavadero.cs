using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero2016
{
    class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;

        public enum EVehiculos
        {
             Auto,Camion,Moto
        }

        public Lavadero(List<Vehiculo> vehiculos, float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.vehiculos = vehiculos;
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }

        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();           
        }

        public string Detalles
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Precios Vigentes: \nP.Autos:{0} \nP.Camion:{1} \nP.Moto:{2}", this.precioAuto, this.precioCamion, this.precioMoto);
                sb.AppendLine("Listado de vehiculos:");
                foreach (object item in this.vehiculos)
                {
                    sb.AppendLine((string)item);
                }
                return sb.ToString();
            }
        }

        public double MostrarTotalFacturado(EVehiculos tipoVehiculo)
        {
            double totalGanancia = 0;

            foreach (Vehiculo item in this.vehiculos)
            {
                if (tipoVehiculo == EVehiculos.Auto)
                {
                
                }

            }
        }

        public double MostrarTotalFacturado()
        {
            double totalGanancia = 0;

            foreach (Vehiculo item in this.vehiculos)
            {
                if (item is Auto)
                {

                }
                else if (item is Moto)
                {
                
                }
                else if (item is Camion)
                {

                }
            }
        }


    }
}
