using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    /// <summary>
    /// Get Token on our end for our REST endpoint
    /// </summary>
    public class GetTokenRequest
    {
        public string PaymentAccountNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
