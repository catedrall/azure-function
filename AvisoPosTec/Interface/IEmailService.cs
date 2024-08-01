using AvisoPosTec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisoPosTec.Interface
{
    public interface IEmailService
    {
        Task<string> EnviaEmail(Aviso aviso);
    }
}
