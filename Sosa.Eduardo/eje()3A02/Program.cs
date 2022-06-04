using System;
using LibraryClase3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eje__3A02
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Clientes> baseDatosClientes = new List<Clientes>();
            Clientes edu = new Clientes("Lanus", "Edu", "Sosa", 1123870511);
            edu.AddMascota(new Mascotas("perro", "Penelope", DateTime.Now));
            Clientes ana = new Clientes("Recoleta", "Ana", "Segovia", 112385461);
            ana.AddMascota(new Mascotas("gato", "rex",DateTime.Parse("22/08/1956")));
            ana.GetMascotas(0).AddVacuna("Triple Felina");
            Clientes andres = new Clientes("Recoleta", "Andres", "Perez", 112385661);
            andres.AddMascota(new Mascotas("gato", "Nix", DateTime.Parse("22/08/1986")));
            andres.AddMascota(new Mascotas("perro", "Nixon", DateTime.Parse("2/04/1986")));
            andres.GetMascotas(1).AddVacuna("Rabia");
            baseDatosClientes.Add(edu);
            baseDatosClientes.Add(ana);
            baseDatosClientes.Add(andres);
            foreach (var item in baseDatosClientes)
            {
                Console.WriteLine(item.ImprimirCliente());
            }

        }
    }
}
