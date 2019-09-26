using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;
using XMLApiProject.Services.Models.PurchaseTokenService;
using XMLApiProject.Services.Models.PurchaseTokenService.Entities;
using XMLApiProject.Services.Services.Interfaces;
using XMLApiProject.Services.Utilities;

namespace XMLApiProject.Services.Services
{
    public class PurchaseTokenService: IPurchaseTokenService
    {
        private IConfiguration _configuration;
        private PurchaseTokenCache _cache;

        public PurchaseTokenService(IConfiguration configuration, PurchaseTokenCache cache)
        {
            _configuration = configuration;
            _cache = cache;
        }

        public async Task<PurchaseToken> AcquirePurchaseToken(IPurchaseTokenRequest request)
        {
            var userName = _configuration.GetSection("Credentials")["userName"];
            var password = _configuration.GetSection("Credentials")["password"];

            return await _cache.GetTokenAsync(userName, password, request.CertificationId, request.TransactionAmount, request.PurchaserInfo, request.TransactionInfo);
        }
    }
}
