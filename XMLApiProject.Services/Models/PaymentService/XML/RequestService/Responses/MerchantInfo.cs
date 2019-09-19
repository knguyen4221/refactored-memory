using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    //May need to change this to GetMerchantInfo instead because of response name typo in documentation
    public class MerchantInfo
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public string MerchantName { get; set; }
        public string GatewayResults { get; set; }
        public uint GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
    }
}
