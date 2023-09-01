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
        }

        

        public void AltaDePedidos(){
            System.Console.WriteLine("*****DAR DE ALTA PEDIDO*****");
            System.Console.WriteLine("Ingrese el Id del cadete: ");
            int IdCadeteSeleccionado = Convert.ToInt32(Console.ReadLine());

            foreach (Cadete cadete in ListadoCadetes)
            {
                if (cadete.Id == IdCadeteSeleccionado)
                {
                    cadete.CrearPedidoEnCadete();
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

        public void CambiarEstadoDePedido(){
            System.Console.WriteLine("*****CAMBIAR ESTADO DE PEDIDO*****");
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
                            System.Console.WriteLine($"Estado anterior: {pedido.Estado}");
                            pedido.Estado = Estados.Entregado;
                            System.Console.WriteLine($"Nuevo estado: {pedido.Estado}");
                        }
                    }
                }
            }
        }

        public void ReasignarPedido(){
            System.Console.WriteLine("*****REASIGNAR PEDIDO*****");
            System.Console.WriteLine("Ingrese el Id del cadete con el pedido a reasignar:");
            int IdCadeteAnterior = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese el numero de pedido a reasignar:");
            int NroPedido = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Ingrese el Id del nuevo cadete:");
            int IdCadeteNuevo = Convert.ToInt32(Console.ReadLine());
            foreach (var Cadete in ListadoCadetes)
            {
                if (Cadete.Id == IdCadeteAnterior)
                {
                    foreach (var pedido in Cadete.ListadoPedidosCadete)
                    {
                        if (pedido.Nro == NroPedido)
                        {
                            //System.Console.WriteLine($"Estado anterior: {pedido.Estado}");
                            Cadete.ListadoPedidosCadete.Remove(pedido);
                            //System.Console.WriteLine($"Nuevo estado: {pedido.Estado}");
                        }
                    }
                }
            }
            
            
        }
    }
}