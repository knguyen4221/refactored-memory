using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class VoidOrRefundRequest: RequestMessageBase
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        [Required]
        [StringLength(8)]
        public uint Amount { get; set; }
        [Required]
        [StringLength(12)]
        public string ReferenceNumber { get; set; }
        [Required]
        [StringLength(6)]
        public string TransactionType { get; set; }
        [Required]
        public string TransactionCode { get; set; }
        public Guid? PurchaseToken { get; set; }
        public string OriginatingTechnologySource { get; set; }
        [Required]
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }
        [StringLength(24)]
        public string CustomerAccountCode { get; set; }
        [StringLength(24)]
        public string InvoiceNum { get; set; }
        [StringLength(40)]
        public string DeviceMake { get; set; }
        [StringLength(40)]
        public string DeviceModel { get; set; }
        [StringLength(40)]
        public string DeviceSerial { get; set; }
        [StringLength(50)]
        public string DeviceFirmware { get; set; }
        [StringLength(10)]
        public string RegistrationKey { get; set; }
        [StringLength(36)]
        public string AppHostMachineId { get; set; }
        [StringLength(6)]
        public string IntegrationMethod { get; set; }
        [StringLength(255)]
        public string EMVTags { get; set; }
        [StringLength(20)]
        public string VoidReasonCode { get; set; }

        public VoidOrRefundRequest()
        {
        }

        public VoidOrRefundRequest(string merchantCode, string merchantAccountCode, uint amount, string referenceNumber, string transactionType, string transactionCode,
            Guid? purchaseToken, string originatingTechnologySource, string softwareVendor, string securityTechnology, string customerAccountCode, string invoiceNum,
            string deviceMake, string deviceModel, string deviceSerial, string deviceFirmware, string registrationKey, string appHostMachineId, string integrationMethod,
            string eMVTags, string voidReasonCode)
        {
            MerchantCode = merchantCode;
            MerchantAccountCode = merchantAccountCode;
            Amount = amount;
            ReferenceNumber = referenceNumber;
            TransactionType = transactionType;
            TransactionCode = transactionCode;
            PurchaseToken = purchaseToken;
            OriginatingTechnologySource = originatingTechnologySource;
            SoftwareVendor = softwareVendor;
            SecurityTechnology = securityTechnology;
            CustomerAccountCode = customerAccountCode;
            InvoiceNum = invoiceNum;
            DeviceMake = deviceMake;
            DeviceModel = deviceModel;
            DeviceSerial = deviceSerial;
            DeviceFirmware = deviceFirmware;
            RegistrationKey = registrationKey;
            AppHostMachineId = appHostMachineId;
            IntegrationMethod = integrationMethod;
            EMVTags = eMVTags;
            VoidReasonCode = voidReasonCode;
        }

        public VoidOrRefundRequest(VoidRefundRequest request)
        {
            MerchantCode = request.MerchantCode;
            MerchantAccountCode = request.MerchantAccountCode;
            Amount = request.Amount;
            ReferenceNumber = request.ReferenceNumber;
            TransactionType = request.TransactionType;
            TransactionCode = request.TransactionCode;
            PurchaseToken = request.PurchaseToken;
            OriginatingTechnologySource = request.OriginatingTechnologySource;
            SoftwareVendor = request.SoftwareVendor;
            SecurityTechnology = request.SecurityTechnology;
            CustomerAccountCode = request.CustomerAccountCode;
            InvoiceNum = request.InvoiceNum;
            DeviceMake = request.DeviceMake;
            DeviceModel = request.DeviceModel;
            DeviceSerial = request.DeviceSerial;
            DeviceFirmware = request.DeviceFirmware;
            RegistrationKey = request.RegistrationKey;
            AppHostMachineId = request.AppHostMachineId;
            IntegrationMethod = request.IntegrationMethod;
            EMVTags = request.EMVTags;
            VoidReasonCode = request.VoidReasonCode;
        }

        public override string GetResponseRootName()
        {
            return nameof(VoidRefund);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<VoidOrRefundRequest>();
        }

        public bool ShouldSerializePurchaseToken()
        {
            return PurchaseToken.HasValue;
        }
    }
}
