using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClase3
{



    public class Conductor
    {

        private string nombre;
        private int[] ListakilometrosPorDia;

        public Conductor(string nombre, int[] ArraykmSemana)
        {
            if (ArraykmSemana.Length == 7)
            {
                this.nombre = nombre;
                this.ListakilometrosPorDia = ArraykmSemana;
            }
            else
            {
                this.nombre = nombre;
                this.ListakilometrosPorDia = new int[7];
            }
        }

        public Conductor()
        {
            this.nombre = string.Empty;
            this.ListakilometrosPorDia = new int[7];        
        }

        public string GetName()
        {
            return this.nombre;
        }
        public int[] GetListaKilometrosPorDia()
        {
            return this.ListakilometrosPorDia;
        }
        public int CalcularTotalKmEnDia( int numeroDia)
        {
            int kmTotales = -1;
            numeroDia++;
            if (numeroDia > -1 && numeroDia < 8)
            {
                kmTotales = this.GetListaKilometrosPorDia()[numeroDia];
            }           
           
            return kmTotales;
        }
        public int CalcularTotalKmEnOrden(int numeroDiasACalcular)
        {
            int kmTotales = 0;
            int[] listaKmTrabajados = this.GetListaKilometrosPorDia();
            for (int i = 0; i < numeroDiasACalcular; i++)
            {
                kmTotales += listaKmTrabajados[i];
            }
            return kmTotales;
        }
        public int CalcularTotalKmPorSemanaEnEficiencia(int diasAContar)
        {
            int kmTotales = 0;
            int[] listaKmTrabajados = this.GetListaKilometrosPorDia();
            Array.Sort(listaKmTrabajados);
            for (int i = diasAContar; i > 0 ; i--)
            {
                kmTotales += listaKmTrabajados[i];
            }
            return kmTotales;
        }

        public static Conductor CalcularMejorConductorRango(Conductor[] listaConductores, int diasAContar)
        {
            Conductor conductorConMasKm = new Conductor();
            int cantidadDeKilometrosMaximos = 0;

            foreach (var item in listaConductores)
            {
                if (item.CalcularTotalKmEnOrden(7) > cantidadDeKilometrosMaximos)
                {
                    conductorConMasKm = item;
                    cantidadDeKilometrosMaximos = item.CalcularTotalKmEnOrden(7);
                }
            }
            return conductorConMasKm;
        }

        public static Conductor CalcularMejorConductorDiaEspecifico(Conductor[] listaConductores, int dia)
        {
            Conductor conductorConMasKm = new Conductor();
            int cantidadDeKilometrosMaximos = 0;

            foreach (var item in listaConductores)
            {
                if (item.CalcularTotalKmEnDia(dia) > cantidadDeKilometrosMaximos)
                {
                    conductorConMasKm = item;
                    cantidadDeKilometrosMaximos = item.CalcularTotalKmEnDia(dia);
                }
            }
            return conductorConMasKm;
        }

    }

    public enum Dias
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }
}
