using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class BINLookupRequest: RequestMessageBase
    {
        public string BIN { get; set; }

        public BINLookupRequest()
        {
        }

        public BINLookupRequest(string bin)
        {
            BIN = bin;
        }

        public BINLookupRequest(BINRequest request)
        {
            BIN = request.BIN;
        }

        public override string GetResponseRootName()
        {
            return nameof(BINLookup);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<BINLookupRequest>();
        }
    }
}
