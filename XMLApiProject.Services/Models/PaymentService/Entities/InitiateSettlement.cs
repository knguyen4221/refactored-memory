﻿using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class InitiateSettlement
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
    }
}
