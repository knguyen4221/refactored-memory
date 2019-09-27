namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IAuthorizeSwipeRequest
    {
        uint? MerchantCode { get; set; }
        uint? MerchantAccountCode { get; set; }
        uint Amount { get; set; }
        string TransIndustryType { get; set; }
        string TransactionType { get; set; }
        string TransCatCode { get; set; }
        string Track1 { get; set; }
        string Track2 { get; set; }
        string AcctType { get; set; }
        string HolderType { get; set; }
        uint? InvoiceNum { get; set; }
        uint? FeeAmount { get; set; }
        uint? TipAmount { get; set; }
        string EntryMode { get; set; }
        string EntryMediumType { get; set; }
        string EntryPINModeType { get; set; }
    }
}
