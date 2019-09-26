using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class InitiateSettlementRequest: IInitiateSettlementRequest
    {
        [DefaultValue("12137000")]
        public string MerchantCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantAccountCode { get; set; }
    }
}
