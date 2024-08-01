using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AvisoPosTec.DTO;
using AvisoPosTec.Service;
using AvisoPosTec.Interface;
using AvisoPosTec.Model;

namespace AvisoPosTec
{
    public static class Function1
    {

        [FunctionName("AvisoEmail")]
        public static async Task<IActionResult> EnviaAviso(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "Aviso")] DadosConsultaDTO req, ILogger log) 
        {
            log.LogInformation("Envio de e-mail para confirmação de agendamento de consulta");
            EmailService service = new EmailService();
            Aviso aviso = new Aviso(req.Email, req.Nome);
            aviso.MontaMensagem(req.Data, req.Tipo, req.MensagemCorpo);
            return new OkObjectResult(await service.EnviaEmail(aviso));
        }
    }
}
