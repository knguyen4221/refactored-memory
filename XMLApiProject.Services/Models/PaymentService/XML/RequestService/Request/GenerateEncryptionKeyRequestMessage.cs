using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class GenerateEncryptionKeyRequestMessage : RequestMessageBase
    {

        public GenerateEncryptionKeyRequestMessage() { }

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
