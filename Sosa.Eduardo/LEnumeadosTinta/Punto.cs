using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEnumeadosTinta
{
    public class Punto
    {
        #region Fields
        private int x;
        private int y;
        #endregion Fields

        #region Methods
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion Methods
    }
}
