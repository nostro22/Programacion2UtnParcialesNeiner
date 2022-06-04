using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIngresante
{
    public class Ingresante
    {
        //Fields

        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        //Methods

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder impresion = new StringBuilder($"Nombre:{this.nombre} \nDireccion:{this.direccion} \nGenero:{this.genero} \nPais:{this.pais} \nCursos:");
            foreach (var item in this.cursos)
            {
                impresion.AppendLine(item);
            }
            impresion.AppendLine($"Edad:{this.edad}");

            return impresion.ToString();
        }
    }
}
