using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{
    public class Persona
    {
        #region Atribute
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;
        #endregion Atribute

        #region Property

        public Persona(string nombre,DateTime fechaDeNacimiento,int dni )
        {
            this.Nombre = nombre;
            this.FechaDeNacimiento = fechaDeNacimiento;
            this.Dni = dni;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        #endregion Property

        #region Functions

        private int CalcularEdad()
        {
            int edad = DateTime.Now.Year - this.FechaDeNacimiento.Year;
            if (DateTime.Now.Month < this.FechaDeNacimiento.Month || DateTime.Now.Month == this.FechaDeNacimiento.Month && DateTime.Now.Day < this.FechaDeNacimiento.Day) edad--;
            return edad;
        }
        public string Mostrar()
        {
            string impresion = "Nombre:" + this.Nombre + "\nFecha de nacimiento:" + this.FechaDeNacimiento.ToShortDateString() + "\nEdad:" + CalcularEdad() + "\nDni:" + this.Dni;  
            return impresion;
        }
        public string EsMayorDeEdad()
        {
            string text;
            if(this.CalcularEdad()>=18)
            {
                text = "Es mayor de edad";
            }
            else
            {
                text = "Es menor";
            }
            return text;
        }
        #endregion Functions

    }
}
