using System.Data.Common;

namespace Practico1
{
    public class Cadeteria
    {
        private string? nombre;
        private string? telefono;
        private List<Cadete> listadoCadetes = new List<Cadete>();

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

        public Cadeteria(string? Nombre, string? Telefono)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            List<Cadete> ListadoCadetes = new List<Cadete>();
        }

        public void AltaDePedidos(int IdCadete, int NroPedido, string? ObsPedido, string? NombreCliente, string? DireccionCliente, string? TelefonoCliente, string? DatosReferenciaDireccionCliente){
            foreach (Cadete cadete in ListadoCadetes)
            {
                if (cadete.Id == IdCadete)
                {
                    cadete.CrearPedidoEnCadete(NroPedido, ObsPedido, NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
                }
            }
        }

        /* private Pedidos? BuscarPedido(){
            System.Console.WriteLine("Ingrese el Id del cadete:");
            int IdCadete = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese el numero de pedido:");
            int NroPedido = Convert.ToInt32(Console.ReadLine());
            foreach (var Cadete in ListadoCadetes)
            {
                if (Cadete.Id == IdCadete)
                {
                    foreach (var pedido in Cadete.ListadoPedidosCadete)
                    {
                        if (pedido.Nro == NroPedido)
                        {
                            return pedido;
                        } else
                        {
                            return null;
                        }
                    }
                }else
                {
                    return null;
                }
            }
        } */

        public void CambiarEstadoDePedido(int IdCadete, int NroPedido){
            foreach (var Cadete in ListadoCadetes)
            {
                if (Cadete.Id == IdCadete)
                {
                    foreach (var pedido in Cadete.ListadoPedidosCadete)
                    {
                        if (pedido.Nro == NroPedido)
                        {
                            pedido.Estado = Estados.Entregado;
                        }
                    }
                }
            }
        }

        public void ReasignarPedido(int IdCadeteAnterior, int NroPedido, int IdCadeteNuevo){
            Pedidos PedidoTemporal = new Pedidos();
            foreach (var Cadete in ListadoCadetes)
            {
                if (Cadete.Id == IdCadeteAnterior)
                {
                    foreach (var pedido in Cadete.ListadoPedidosCadete)
                    {
                        if (pedido.Nro == NroPedido)
                        {
                            PedidoTemporal = pedido;
                            System.Console.WriteLine(PedidoTemporal.Cliente?.Nombre);
                        }
                    }
                    Cadete.ListadoPedidosCadete.Remove(PedidoTemporal);
                }
            }
            foreach (var Cadete in ListadoCadetes)
            {
                if (Cadete.Id == IdCadeteNuevo)
                {
                    Cadete.ListadoPedidosCadete.Add(PedidoTemporal);
                }
            }
        }

        public void InformePedidosDeJornada(){
            foreach (var cadete in listadoCadetes)
            {
                System.Console.WriteLine($"{cadete.Nombre}: {cadete.JornalACobrar()}");
            }
        }
    }
}