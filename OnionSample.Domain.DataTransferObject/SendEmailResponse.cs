using System;
using System.Collections.Generic;
using System.Text;

namespace OnionSample.Domain.DataTransferObject
{
    public class SendEmailResponse
    {
        public bool Sent { get; set; }
        public DateTime Date { get; set; }
    }
}
