using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class VoidOrRefundRequest: RequestMessageBase
    {
        public int MerchantCode { get; set; }
        public int MerchantAccountCode { get; set; }
        public int Amount { get; set; }
        public int ReferenceNumber { get; set; }
        public string TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public string PurchaseToken { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }
        public string CustomerAccountCode { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceSerial { get; set; }
        public string DeviceFirmware { get; set; }
        public string RegistrationKey { get; set; }
        public string AppHostMachineId { get; set; }
        public string IntegrationMethod { get; set; }
        public string EMVTags { get; set; }
        public string VoidReasonCode { get; set; }

        public VoidOrRefundRequest()
        {
        }

        public VoidOrRefundRequest(int merchantCode, int merchantAccountCode, int amount, int referenceNumber, string transactionType, string transactionCode,
            string purchaseToken, string originatingTechnologySource, string softwareVendor, string securityTechnology, string customerAccountCode,
            string deviceMake, string deviceModel, string deviceSerial, string deviceFirmware, string registrationKey, string appHostMachineId, string integrationMethod,
            string emvTags, string voidReasonCode)
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
            DeviceMake = deviceMake;
            DeviceModel = deviceModel;
            DeviceSerial = deviceSerial;
            DeviceFirmware = deviceFirmware;
            RegistrationKey = registrationKey;
            AppHostMachineId = appHostMachineId;
            IntegrationMethod = integrationMethod;
            EMVTags = emvTags;
            VoidReasonCode = voidReasonCode;
        }

        public override string GetResponseRootName()
        {
            return nameof(VoidRefund);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<VoidOrRefundRequest>();
        }
    }
}
