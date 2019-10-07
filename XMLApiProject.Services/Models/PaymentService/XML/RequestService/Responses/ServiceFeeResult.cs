using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class ServiceFeeResult
    {
        public string ServiceFeeID { get; set; }
        [StringLength(50)]
        public string AuthorizationCode { get; set; }
        [StringLength(5)]
        public string GatewayResult { get; set; }
        public uint AuthorizedAmount { get; set; }
        public uint OriginalAmount { get; set; }
        public uint GatewayTransID { get; set; }
        public string GatewayMessage { get; set; }
        public string InternalMessage { get; set; }
    }
}
