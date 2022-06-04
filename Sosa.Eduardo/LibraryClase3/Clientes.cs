using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{
    public class Clientes
    {
        private string domicilio, nombre, apellido;
        private int telefono;
        private List<Mascotas> listaMascotas;

        #region property
        public string Domicilio
        {
            get
            {
                return this.domicilio;
            }
            set
            {
                this.domicilio = value;
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
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }

        public List<Mascotas> ListaMascotas
        {
            get
            {
                return this.listaMascotas;
            }
            set
            {
                listaMascotas = value;
            }
        }

        #endregion property

        public Clientes(string domicilio, string nombre, string apellido, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.listaMascotas = new List<Mascotas>();
        }
        public void AddMascota(Mascotas mascota)
        {
            this.ListaMascotas.Add(mascota);
        }
        public string ImprimirCliente()
        {
            StringBuilder impresion = new StringBuilder();
            impresion.Append("Cliente \nNombre:" + this.nombre).
            Append("\nApellido:" + this.apellido).
            Append("\nDomicilio:" + this.domicilio).
            Append("\nTelefono:" + this.telefono);
            foreach (var item in this.listaMascotas)
            {
                impresion.Append(item.ImprimirMascota());
            }
            return impresion.ToString();
        }
        public Mascotas GetMascotas(int posicion)
        {
            return this.listaMascotas[posicion];
        }


    }


}
