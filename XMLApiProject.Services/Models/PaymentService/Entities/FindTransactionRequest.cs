using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class FindTransactionRequest
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public string TransactionCode { get; set; }
        public uint? GatewayTransID { get; set; }
        public Guid? PurchaseToken { get; set; }
        public string InvoiceNum { get; set; }
    }
}
