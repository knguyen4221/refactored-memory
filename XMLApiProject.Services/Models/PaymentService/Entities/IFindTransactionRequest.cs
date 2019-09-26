using System;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IFindTransactionRequest
    {
        string MerchantCode { get; set; }
        string MerchantAccountCode { get; set; }
        string TransactionCode { get; set; }
        uint? GatewayTransID { get; set; }
        Guid? PurchaseToken { get; set; }
        string InvoiceNum { get; set; }
    }
}
