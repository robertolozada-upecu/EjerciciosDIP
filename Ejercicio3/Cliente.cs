namespace EjerciciosDIP.Ejercicio3
{
    public class Cliente : IPedidoCliente
    {
        private void Pagar() { }
        private void RecibirCafe() { }

        public void CrearOrden()
        {
            Pagar();
        }
        public void RecibirOrden()
        {
            RecibirCafe();
        }
    }
}