using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using ReaderyMVC.Models;

using System.Net.Mail;
using System.Net; // Necessário se você for usar NetworkCredential para autenticação SMTP


namespace ReaderyMVC.Services
{
    public class EmailService
    {
        public readonly string _emailDestino;
        public int CodigoGerado{get;private set;}

        public EmailService(string ContrutorEmailDestino)
        {
            _emailDestino = ContrutorEmailDestino;
            CodigoGerado = new Random().Next(10000,999999);
        } 

        public async Task  EnviarEmail()
        {
            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential("readery3@gmail.com", MandarEmail.ENV.senha)
            };

            var email = new MailMessage("readery3@gmail.com", _emailDestino)
            {
                Subject = "Código para alterar senha",
                Body = $"Seu código para redefinir a senha é: {CodigoGerado}",
                IsBodyHtml = false
            };

            await smtp.SendMailAsync(email);
        }
    }
    }
