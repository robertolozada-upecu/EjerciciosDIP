namespace EjerciciosDIP.Ejercicio3
{
    public class EntregaDomicilio
    {
        private IPedidoCliente _cliente;
        private IVentaCafeteria _cafeteria;

        public EntregaDomicilio()
        {
            _cliente = new Cliente();
            _cafeteria = new Cafeteria();
        }

        public void EntregarDomicilio()
        {
            _cliente.CrearOrden();
            _cafeteria.DespacharOrden();
            _cliente.RecibirOrden();
        }
    }
}