using System.Collections.Generic;

namespace EjerciciosDIP.Ejercicio2
{
    public class Notificacion
    {
        private readonly List<INotificacion> _notificaciones;

        public Notificacion(List<INotificacion> notificaciones)
        {
            _notificaciones = notificaciones;
        }

        public void Enviar()
        {
            foreach (var notificacion in _notificaciones)
            {
                notificacion.Enviar();
            }
        }
    }
}