namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    //TODO: Support for custom fields
    public interface IAuthorizationRequest
    {
        uint? MerchantCode { get; set; }
        uint? MerchantAccountCode { get; set; }
        uint Amount { get; set; }
        string ExpirationDate { get; set; }
        string TransIndustryType { get; set; }
        string TransactionType { get; set; }
        string TransCatCode { get; set; }
        string AcctType { get; set; }
        string HolderType { get; set; }
        uint? InvoiceNum { get; set; }
        uint? FeeAmount { get; set; }
        uint? TipAmount { get; set; }
        uint? SecurityCode { get; set; }
        string PaymentAccountNumber { get; set; }
        string AccountHolderName { get; set; }
        string AccountStreet { get; set; }
        string AccountZip { get; set; }
        string PONum { get; set; }
        string CustomerAccountCode { get; }
        uint? ContractId { get; set; }
        string Token { get; set; }
        uint? SettlementDelay { get; set; }
        string PartialAuthorization { get; set; }
    }
}
