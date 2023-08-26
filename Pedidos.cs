namespace Practico1
{
    public class Pedidos
    {
        private int? nro;
        private string? obs;
        private Cliente? clientePedido;
        private string? estado;

        public int? Nro { get => nro; set => nro = value; }
        public string? Obs { get => obs; set => obs = value; }
        public Cliente? ClientePedido { get => clientePedido; set => clientePedido = value; }
        public string? Estado { get => estado; set => estado = value; }

        public Pedidos(int nroPedido, string obsPedido, Cliente costumerPedido, string estadoPedido)
        {
            this.Nro = nroPedido;
            this.Obs = obsPedido;
            this.ClientePedido = costumerPedido;
            this.Estado = estadoPedido;
        }
    }
}