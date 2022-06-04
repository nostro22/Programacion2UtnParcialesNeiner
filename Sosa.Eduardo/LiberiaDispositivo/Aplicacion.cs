using System;
using System.Collections.Generic;
using System.Text;

namespace LiberiaDispositivo
{
    public abstract class Aplicacion 
    {
        //fields

        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        //property
        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        protected abstract int Tamanio
        {
            get;
        }

        //Metodos

        protected Aplicacion(string nombre, SistemaOperativo sitemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.tamanioMb = tamanioMb;
            this.sistemaOperativo = SistemaOperativo;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int posDeLaMasPesada = 0;
            int appMasPesada=0;
            if (listaApp.Count > 0)
            {
               
                int index = 0;
                
                foreach (Aplicacion item in listaApp)
                {
                    if (index == 0)
                    {
                        appMasPesada = item.tamanioMb;
                    }
                    else if (item.tamanioMb > appMasPesada)
                    {
                        appMasPesada = item.tamanioMb;
                        posDeLaMasPesada = index;
                    }
                    index++;
                }
               
            }

            return listaApp[posDeLaMasPesada];
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.SistemaOperativo.ToString());
            sb.AppendLine(this.Tamanio.ToString());
            return sb.ToString();
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if (app is not null && listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach (Aplicacion item in listaApp)
            {
                if (item.nombre == app.nombre)
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
