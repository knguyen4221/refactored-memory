using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class BalanceInquiryRequestMessage : RequestMessageBase
    {

        #region Properties
        [Required]
        [StringLength(20)]
        public string TransactionType { get; set; } = "BalanceInquiry";
        [Required]
        [StringLength(19)]
        public string PaymentAccountNumber { get; set; }
        [Required]
        [StringLength(1)]
        //Consider turning into enum
        //Automatically set to G for this type of request
        public string AcctType { get; set; } = "G";

        [Required]
        [StringLength(7)]
        public string ExpirationDate {
            get;
            set;
        }

        //May want to turn into an enum
        [Required]
        [StringLength(1)]
        public string HolderType { get; set; }

        //May want to turn this into an enum
        [Required]
        [StringLength(2)]
        public string TransIndustryType { get; set; }

        [Required]
        [StringLength(14)]
        public string TransactionDate { get; set; }

        [Required]
        [StringLength(12)]
        public string MerchantAccountCode { get; set; }

        [Required]
        [StringLength(12)]
        public string MerchantCode { get; set; }

        [StringLength(150)]
        public string AccountHolderName { get; set; }

        [StringLength(10)]
        public string LaneCode { get; set; }

        [StringLength(128)]
        public string AccountStreet { get; set; }

        [StringLength(50)]
        public string AccountCity { get; set; }

        [StringLength(2)]
        public string AccountState { get; set; }

        [StringLength(10)]
        public string AccountZip { get; set; }

        [StringLength(2)]
        public string AccountCountryCode { get; set; }

        [StringLength(20)]
        public string AccountPhone { get; set; }

        [StringLength(100)]
        public string AccountEmail { get; set; }

        [StringLength(24)]
        public string CustomerAccountCode { get; set; }

        #endregion

        public BalanceInquiryRequestMessage() { }

        public BalanceInquiryRequestMessage(BalanceInquiryRequest request)
        {
            PaymentAccountNumber = request.PaymentAccountNumber;
            ExpirationDate = request.ExpirationDate.ToString("MMyy");
            TransIndustryType = request.TransIndustryType;
            HolderType = request.HolderType;
            TransactionDate = request.TransactionDate.ToString("yyyyMMddHHmmss");
            MerchantAccountCode = request.MerchantAccountCode;
            MerchantCode = request.MerchantCode;
        }

        public override string GetResponseRootName()
        {
            return nameof(AccountInquiry);

        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<BalanceInquiryRequestMessage>();
        }
    }
}
