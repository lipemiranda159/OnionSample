using OnionSample.Domain.DataTransferObject;
using OnionSample.Domain.Service.Interfaces;
using OnionSample.Infraestructure.Provider;
using System;
using System.Threading.Tasks;

namespace OnionSample.Application.Service
{
    public class SendEmailService : ISendEmailService
    {
        private readonly ISendEmailProvider _sendEmailProvider;
        public SendEmailService(ISendEmailProvider sendEmailProvider)
        {
            _sendEmailProvider = sendEmailProvider;
        }
        public async Task SendEmailAsync(SendEmailRequest sendEmailRequest)
        {
            var result = await _sendEmailProvider.SendEmailAsync(sendEmailRequest.From, sendEmailRequest.To);
            if (!result.Sent)
            {
                throw new Exception("Error to send email");
            }
        }
    }
}
