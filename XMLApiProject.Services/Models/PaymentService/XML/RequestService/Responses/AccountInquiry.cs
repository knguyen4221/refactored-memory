using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Xml.Serialization;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class AccountInquiry
    {
        #region Properties
        [StringLength(10)]
        public string TransactionType { get; set; }
        [StringLength(9)]
        public string ResponseType { get; set; }
        [StringLength(22)]
        public string Token { get; set; }

        [XmlIgnore]
        public DateTime _expirationDate { get; set; }
        [StringLength(6)]
        [JsonIgnore]
        public string ExpirationDate {
            get { return _expirationDate.ToString("MMyy"); }
            set { _expirationDate = DateTime.ParseExact(value, "MMyy", CultureInfo.InvariantCulture); }
        }
        public uint ReferenceNumber { get; set; }
        [StringLength(3)]
        public string GatewayResult { get; set; }
        public string GatewayMessage { get; set; }

        [XmlIgnore]
        public DateTime _transactionDate { get; set; }
        [StringLength(14)]
        [JsonIgnore]
        public string TransactionDate {
            get { return _transactionDate.ToString("yyyyMMdd"); }
            set { _transactionDate = DateTime.ParseExact(value, "yyyyMMdd", CultureInfo.InvariantCulture); }
        }

        public uint Balance { get; set; }

        [StringLength(50)]
        public string AuthorizationCode { get; set; }

        [StringLength(2)]
        public string AVSResult { get; set; }

        [StringLength(255)]
        public string AVSMessage { get; set; }

        [StringLength(1)]
        public string CVResult { get; set; }

        [StringLength(255)]
        public string CVMessage { get; set; }

        [StringLength(5)]
        public string ProviderAVSCode { get; set; }

        [StringLength(1)]
        public string ProviderCVCode { get; set; }

        [StringLength(50)]
        public string ProviderReferenceNumber { get; set; }
        #endregion
    }
}
