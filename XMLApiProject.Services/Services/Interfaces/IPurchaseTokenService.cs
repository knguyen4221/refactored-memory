﻿using System;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;
using XMLApiProject.Services.Models.PurchaseTokenService;
using XMLApiProject.Services.Models.PurchaseTokenService.Entities;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IPurchaseTokenService
    {
        Task<PurchaseToken> AcquirePurchaseToken(IPurchaseTokenRequest request);
    }
}
