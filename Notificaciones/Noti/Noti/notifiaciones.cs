using System;

namespace Noti
{
    public interface Notificacion
    {
        void Notifica(string mensaje);
    }

    
    public class NotificacionEmail : Notificacion
    {
        private string direccionCorreo;

        public NotificacionEmail(string correo)
        {
            direccionCorreo = correo;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Enviando correo electrónico a {direccionCorreo}: {mensaje}");

        }
    }
    public class NotificacionWhatsApp : Notificacion
    {
        private string numeroTelefono;

        public NotificacionWhatsApp(string telefono)
        {
            numeroTelefono = telefono;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
        }


    }
    public class NotificacionSMS : Notificacion
    {
        private string numeroTelefono;

        public NotificacionSMS(string telefono)
        {
            numeroTelefono = telefono;
        }

        public void Notifica(string mensaje)
        {
            Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
        }
    }

    public class NotificadorFactory
    {
        public static Notificacion CrearNoti(string tipo, string contacto)
        {
            switch (tipo.ToLower())
            {
                case "email":
                    return new NotificacionEmail(contacto);
                case "whatsapp":
                    return new NotificacionWhatsApp(contacto);
                case "sms":
                    return new NotificacionSMS(contacto);
                default:
                    throw new ArgumentException("¡Este tipo de notificacion no es valida!");
            }
        }
    }
}
