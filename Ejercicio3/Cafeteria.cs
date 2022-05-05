namespace EjerciciosDIP.Ejercicio3
{
    public class Cafeteria : IVentaCafeteria
    {
        private void ObtenerPago() { }
        private void DespacharCafe() { }

        public void DespacharOrden()
        {
            ObtenerPago();
            DespacharCafe();
            CalentarAgua();
        }

        private void CalentarAgua() { }
    }
}