using OnionSample.Domain.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Infraestructure.Provider
{
    public interface ISendEmailProvider
    {
        Task<SendEmailResponse> SendEmailAsync(string from, string to); 
    }
}
