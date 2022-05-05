namespace EjerciciosDIP.Ejercicio1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var importadorReporteBDD = new ImportadorReporteBDD();
            var presentadorReporte = new PresentadorReporte(importadorReporteBDD);
            presentadorReporte.MostrarReporte();

            //Mostrar datos desde excel
            var importadorReporteExcel = new ImportadorReporteExcel();
            presentadorReporte = new PresentadorReporte(importadorReporteExcel);
            presentadorReporte.MostrarReporte();
        }
    }
}