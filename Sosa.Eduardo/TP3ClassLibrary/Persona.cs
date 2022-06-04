using System;
using System.Xml.Serialization;

namespace TP3ClassLibrary
{


    [XmlInclude(typeof(Afiliado))]
    [XmlInclude(typeof(Cliente))]
    public abstract class  Persona
    {
      
        protected int dni;
        protected string nombre;
        protected DateTime fechaNacimiento;

       public Persona()
        {        
        }

        public Persona(int dni, string nombre, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public int Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }
    }
}
