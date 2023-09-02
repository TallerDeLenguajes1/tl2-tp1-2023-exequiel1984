
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

            System.Console.WriteLine("*****INTERFAZ USUARIO*****");
            System.Console.WriteLine("1 Dar de alta pedido");
            System.Console.WriteLine("2 Cambiar de estado");
            System.Console.WriteLine("3 Reasignar pedido a otro cadete");
            System.Console.WriteLine("0 Salir");
            System.Console.WriteLine("Ingrese el numero de Operacion a realizar:");
            int IdOperacion = Convert.ToInt32(Console.ReadLine());

            while (IdOperacion != 0)
            {
                switch (IdOperacion)
                {
                    case 1:
                        System.Console.WriteLine("\n*****DAR DE ALTA PEDIDO*****");
                        System.Console.WriteLine("Ingrese el Id del cadete: ");
                        int IdCadete = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el numero de pedido:");
                        int NroPedido = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese la observacion del pedido:");
                        string? ObsPedido = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el nombre del cliente:");
                        string? NombreCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese la direccion del cliente:");
                        string? DireccionCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese el telefono del cliente:");
                        string? TelefonoCliente = Console.ReadLine();
                        System.Console.WriteLine("Ingrese los datos de referencia de la direccion del cliente:");
                        string? DatosReferenciaDireccionCliente = Console.ReadLine(); 
                        NuevaCadeteria.AltaDePedidos(IdCadete, NroPedido, ObsPedido, NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
                        System.Console.WriteLine("*****FIN ALTA PEDIDO*****\n");
                    break;
                    case 2:
                        System.Console.WriteLine("*****CAMBIAR ESTADO DE PEDIDO*****");
                        System.Console.WriteLine("Ingrese el Id del cadete:");
                        IdCadete = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el numero de pedido:");
                        NroPedido = Convert.ToInt32(Console.ReadLine());
                        NuevaCadeteria.CambiarEstadoDePedido(IdCadete, NroPedido);
                        System.Console.WriteLine("*****FIN CAMBIAR ESTADO DE PEDIDO*****\n");

                    break;
                    case 3:
                        System.Console.WriteLine("*****REASIGNAR PEDIDO*****");
                        System.Console.WriteLine("Ingrese el Id del cadete con el pedido a reasignar:");
                        int IdCadeteAnterior = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el numero de pedido a reasignar:");
                        NroPedido = Convert.ToInt32(Console.ReadLine());
                        System.Console.WriteLine("Ingrese el Id del nuevo cadete:");
                        int IdCadeteNuevo = Convert.ToInt32(Console.ReadLine());
                        NuevaCadeteria.ReasignarPedido(IdCadeteAnterior, NroPedido, IdCadeteNuevo);
                        System.Console.WriteLine($"Nombre Cliente en nuevo cadete: {NuevaCadeteria.ListadoCadetes[1].ListadoPedidosCadete[0].Cliente?.Nombre}");
                    break;
                }
                System.Console.WriteLine("*****INTERFAZ USUARIO*****");
                System.Console.WriteLine("1 Dar de alta pedido");
                System.Console.WriteLine("2 Cambiar de estado");
                System.Console.WriteLine("3 Reasignar pedido a otro cadete");
                System.Console.WriteLine("0 Salir");
                System.Console.WriteLine("Ingrese el numero de Operacion a realizar:");
                IdOperacion = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine("*****INFORME PEDIDOS DE JORNADA*****");
            NuevaCadeteria.InformePedidosDeJornada();
        }
    }
}