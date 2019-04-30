using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionSample.Domain.DataTransferObject;
using OnionSample.Domain.Service.Interfaces;

namespace OnionSample.Ui.Api.Controllers
{
    [Route("SendEmail")]
    [ApiController]
    public class SendEmailController : ControllerBase
    {
        private readonly ISendEmailService _sendEmailService;

        public SendEmailController(ISendEmailService sendEmailService)
        {
            _sendEmailService = sendEmailService;
        }

        [HttpPost]
        public async Task<ActionResult> SendEmail([FromBody]SendEmailRequest sendEmailRequest)
        {
            await _sendEmailService.SendEmailAsync(sendEmailRequest);
            return Ok();
        }
    }
}