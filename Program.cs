
using System.IO;
using System.Collections;


using Practico1;

namespace Practico1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CargarDatos CargaDatos = new CargarDatos();
            
            Cadeteria NuevaCadeteria = CargaDatos.CargarDatosCadeteria();
            CargaDatos.CargarDatosCadete(NuevaCadeteria.ListadoCadetes);


            NuevaCadeteria.AltaDePedidos();

            NuevaCadeteria.CambiarEstadoDePedido();

        }
    }
}