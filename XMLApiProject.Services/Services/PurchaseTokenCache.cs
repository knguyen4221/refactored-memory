using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PurchaseTokenService;
using XMLApiProject.Services.Services.Interfaces;

namespace XMLApiProject.Services.Services
{
    public class PurchaseTokenCache
    {
        static readonly int tokenLifetimeDurationInMinutes = 15;

        private Dictionary<int, PurchaseToken> _cache { get; set; }
        private IPurchaseTokenRepository _repo { get; set; }

        public PurchaseTokenCache(IPurchaseTokenRepository repo)
        {
            _cache = new Dictionary<int, PurchaseToken>();
            _repo = repo;
        }

        public async Task<PurchaseToken> GetTokenAsync(string userName, string password, string certificationId, int transactionAmount, string purchaserInfo, string transactionInfo)
        {
            PurchaseToken token;
            var key = (transactionAmount, purchaserInfo, transactionInfo).GetHashCode();

            if (_cache.ContainsKey(key))
            {
                token = _cache[key];
                if (token.IssuedDate.AddMinutes(tokenLifetimeDurationInMinutes) < DateTime.Now)
                {
                    _cache[key] = await GetTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo);
                }
            }
            else
            {
                token = new PurchaseToken
                {
                    Value = await _repo.AcquirePurchaseTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo),
                    IssuedDate = DateTime.Now,
                    PurchaserInfo = purchaserInfo,
                    TransactionInfo = transactionInfo
                };
                
                if (!string.IsNullOrEmpty(token.Value))
                {
                    _cache.Add(key, token);
                }
            }

            return token;
        }

        public async Task<PurchaseToken> GetAndConsumeTokenAsync(string userName, string password, string certificationId, int transactionAmount, string purchaserInfo, string transactionInfo)
        {
            PurchaseToken token;
            var key = (transactionAmount, purchaserInfo, transactionInfo).GetHashCode();

            if (_cache.ContainsKey(key))
            {
                token = _cache[key];
                if (token.IssuedDate.AddMinutes(tokenLifetimeDurationInMinutes) < DateTime.Now)
                {
                    _cache[key] = await GetAndConsumeTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo);
                }
            }
            else
            {
                token = new PurchaseToken
                {
                    Value = await _repo.AcquirePurchaseTokenAsync(userName, password, certificationId, transactionAmount, purchaserInfo, transactionInfo),
                    IssuedDate = DateTime.Now,
                    PurchaserInfo = purchaserInfo,
                    TransactionInfo = transactionInfo
                };
            }

            return token;
        }
    }
}
