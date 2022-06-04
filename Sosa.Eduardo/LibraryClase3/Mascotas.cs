using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{
    public class Mascotas
    {
        private string especie, nombre;
        private DateTime fechaDeNacimiento;
        private StringBuilder listaVacunas;
        #region property
        public string Especie
        {
            get
            {
                return this.especie;
            }
            set
            {
                this.especie = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento.Date;
            }
            set
            {
                this.fechaDeNacimiento = value.Date;
            }
        }
        public StringBuilder ListaDeVacunas
        {
            get
            {
                return this.listaVacunas;
            }
            set
            {
                this.listaVacunas = value;
            }
        }
        #endregion property

        public Mascotas(string especie, string nombre, DateTime fechaDeNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento.Date;
            this.listaVacunas = new StringBuilder();
        }

        public string ImprimirMascota()
        {
            StringBuilder impresion = new StringBuilder();
            impresion.Append("\nMascota \nNombre:" + this.nombre).
            Append("\nEspecie:" + this.especie).
            Append("\nFecha de nacimiento:" + this.fechaDeNacimiento.Date).
            Append("\nVacunas:" + this.listaVacunas);
            return impresion.ToString();
        }

        public void AddVacuna(string vacuna)
        {
            this.listaVacunas.Append("\n" + vacuna);
        }


    }
}
