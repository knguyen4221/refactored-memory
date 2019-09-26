using System;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class BalanceInquiryRequest: IBalanceInquiryRequest
    {
        public string PaymentAccountNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string HolderType { get; set; }
        public string TransIndustryType { get; set; }
        public DateTime TransactionDate { get; set; }
        public string MerchantAccountCode { get; set; }
        public string MerchantCode { get; set; }
        public string AccountHolderName { get; set; }
    }
}
