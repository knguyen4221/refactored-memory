using System;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GetMerchantInfoRequestMessage: RequestMessageBase
    {
        public Guid? PurchaseToken { get; set; }

        public GetMerchantInfoRequestMessage()
        {
        }

        public GetMerchantInfoRequestMessage(Guid? purchaseToken)
        {
            PurchaseToken = purchaseToken;
        }

        public override string GetResponseRootName()
        {
            return nameof(MerchantInfo);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<GetMerchantInfoRequestMessage>();
        }

        public bool ShouldSerializePurchaseToken()
        {
            return PurchaseToken.HasValue;
        }
    }
}
