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
       
        private void AgregarPedido(Pedidos NuevoPedido){
            ListadoPedidos?.Add(NuevoPedido);
        }

        public void AltaDePedidos(int NroPedido, string? ObsPedido, string? NombreCliente, string? DireccionCliente, string? TelefonoCliente, string? DatosReferenciaDireccionCliente){
            Cliente NuevoCliente = new Cliente(NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);   
            Pedidos NuevoPedido = new Pedidos(NroPedido, ObsPedido, NuevoCliente);
            ListadoPedidos?.Add(NuevoPedido);
        }

        public void AsignarCadeteAPedido(int IdCadete, int IdPedido){
            foreach (Pedidos Pedido in ListadoPedidos)
            {
                if (IdPedido == Pedido.Nro)
                {
                    Pedido.IdCadete = IdCadete;
                    Pedido.Estado = Estados.Asignado;
                }
            }
            
        }

        public float JornalACobrar(int IdCadete){
            float montoACobrar = 0;
            foreach (Pedidos Pedido in ListadoPedidos)
            {   
                if (Pedido.IdCadete == IdCadete && Pedido.Estado == Estados.Entregado)
                {
                    montoACobrar+=500;
                }
            }
            return montoACobrar;
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

        public void CambiarEstadoDePedido(int NroPedido){
            foreach (Pedidos Pedido in ListadoPedidos)
            {
                if (Pedido.Nro == NroPedido)
                {
                    Pedido.Estado = Estados.Entregado;
                }
            }
        }

        public void ReasignarPedido(int NroPedido, int IdCadeteNuevo){
            foreach (Pedidos Pedido in ListadoPedidos)
            {
                if (Pedido.Nro == NroPedido)
                    Pedido.IdCadete = IdCadeteNuevo;
            }
        }

        public Informe InformePedidosDeJornada(){
            var informe = new Informe();
            foreach (Cadete cadete in ListadoCadetes)
            {
               informe.TotalMontos.Add(JornalACobrar(cadete.Id));
               informe.EnviosPromedio.Add(JornalACobrar(cadete.Id)); 
            }
        }
    }
}