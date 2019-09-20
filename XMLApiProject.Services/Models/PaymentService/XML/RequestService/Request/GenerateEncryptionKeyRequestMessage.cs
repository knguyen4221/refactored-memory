using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GenerateEncryptionKeyRequestMessage : RequestMessageBase
    {

        public string MerchantAccountCode { get; set; }
        public string MerchantCode { get; set; }

        public GenerateEncryptionKeyRequestMessage() { }
        public GenerateEncryptionKeyRequestMessage(string merchantAccountCode, string merchantCode)
        {
            MerchantAccountCode = merchantAccountCode;
            MerchantCode = merchantCode;
        }

        public override string GetResponseRootName()
        {
            return nameof(EncryptionKey);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<GenerateEncryptionKeyRequestMessage>();
        }
    }
}
