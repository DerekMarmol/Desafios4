using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4_1
{
    internal class Desafio4_2
    {
        public interface INotificable
        {

            void Notifica(string mensaje);
        }

        public class NotificacionEmail : INotificable
        {

            public string DireccionCorreo { get; set; }


            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando correo a {DireccionCorreo}: {mensaje}");
            }
        }


        public class NotificacionWhatsapp : INotificable
        {

            public string NumeroTelefono { get; set; }


            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando mensaje de WhatsApp al número {NumeroTelefono}: {mensaje}");
            }
        }

        public class NotificacionSMS : INotificable
        {

            public string NumeroTelefono { get; set; }

            public void Notifica(string mensaje)
            {
                Console.WriteLine($"Enviando SMS al número {NumeroTelefono}: {mensaje}");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                NotificacionEmail emailNotif = new NotificacionEmail();
                emailNotif.DireccionCorreo = "ejemplo@correo.com";

                NotificacionWhatsapp whatsappNotif = new NotificacionWhatsapp();
                whatsappNotif.NumeroTelefono = "+123456789";

                NotificacionSMS smsNotif = new NotificacionSMS();
                smsNotif.NumeroTelefono = "+987654321";

                emailNotif.Notifica("¡Hola desde el correo electrónico!");
                whatsappNotif.Notifica("¡Hola desde WhatsApp!");
                smsNotif.Notifica("¡Hola desde un mensaje SMS!");
                Console.ReadLine();
            }
        }
    }
}
