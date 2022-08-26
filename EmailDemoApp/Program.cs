using System;
using FluentEmail.Core;
using FluentEmail.Smtp;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net;

namespace EmailDemoApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Connect the server to sent email, here we use a test server
            var sender = new SmtpSender(() => new SmtpClient("smtp.mailtrap.io", 2525)
            {
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential("b84ad7480750e9", "557b3881e9785b")
            });

            // Set up the email
            Email.DefaultSender = sender;

            var email = await Email
                .From(emailAddress: "testfrom@lalala.nz")
                .To(emailAddress: "test@to.com", name: "Somebody")
                .Subject(subject: "Testing!")
                .Body(body: "Thanks for buying our product.")
                .SendAsync();
        }
    }
}
