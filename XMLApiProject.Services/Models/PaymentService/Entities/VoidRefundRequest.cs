using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class VoidRefundRequest
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public uint Amount { get; set; }
        public string ReferenceNumber { get; set; }
        public string TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public string SoftwareVendor { get; set; }
    }
}
