using System.ComponentModel.DataAnnotations;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class BINLookupRequestMessage: RequestMessageBase
    {
        [StringLength(11)]
        public string BIN { get; set; }

        public BINLookupRequestMessage()
        {
        }

        public BINLookupRequestMessage(string bin)
        {
            BIN = bin;
        }

        public BINLookupRequestMessage(IBINRequest request)
        {
            BIN = request.BIN;
        }

        public override string GetResponseRootName()
        {
            return nameof(BINLookup);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<BINLookupRequestMessage>();
        }
    }
}
