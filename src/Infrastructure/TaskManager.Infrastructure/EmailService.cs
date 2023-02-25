using TaskManager.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Infrastructure
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
