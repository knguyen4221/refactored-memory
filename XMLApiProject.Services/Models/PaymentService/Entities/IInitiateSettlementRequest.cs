using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IInitiateSettlementRequest
    {
        string MerchantCode { get; set; }
        string MerchantAccountCode { get; set; }
    }
}
