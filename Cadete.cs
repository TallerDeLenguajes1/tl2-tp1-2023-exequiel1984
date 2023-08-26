namespace Practico1
{
    public class Cadete : Persona
    {
        private List<Pedidos> listadoPedidosCadete = new List<Pedidos>();

        public List<Pedidos> ListadoPedidosCadete { get => listadoPedidosCadete; set => listadoPedidosCadete = value; }
    }
}