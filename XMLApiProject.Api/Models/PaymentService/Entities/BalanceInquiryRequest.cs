using System;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class BalanceInquiryRequest: IBalanceInquiryRequest
    {
        [DefaultValue("4111111111111111")]
        public string PaymentAccountNumber { get; set; }
        [DefaultValue("2025-10-27T18:30:36.336Z")]
        public DateTime ExpirationDate { get; set; }
        [DefaultValue("P")]
        public string HolderType { get; set; }
        [DefaultValue("RE")]
        public string TransIndustryType { get; set; }
        public DateTime TransactionDate { get; set; }
        [DefaultValue("12137000")]
        public string MerchantCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantAccountCode { get; set; }
        [DefaultValue("John Smith")]
        public string AccountHolderName { get; set; }
    }
}
