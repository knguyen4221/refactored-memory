using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Interfaces;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class PingRequest : IXmlRequestTranslatable
    {
        //NOte: Ping requests are empty according to API documentation!
        public RawRequestMessageString ToXmlRequestString()
        {
            return new RawRequestMessageString(string.Empty);
        }
    }
}
