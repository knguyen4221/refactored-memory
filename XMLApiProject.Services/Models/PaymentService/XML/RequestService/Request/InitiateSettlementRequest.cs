using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class InitiateSettlementRequest: RequestMessageBase
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }

        public InitiateSettlementRequest()
        {

        }

        public InitiateSettlementRequest(string merchantCode, string merchantAccountCode)
        {
            MerchantCode = merchantCode;
            MerchantAccountCode = merchantAccountCode;
        }

        public InitiateSettlementRequest(InitiateSettlementBody request)
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
            return ToXmlRequestString<InitiateSettlementRequest>();
        }
    }
}
