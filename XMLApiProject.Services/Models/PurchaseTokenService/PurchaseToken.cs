using System;

namespace XMLApiProject.Services.Models.PurchaseTokenService
{
    public class PurchaseToken
    {
        public string PurchaserInfo { get; set; }
        public string TransactionInfo { get; set; }
        public DateTime IssuedDate { get; set; }

        public string Value { get; set; }
    }
}
