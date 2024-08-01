using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AvisoPosTec.Model
{
    public class Aviso
    {
        public string Nome { get; set; }
        public string Email { get; private set; }
        public string Mensagem { get; private set; }


        private Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        public bool EmailValidado = false;

        public Aviso(string enderecoEmail, string nome) 
        { 
            Nome = nome.Trim();
            Email = enderecoEmail;
            EmailValidado = regex.IsMatch(enderecoEmail);
        }

        public void MontaMensagem(DateTime dataConsulta, int tipo, string? msgExterna)
        {
            if (msgExterna != null && tipo == 0)
                Mensagem = msgExterna;
            else if (tipo == 1)
                Mensagem = String.Format("Sr(a). {0}, sua consulta foi agendada para a data: {1}.", Nome, dataConsulta.ToString("dd/MM/yyyy HH:mm"));
            else if(tipo == 2)
                Mensagem = String.Format("Sr(a). {0}, sua consulta agendada para a data: {1} foi cancelada.", Nome, dataConsulta.ToString("dd/MM/yyyy HH:mm"));
            else
                Mensagem = String.Format("Sr(a). {0}, sua consulta foi reagendada para a data: {1}.", Nome, dataConsulta.ToString("dd/MM/yyyy HH:mm"));
        }
    }
}
