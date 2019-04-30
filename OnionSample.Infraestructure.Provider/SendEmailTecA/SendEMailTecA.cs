using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnionSample.Domain.DataTransferObject;
using OnionSample.Infraestructure.Provider.SendEmailTecA.Model;
using OnionSample.Infraestructure.Provider.SendEmailTecA.Extension;

namespace OnionSample.Infraestructure.Provider.SendEmailTecA
{
    public class SendEMailTecA : ISendEmailProvider
    {
        public async Task<SendEmailResponse> SendEmailAsync(string from, string to)
        {
            var response = new SendEmailResponseTecA()
            {
                Date = DateTime.Now,
                ElapsedTime = TimeSpan.MaxValue,
                Sent = true
            };

            return response.ToDTO();
        }
    }
}
