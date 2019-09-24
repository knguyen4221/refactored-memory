using System;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class FindTransactionRequest: IFindTransactionRequest
    {
        [DefaultValue("12137000")]
        public string MerchantCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantAccountCode { get; set; }
        [DefaultValue(null)]
        public string TransactionCode { get; set; }
        [DefaultValue(3715542104)]
        public uint? GatewayTransID { get; set; }
        [DefaultValue(null)]
        public Guid? PurchaseToken { get; set; }
        [DefaultValue(null)]
        public string InvoiceNum { get; set; }
    }
}
