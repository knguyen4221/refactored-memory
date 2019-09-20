using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class TokenizeAccountRequest: ITokenizeAccountRequest
    {
        public string BankAccountNum { get; set; }
        public string SoftwareVendor { get; set; }
    }
}
