using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class TokenizeAccountBody
    {
        public string BankAccountNum { get; set; }
        public string SoftwareVendor { get; set; }
    }
}
