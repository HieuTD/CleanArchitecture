using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Models;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public interface IEmailService
    {
        void SendEmail(Email emailService);
    }
}
