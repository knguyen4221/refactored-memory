using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class BINLookupRequest: RequestMessageBase
    {
        public int BIN { get; set; }

        public BINLookupRequest()
        {
        }

        public BINLookupRequest(int bin)
        {
            BIN = bin;
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
