using System;
using System.Collections.Generic;
using System.Text;

namespace OnionSample.Infraestructure.Provider.SendEmailTecA.Model
{
    public class SendEmailResponseTecA
    {

        public bool Sent { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan ElapsedTime { get; set; }

    }
}
