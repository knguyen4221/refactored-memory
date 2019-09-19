using System;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GetMerchantInfoRequest: RequestMessageBase
    {
        public Guid? PurchaseToken { get; set; }

        public GetMerchantInfoRequest()
        {
        }

        public GetMerchantInfoRequest(Guid? purchaseToken)
        {
            PurchaseToken = purchaseToken;
        }

        public override string GetResponseRootName()
        {
            return nameof(MerchantInfo);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<GetMerchantInfoRequest>();
        }

        public bool ShouldSerializePurchaseToken()
        {
            return PurchaseToken.HasValue;
        }
    }
}
