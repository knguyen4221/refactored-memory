namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface ITokenizeAccountRequest
    {
        string BankAccountNum { get; set; }
        string SoftwareVendor { get; set; }
    }
}
