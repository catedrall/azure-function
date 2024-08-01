using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisoPosTec.DTO
{
    public class DadosConsultaDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public int Tipo { get; set; }
        public string? MensagemCorpo { get; set; }
    }
}
