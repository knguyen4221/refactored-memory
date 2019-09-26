namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class Capture
    {
        public string ReferenceNumber { get; set; }
        public string GatewayResult { get; set; }
        public string GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
        public string TransactionCode { get; set; }
        public string ResponseType { get; set; }
        public string MerchantAccountCode { get; set; }

        public Capture() { }
    }
}
