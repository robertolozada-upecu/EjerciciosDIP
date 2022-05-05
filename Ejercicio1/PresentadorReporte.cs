using System;

namespace EjerciciosDIP.Ejercicio1
{
    public class PresentadorReporte
    {
        private readonly IImportadorDatos _importadorDatos;


        public PresentadorReporte(IImportadorDatos importadorDatos)
        {
            _importadorDatos = importadorDatos;
        }

        public void MostrarReporte()
        {
            Console.WriteLine(_importadorDatos.ObtenerDatosReporte());
        }
    }
}