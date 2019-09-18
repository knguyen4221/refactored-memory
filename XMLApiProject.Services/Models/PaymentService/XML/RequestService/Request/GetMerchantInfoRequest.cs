using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GetMerchantInfoRequest: RequestMessageBase
    {
        public string PurchaseToken { get; set; }

        public GetMerchantInfoRequest()
        {
        }

        public GetMerchantInfoRequest(string purchaseToken)
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
    }
}
