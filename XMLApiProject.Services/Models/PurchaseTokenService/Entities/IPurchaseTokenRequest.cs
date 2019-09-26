namespace XMLApiProject.Services.Models.PurchaseTokenService.Entities
{
    public interface IPurchaseTokenRequest
    {
        string CertificationId { get; set; }
        int TransactionAmount { get; set; }
        string PurchaserInfo { get; set; }
        string TransactionInfo { get; set; }
    }
}
