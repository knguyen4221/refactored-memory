using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PurchaseTokenService
{
    public class PurchaseToken
    {
        public string PurchaserInfo { get; set; }
        public string TransactionInfo { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public string Value { get; set; }
    }
}
