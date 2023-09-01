
using System.IO;
using System.Collections;


using Practico1;

namespace Practico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CargarDatos CargarDatos = new CargarDatos();
            Cadeteria NuevaCadeteria = CargarDatos.CargarDatosCadeteria();

            AccesoADatos CargarDatosCadetes = new AccesoCSV();
            NuevaCadeteria.ListadoCadetes = CargarDatosCadetes.CargarDatosCadete();

            System.Console.WriteLine($"{NuevaCadeteria.Nombre}");
            System.Console.WriteLine($"{NuevaCadeteria.ListadoCadetes[0].Nombre}");
            //CargaDatos.CargarDatosCadete(NuevaCadeteria.ListadoCadetes);


            //NuevaCadeteria.AltaDePedidos();

            //NuevaCadeteria.CambiarEstadoDePedido();

        }
    }
}