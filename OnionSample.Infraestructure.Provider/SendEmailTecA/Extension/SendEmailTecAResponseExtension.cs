using OnionSample.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using OnionSample.Infraestructure.Provider.SendEmailTecA.Model;

namespace OnionSample.Infraestructure.Provider.SendEmailTecA.Extension
{
    public static class SendEmailTecAResponseExtension
    {
        public static SendEmailResponse ToDTO(this SendEmailResponseTecA sendEmailTecAResponse)
        {
            return new SendEmailResponse()
            {
                Date = sendEmailTecAResponse.Date,
                Sent = sendEmailTecAResponse.Sent
            };
        }
    }
}
