using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface ITokenizeAccountRequest
    {
        string BankAccountNum { get; set; }
        string SoftwareVendor { get; set; }
    }
}
