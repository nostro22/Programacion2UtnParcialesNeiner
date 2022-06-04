using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEnumeadosTinta
{
   public class Rectangulo
    {
        #region Fields
        private float area, perimetro;
        private Punto vertice1, vertice2, vertice3, vertice4;
        #endregion Fields

        #region Methods
        public float Area()
        {
            if (this.area == -1)
            {
                float baseCuadrado = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float alturaCuadrado = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = (baseCuadrado * alturaCuadrado);
            }
            return this.area;
        }
        public float Perimetro()
        {
            if (this.perimetro == -1)
            {
                float baseCuadrado = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                float alturaCuadrado = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.perimetro = 2 * (baseCuadrado + alturaCuadrado);               
            }
            return this.perimetro;
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.perimetro = -1;
            this.area = -1;
        }
        #endregion Methods
    }
}
