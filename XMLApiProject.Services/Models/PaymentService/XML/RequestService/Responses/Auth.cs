using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class Auth
    {
        #region Properties
        public string Token { get; set; }
        public string AuthorizationCode { get; set; }
        public string ReferenceNumber { get; set; }
        public string GatewayResult { get; set; }
        public uint AuthorizedAmount { get; set; }
        public uint OriginalAmount { get; set; }
        public string ExpirationDate { get; set; }
        public string AVSResult { get; set; }
        public string AVSMessage { get; set; }
        public string StreetMatchMessage { get; set; }
        public string ZipMatchMessage { get; set; }
        public string CVResult { get; set; }
        public string CVMessage { get; set; }
        public bool IsCommericalCard { get; set; }
        public uint GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
        public string InternalMessage { get; set; }
        public uint Balance { get; set; }
        public uint CashBackAmount { get; set; }
        public string TransactionCode { get; set; }
        public string TransactionDate { get; set; }
        public string CardClass { get; set; }
        public string CardType { get; set; }
        public string CardModifier { get; set; }
        public string CardHolderName { get; set; }
        public string ProviderResponseCode { get; set; }
        public string ProviderResponseMEssage { get; set; }
        public uint RemainingAmount { get; set; }
        public string IsoCountryCode { get; set; }
        public string IsoCurrencyCode { get; set; }
        public string IsoTransactionDate { get; set; }
        public string IsoRequestDate { get; set; }
        public string NetworkReferenceNumber { get; set; }
        public string NetworkMerchantId { get; set; }
        public string NetworkTerminalid { get; set; }
        public string MaskedPan { get; set; }
        public string WalletID { get; set; }
        public string WalletPaymentMethodID { get; set; }
        public string WalletResponseMessage { get; set; }
        public string WalletResponseCode { get; set; }
        public string ResponseTypeDescription { get; set; }
        public string MerchantCategoryCode { get; set; }
        #region EMVData returns
        public string ReceiptTagData { get; set; }
        public string IssuerTagData { get; set; }
        #endregion
        #endregion

        public Auth() { }
    }
}
