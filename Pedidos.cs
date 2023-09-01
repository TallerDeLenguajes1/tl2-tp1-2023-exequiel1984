public enum Estados
{
    Asignado,
    Entregado
}

namespace Practico1
{
    public class Pedidos
    {
        private int? nro;
        private string? obs;
        private Cliente? cliente;
        private Estados estado;

        public int? Nro { get => nro; set => nro = value; }
        public string? Obs { get => obs; set => obs = value; }
        public Cliente? Cliente { get => cliente; set => cliente = value; }
        public Estados Estado { get => estado; set => estado = value; }

        public Pedidos(int Nro, string? Obs)
        {
            this.Nro = Nro;
            this.Obs = Obs;
            this.Estado = Estados.Asignado;
        }

        public void CrearPedidoEnPedidos(Pedidos NuevoPedido){
            System.Console.WriteLine("*****CARGAR DATOS DEL CLIENTE*****");
            System.Console.WriteLine("Ingrese el nombre:");
            string? NombreCliente = Console.ReadLine();
            System.Console.WriteLine("Ingrese la direccion:");
            string? DireccionCliente = Console.ReadLine();
            System.Console.WriteLine("Ingrese el telefono:");
            string? TelefonoCliente = Console.ReadLine();
            System.Console.WriteLine("Ingrese los datos de referencia de la direccion:");
            string? DatosReferenciaDireccionCliente = Console.ReadLine(); 
        
            Cliente NuevoCliente = new Cliente(NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
        }
    }
}