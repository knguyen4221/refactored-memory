using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    //May need to change this to GetMerchantInfo instead because of response name typo in documentation
    public class MerchantInfo
    {
        public int MerchantCode { get; set; }
        public int MerchantAccountCode { get; set; }
        public string MerchantName { get; set; }
        public string GatewayResults { get; set; }
        public int GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
    }
}
