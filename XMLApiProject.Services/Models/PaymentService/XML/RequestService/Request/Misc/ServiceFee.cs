﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request.Misc
{
    public class ServiceFee
    {
        public Guid ServiceFeeID { get; set; }
        public string ResellerCode { get; set; }
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        [Required]
        [StringLength(8)]
        public uint Amount { get; set; }
        //Note: May want to start to move away from these as we figure out how to use MerchantCode/MerchantAccountCode/ResellerCode
        public string ServiceUser { get; set; }
        public string ServicePassword { get; set; }
    }
}
