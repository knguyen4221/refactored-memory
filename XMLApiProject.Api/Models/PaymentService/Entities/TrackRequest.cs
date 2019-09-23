using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class TrackRequest: IAuthorizeSwipe
    {
        public uint? MerchantCode { get; set; }
        public uint? MerchantAccountCode { get; set; }
        public uint Amount { get; set; }
        public string TransIndustryType { get; set; }
        public string TransactionType { get; set; }
        public string TransCatCode { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string AcctType { get; set; }
        public string HolderType { get; set; }
        public uint? InvoiceNum { get; set; }
        public uint? FeeAmount { get; set; }
        public uint? TipAmount { get; set; }
        public string EntryMode { get; set; }
        public string EntryMediumType { get; set; }
        public string EntryPINModeType { get; set; }
    }
}
