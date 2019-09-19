using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class Find
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public string RoutingNumber { get; set; }
        public Guid PurchaseToken { get; set; }
        public string ApprovalCode { get; set; }
        public string CSCResponseCode { get; set; }
        public uint GatewayTransId { get; set; }
        public string HolderName { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionCategory { get; set; }
        public uint Amount { get; set; }
        public string AVSResponseCode { get; set; }
        public uint Balance { get; set; }
        public string Email { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string HolderType { get; set; }
        public string AccountType { get; set; }
        public string City { get; set; }
        public string Memo { get; set; }
        public uint OriginalAmount { get; set; }
        public string Phone { get; set; }
        public string Token { get; set; }
        public string AccountNumberMasked { get; set; }
        public string CountryCode { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string TransactionIndustryType { get; set; }
        public string TransactionType { get; set; }
        public string ZipCode { get; set; }
        public string PersistedDate { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDescription { get; set; }
    }
}
