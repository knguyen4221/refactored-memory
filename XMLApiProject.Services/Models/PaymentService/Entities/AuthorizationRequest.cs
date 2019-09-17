using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class AuthorizationRequest
    {
        public uint? MerchantCode { get; set; }
        public uint? MerchantAccountCode { get; set; }
        public uint Amount { get; set; }
        public string ExpirationDate { get; set; }
        public string TransIndustryType { get; set; }
        public string TransactionType { get; set; }
        public string TransCatCode { get; set; }
        public string AcctType { get; set; }
        public string HolderType { get; set; }
        public uint? InvoiceNum { get; set; }
        public uint? FeeAmount { get; set; }
        public uint? TipAmount { get; set; }
        public uint? SecurityCode { get; set; }
        public string PaymentAccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountStreet { get; set; }
        public string AccountZip { get; set; }
        public string PONum { get; set; }
        public string CustomerAccountCode { get; internal set; }
    }
}
