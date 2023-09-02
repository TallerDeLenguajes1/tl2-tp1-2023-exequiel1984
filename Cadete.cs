namespace Practico1
{
    public class Cadete
    {
        private int id;
        private string? nombre;
        private string? direccion;
        private string? telefono;
        private List<Pedidos> listadoPedidosCadete = new List<Pedidos>();

        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public string? Telefono { get => telefono; set => telefono = value; }
        public List<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }

        public Cadete(string[] DatosCadete){
            this.Id = Convert.ToInt32(DatosCadete[0]);
            this.Nombre = DatosCadete[1];
            this.Direccion = DatosCadete[2];
            this.Telefono = DatosCadete[3];
            List<Pedidos> ListadoPedidosCadete = new List<Pedidos>();
        }

        public void CrearPedidoEnCadete(int NroPedido, string? ObsPedido, string? NombreCliente, string? DireccionCliente, string? TelefonoCliente, string? DatosReferenciaDireccionCliente){
            
            Pedidos NuevoPedido = new Pedidos(NroPedido, ObsPedido);
            listadoPedidosCadete.Add(NuevoPedido);
            NuevoPedido.CrearPedidoEnPedidos(NuevoPedido, NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
        }

        public float JornalACobrar(){
            int CantidadDePedidosEntregados = 0;
            float MontoPorPedido = 500;
            float Total;
            foreach (Pedidos Pedido in ListadoPedidosCadete)
            {
                if (Pedido.Estado == Estados.Entregado)
                {
                    CantidadDePedidosEntregados++;
                }
            }
            Total = CantidadDePedidosEntregados * MontoPorPedido;
            return Total;
        }
    }
}