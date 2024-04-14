namespace Noti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificacion notificadorEmail = NotificadorFactory.CrearNoti("email", "cristianchamo0606@gmail.com");
            Notificacion notificadorWhatsApp = NotificadorFactory.CrearNoti("whatsapp", "+502 50148850");
            Notificacion notificadorSMS = NotificadorFactory.CrearNoti("sms", "+502 50148850");

            notificadorEmail.Notifica("Mensaje para el correo electronico");
            notificadorWhatsApp.Notifica("Mensaje para el numero de WhatsApp");
            notificadorSMS.Notifica("Mensaje SMS para el numero de telefono");

        }
    }
}
