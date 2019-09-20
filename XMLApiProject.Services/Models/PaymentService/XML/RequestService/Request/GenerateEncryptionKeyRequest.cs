using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GenerateEncryptionKeyRequest : RequestMessageBase
    {
        public override string GetResponseRootName()
        {
            return nameof(EncryptionKey);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return new RawRequestMessageString(string.Empty);
        }
    }
}
