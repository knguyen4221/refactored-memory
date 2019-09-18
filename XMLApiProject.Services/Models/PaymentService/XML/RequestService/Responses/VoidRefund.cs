using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class VoidRefund
    {
        public string ReferenceNumber { get; set; }
        public string TransactionCode { get; set; }
        public uint RemainingAmount { get; set; }
        public string MerchantAccountCode { get; set; }
        public string CardType { get; set; }
    }
}
