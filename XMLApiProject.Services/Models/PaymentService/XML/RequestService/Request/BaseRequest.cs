using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Models.XML.RequestService.Request
{
    [XmlRoot("requestHeader")]
    public class BaseRequest
    {
        //Note: Properties without setters cannot be serialized
        private const int _requestTypeLength = 3;

        [XmlIgnore]
        internal DateTime _requestDateTime { get; set; }
        [XmlIgnore]
        internal RequestTypes _requestType { get; set; }
        [XmlIgnore]
        internal int _transactionId { get; set; }
        [XmlIgnore]
        internal string _requestMessage { get; set; }

        public string ClientIdentifier { get; set; } = "SOAP";
        public string TransactionId { get {
                return _transactionId.ToString();
            }
        }
        public string RequestType {
            get {
                var res = ((int)_requestType).ToString();
                while (res.Length != _requestTypeLength)
                {
                    res = "0" + res;
                }
                return res;
            }
            set {
                _requestType = (RequestTypes)(int.Parse(value));
            }
        }
        public string RequestDateTime {
            get
            {
                return _requestDateTime.ToString("yyyy-MM-dd");
            }
            set
            {
                _requestDateTime = DateTime.Parse(value);
            }
        }
        public string User { get; set; }
        public string Password { get; set; }
        
        public string requestMessage { get { return _requestMessage; } set { _requestMessage = value; } }

        public BaseRequest() { }

        /// <summary>
        /// NOTE: for now request message is string but we'll change it to an interface that is capable of translating itself into xml!
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="_requestDateTime"></param>
        /// <param name="_requestType"></param>
        /// <param name="requestMessage"></param>
        public BaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, string requestMessage)
        {
            _transactionId = transactionId;
            _requestDateTime = requestDateTime;
            _requestType = requestType;
            _requestMessage = requestMessage;
        }

    }
}
