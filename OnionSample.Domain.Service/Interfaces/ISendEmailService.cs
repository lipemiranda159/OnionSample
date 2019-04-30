using OnionSample.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Domain.Service.Interfaces
{
    public interface ISendEmailService
    {
        Task SendEmailAsync(SendEmailRequest sendEmailRequest);
    }
}
