using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    [XmlRootAttribute("Ping")]
    public class Ping
    {
        private const int _requestTypeLength = 3;

        [XmlIgnore]
        [JsonProperty("requestType")]
        internal RequestTypes _requestType { get; set; }
        [JsonIgnore]
        public string requestTypes
        {
            get
            {
                var res = ((int)_requestType).ToString();
                return String.Format("{0:000}", res);
            }
            set
            {
                _requestType = (RequestTypes)int.Parse(value);
            }
        }

        [XmlIgnore]
        [JsonProperty("responseCode")]
        internal ResponseCodes _responseCode { get; set; }
        [JsonIgnore]
        public int ResponseCode { get { return (int)_responseCode; } set { _responseCode = (ResponseCodes)value; } }

        public string TransactionId { get; set; }
        public string ResponseDescription { get; set; }
        

    }
}
