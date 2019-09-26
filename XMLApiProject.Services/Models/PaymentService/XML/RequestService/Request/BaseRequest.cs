using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Models.XML.RequestService.Request
{
    /// <summary>
    /// Payment Service request wrapper that contains a lot of constants...
    /// </summary>
    [XmlRoot("requestHeader")]
    public class BaseRequest
    {
        private const int _requestTypeLength = 3;

        #region Underlying object representation
        [XmlIgnore]
        internal DateTime _requestDateTime { get; set; }
        [XmlIgnore]
        internal RequestTypes _requestType { get; set; }
        //Note: Going to be generated so it's pretty unnecessary
        [XmlIgnore]
        internal Guid _transactionId { get; set; }
        [XmlIgnore]
        public RequestMessageBase _requestMessage { get; set; }
        #endregion

        #region Xml Object Representation
        public string ClientIdentifier { get; set; } = "SOAP";
        public string TransactionId { get { return _transactionId.ToString(); } set { _transactionId = Guid.Parse(value); } }
        public string RequestType
        {
            get
            {
                return ((int)_requestType).ToString("D3");
            }
            set
            {
                _requestType = (RequestTypes)int.Parse(value);
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

        //Note: Setter not necessary since we don't really deserialize request types from XML... 
        //Note: Properties without setters cannot be serialized, so we have to at least have one even if it doesn't do anything
        [XmlElement("requestMessage")]
        [JsonIgnore]
        public RawRequestMessageString requestMessage { get { return _requestMessage.ToXmlRequestString(); } set { throw new NotImplementedException(); } }
        #endregion

        #region Constructors   
        public BaseRequest() { }

        /// <summary>
        /// NOTE: for now request message is string but we'll change it to an interface that is capable of translating itself into xml!
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="_requestDateTime"></param>
        /// <param name="_requestType"></param>
        /// <param name="requestMessage"></param>
        public BaseRequest(Guid transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage)
        {
            _transactionId = transactionId;
            _requestDateTime = requestDateTime;
            _requestType = requestType;
            _requestMessage = requestMessage;
        }
        #endregion
    }

}
