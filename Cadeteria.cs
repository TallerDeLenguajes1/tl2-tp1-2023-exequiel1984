using System.Data.Common;

namespace Practico1
{
    public class Cadeteria
    {
        private string? nombre;
        private string? telefono;
        private List<Cadete>? listadoCadetes;
        private List<Pedidos>? ListadoPedidos;

        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public List<Cadete>? ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

        public Cadeteria(string? Nombre, string? Telefono)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            List<Cadete> ListadoCadetes = new List<Cadete>();
            List<Pedidos> ListadoPedidos = new List<Pedidos>();
        }
        public Cadeteria(string[]? DatosCadeteria)
        {
            this.Nombre = DatosCadeteria?[0];
            this.Telefono = DatosCadeteria?[1];
            List<Cadete> ListadoCadetes = new List<Cadete>();
            List<Pedidos> ListadoPedidos = new List<Pedidos>();
        }
        private void AgregarPedido(Pedidos NuevoPedido){
            ListadoPedidos?.Add(NuevoPedido);
        }

        public void AltaDePedidos(int NroPedido, string? ObsPedido, string? NombreCliente, string? DireccionCliente, string? TelefonoCliente, string? DatosReferenciaDireccionCliente){
            Pedidos NuevoPedido = new Pedidos(NroPedido, ObsPedido);    
        }

        public void AsignarCadeteAPedido(int IdCadete, int IdPedido){
            foreach (Pedidos Pedido in ListadoPedidos)
            {
                if (IdPedido == Pedido.Nro)
                {
                    Pedido.IdCadete = IdCadete;
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

        /* public void CambiarEstadoDePedido(int IdCadete, int NroPedido){
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
        } */

        /* public void ReasignarPedido(int IdCadeteAnterior, int NroPedido, int IdCadeteNuevo){
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
        } */
    }
}