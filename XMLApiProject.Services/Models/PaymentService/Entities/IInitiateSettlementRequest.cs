namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IInitiateSettlementRequest
    {
        string MerchantCode { get; set; }
        string MerchantAccountCode { get; set; }
    }
}
