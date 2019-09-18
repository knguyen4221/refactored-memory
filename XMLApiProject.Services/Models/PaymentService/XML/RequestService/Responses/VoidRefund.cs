using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class VoidRefund
    {
        public int ReferenceNumber { get; set; }
        public string TransactionCode { get; set; }
        public int RemainingAmount { get; set; }
        public int MerchantAccountCode { get; set; }
        public string CardType { get; set; }
    }
}
