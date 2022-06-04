using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eje__303
{
    class Estudiante
    {
        #region field
        private string apellido,
                       legajo, 
                       nombre;
        private int notaPrimerParcial,
                    notaSegundoParcial;
        private static Random random;

        #endregion field

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        #region Methods

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                return (6 + random.NextDouble() * 4);
            }
            else
            {
                return -1;
            }
           
        }
        private float CalcularPromedio()
        {
            return ((float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2);
        }
        public string Mostrar()
        {

            string notaFinalStringAux;
            if (this.CalcularNotaFinal() != -1)
            {
                notaFinalStringAux = this.CalcularNotaFinal().ToString();
            }
            else
            {
                notaFinalStringAux = "Alumno desaprobado";
            }
            StringBuilder imprimir = new StringBuilder();
            imprimir.AppendLine(this.nombre +" "+  this.apellido +" y "+ this.legajo).
                AppendLine("Nota prime parcial:"+this.notaPrimerParcial+" y Nota segundo parcial:"+this.notaSegundoParcial).
                AppendLine("Promedio:"+this.CalcularPromedio()).
                AppendLine("Nota Final: "+ notaFinalStringAux);

            return (imprimir.ToString());
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        #endregion Methods

    }
}

