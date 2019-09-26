using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IBalanceInquiryRequest
    {
        string PaymentAccountNumber { get; set; }
        DateTime ExpirationDate { get; set; }
        string HolderType { get; set; }
        string TransIndustryType { get; set; }
        DateTime TransactionDate { get; set; }
        string MerchantAccountCode { get; set; }
        string MerchantCode { get; set; }
        string AccountHolderName { get; set; }
    }
}
