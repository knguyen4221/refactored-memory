using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class InitiateSettlementRequest: IInitiateSettlementRequest
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
    }
}
