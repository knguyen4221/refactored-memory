using System;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class FindTransactionRequest: IFindTransactionRequest
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public string TransactionCode { get; set; }
        public uint? GatewayTransID { get; set; }
        public Guid? PurchaseToken { get; set; }
        public string InvoiceNum { get; set; }
    }
}
