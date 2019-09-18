using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class VoidRefundRequest
    {
        public int MerchantCode { get; set; }
        public int MerchantAccountCode { get; set; }
        public int Amount { get; set; }
        public int ReferenceNumber { get; set; }
        public string TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public string SoftwareVendor { get; set; }
    }
}
