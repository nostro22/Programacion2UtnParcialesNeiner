using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberiaDispositivo
{
    public class AppMusical : Aplicacion
    {
        //fields

        private List<string> listaCanciones;
        
        //Properties

        protected override int Tamanio
        {
            get
            {
                return this.tamanioMb +listaCanciones.Count * 2;
            }
        }

        //methods
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial):base(nombre,sistemaOperativo,tamanioInicial)
        {
            this.listaCanciones = new List<string>();
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones):this(nombre,sistemaOperativo,tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }

        public int metodorube()
        {
            return 2;
        }

        public float metodorube(int numero)
        {
            return 20;
        }

        private bool metodorube(string name)
        {
            return true;
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones: ");
            foreach (string item in listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();

        }

        

    }
}
