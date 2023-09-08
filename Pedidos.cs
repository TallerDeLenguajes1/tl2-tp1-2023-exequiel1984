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
        private int idCadete;

        public int? Nro { get => nro; set => nro = value; }
        public string? Obs { get => obs; set => obs = value; }
        public Cliente? Cliente { get => cliente; set => cliente = value; }
        public Estados Estado { get => estado; set => estado = value; }
        public int IdCadete { get => idCadete; set => idCadete = value; }

        public Pedidos(){
            
        }

        public Pedidos(int Nro, string? Obs)
        {
            this.Nro = Nro;
            this.Obs = Obs;
            this.Estado = Estados.Asignado;
        }

        public void CrearPedidoEnPedidos(Pedidos NuevoPedido, string? NombreCliente, string? DireccionCliente, string? TelefonoCliente, string? DatosReferenciaDireccionCliente){

            Cliente NuevoCliente = new Cliente(NombreCliente, DireccionCliente, TelefonoCliente, DatosReferenciaDireccionCliente);
            NuevoPedido.Cliente = NuevoCliente;
        }

        public string? VerDireccionCliente(){
            return Cliente?.Direccion;
        }

        public void VerDatosCliente(){
            System.Console.WriteLine("*****DATOS DEL CLIENTE*****");
            System.Console.WriteLine($"Nombre: {Cliente?.Nombre}");
            System.Console.WriteLine($"Direccion: {Cliente?.Direccion}");
            System.Console.WriteLine($"Telefono: {Cliente?.Telefono}");
            System.Console.WriteLine($"Datod de referencia de la direccion: {Cliente?.DatosReferenciaDireccion}");
        }
    }
}