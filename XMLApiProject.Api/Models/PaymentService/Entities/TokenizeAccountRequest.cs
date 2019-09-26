using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class TokenizeAccountRequest: ITokenizeAccountRequest
    {
        [DefaultValue("4099999992")]
        public string BankAccountNum { get; set; }
        [DefaultValue("BridgePay")]
        public string SoftwareVendor { get; set; }
    }
}
