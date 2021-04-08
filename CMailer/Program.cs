using System;
using System.Net;
using System.Net.Mail;

namespace CMailer
{
    class Program
    {
        static void Main(string[] args)
        {
            var smtpClient = new SmtpClient("server adress") // server adress
            {
                Port = 587,
                Credentials = new NetworkCredential("email", "password"), // email and password account
                EnableSsl = true,
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("email"), // sender email
                Subject = "TEST",
                Body = "<h1>TEST</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add("email"); // reciver email

            smtpClient.Send(mailMessage);
        }
    }
}
