using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class BaseResponse<T>
    {
        private const int _requestTypeLength = 3;

        public BaseResponse()
        {
        }

        #region Underlying Object Representation
        [XmlIgnore]
        [JsonProperty("requestType")]
        internal RequestTypes _requestType { get; set; }

        [XmlIgnore]
        [JsonProperty("responseCode")]
        internal ResponseCodes _responseCode { get; set; }
        #endregion

        #region Xml Object Representation
        [JsonIgnore]
        public string RequestType
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

        [JsonIgnore]
        public int ResponseCode { get { return (int)_responseCode; } set { _responseCode = (ResponseCodes)value; } }
        #endregion


        public string TransactionId { get; set; }
        public string ResponseDescription { get; set; }

        public T responseMessage { get; set; }

    }
}
