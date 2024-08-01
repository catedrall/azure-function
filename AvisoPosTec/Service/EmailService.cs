using AvisoPosTec.Interface;
using AvisoPosTec.Model;
using Microsoft.Extensions.Configuration;
using SendGrid.Helpers.Mail;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisoPosTec.Service
{
    public class EmailService : IEmailService
    {
        public async Task<string> EnviaEmail(Aviso aviso)
        {
            return "Erro ao enviar e-mail";
        }
    }
}
