using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class BalanceInquiryRequest
    {
        public string PaymentAccountNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string HolderType { get; set; }
        public string TransIndustryType { get; set; }
        public DateTime TransactionDate { get; set; }
        public uint MerchantAccountCode { get; set; }
        public uint MerchantCode { get; set; }
    }
}
