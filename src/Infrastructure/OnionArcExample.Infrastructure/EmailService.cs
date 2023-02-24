using OnionArcExample.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArcExample.Infrastructure
{
    public class EmailService : IEmailService
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine("mail sent");
            return true;
        }
    }
}
