using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class InitiateSettlementRequestMessage: RequestMessageBase
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }

        public InitiateSettlementRequestMessage()
        {

        }

        public InitiateSettlementRequestMessage(string merchantCode, string merchantAccountCode)
        {
            MerchantCode = merchantCode;
            MerchantAccountCode = merchantAccountCode;
        }

        public InitiateSettlementRequestMessage(IInitiateSettlementRequest request)
        {
            MerchantCode = request.MerchantCode;
            MerchantAccountCode = request.MerchantAccountCode;
        }

        public override string GetResponseRootName()
        {
            return nameof(CloseCycle);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<InitiateSettlementRequestMessage>();
        }
    }
}
