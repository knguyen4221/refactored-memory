﻿namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class CloseCycle
    {
        public string CycleCode { get; set; }
        public string GatewayResult { get; set; }
        public uint GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
        public string TransactionCode { get; set; }
        public string ResponseType { get; set; }
        public string MerchantAccountCode { get; set; }
    }
}
