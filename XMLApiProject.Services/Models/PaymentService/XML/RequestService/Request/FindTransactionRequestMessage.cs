using System;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class FindTransactionRequestMessage : RequestMessageBase
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public string TransactionCode { get; set; }
        public uint? GatewayTransID { get; set; }
        public Guid? PurchaseToken { get; set; }
        public string InvoiceNum { get; set; }

        public FindTransactionRequestMessage()
        {
        }

        public FindTransactionRequestMessage(string merchantCode, string merchantAccountCode, string transactionCode, uint? gatewayTransID, Guid? purchaseToken, string invoiceNum)
        {
            MerchantCode = merchantCode;
            MerchantAccountCode = merchantAccountCode;
            TransactionCode = transactionCode;
            GatewayTransID = gatewayTransID;
            PurchaseToken = purchaseToken;
            InvoiceNum = invoiceNum;
        }

        public FindTransactionRequestMessage(IFindTransactionRequest request)
        {
            MerchantCode = request.MerchantCode;
            MerchantAccountCode = request.MerchantAccountCode;
            TransactionCode = request.TransactionCode;
            GatewayTransID = request.GatewayTransID;
            PurchaseToken = request.PurchaseToken;
            InvoiceNum = request.InvoiceNum;
        }

        public override string GetResponseRootName()
        {
            return nameof(Find);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<FindTransactionRequestMessage>();
        }

        public bool ShouldSerializeGatewayTransID()
        {
            return GatewayTransID.HasValue;
        }

        public bool ShouldSerializePurchaseToken()
        {
            return PurchaseToken.HasValue;
        }
    }
}
