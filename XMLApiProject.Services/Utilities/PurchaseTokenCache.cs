using PurchaseTokenService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PurchaseTokenService;

namespace XMLApiProject.Services.Utilities
{
    public class PurchaseTokenCache: ActionServiceClient
    {
        private Dictionary<string, PurchaseToken> _cache { get; set; }

        public PurchaseTokenCache(): base()
        {
            _cache = new Dictionary<string, PurchaseToken>();
        }

        public async Task<PurchaseToken> GetTokenAsync(string userName, string password, string certificationId, int transactionAmount, string purchaserInfo, string transactionInfo)
        {
            PurchaseToken token;

            if (_cache.ContainsKey(purchaserInfo))
            {
                token = _cache[purchaserInfo];
                if (token.ExpirationDate < DateTime.Now)
                {
                    _cache.Remove(purchaserInfo);
                    token = await GetTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo);
                }
            }
            else
            {
                token = new PurchaseToken
                {
                    Value = await AcquirePurchaseTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo),
                    IssuedDate = DateTime.Now,
                    PurchaserInfo = purchaserInfo
                };

                token.ExpirationDate = token.IssuedDate.AddMinutes(15);
                if (!string.IsNullOrEmpty(token.Value))
                {
                    _cache.Add(purchaserInfo, token);
                }
            }

            return token;
        }

        //What return type for GetAndConsume?
        //public async Task<PurchaseToken> GetAndConsumeTokenAsync(string userName, string password, string certificationId, string transactionAmount, string purchaserInfo, string transactionInfo)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
