using System;

namespace OnionSample.Domain.DataTransferObject
{
    public class SendEmailRequest
    {
        public string From { get; set; }
        public string To { get; set; }
    }
}
