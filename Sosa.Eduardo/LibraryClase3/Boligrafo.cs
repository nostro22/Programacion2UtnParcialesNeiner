using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{
    public class Boligrafo
    {
        #region Fields
        const short cantidadTintaMaxima =100;
        private ConsoleColor color;
        private short tinta;
        #endregion Fields

        #region Methods
        public Boligrafo(short tinta, ConsoleColor color)
        {

            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            short contadorDibujo = 0;
            bool esPosibleDibujar = false;
            dibujo = string.Empty;
            StringBuilder dibujosPosible= new StringBuilder();
            if (gasto > 0)
            {
                while (this.GetTinta() > 0 && contadorDibujo < gasto)
                {
                    dibujosPosible.Append("*");
                    this.SetTinta(-1);
                    contadorDibujo++;
                }
                dibujo = dibujosPosible.ToString();
                esPosibleDibujar = true;
            }
           
            return esPosibleDibujar;
        }
        public void Recarga()
        {
            short tintaResultante = (short)(cantidadTintaMaxima- this.GetTinta());
            this.SetTinta(tintaResultante);
        }

        private void SetTinta(short tinta)
        {
            short tintaResultante = (short)(this.GetTinta() + tinta);
            if (tintaResultante >-1 && tintaResultante < 101)
            {
                this.tinta += tinta;
            }
        }
        #endregion Methods
    }
}
