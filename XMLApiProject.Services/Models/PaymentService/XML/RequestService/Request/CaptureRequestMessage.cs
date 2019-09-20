using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class CaptureRequestMessage: RequestMessageBase
    {

        #region Properties
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        
        [Required]
        public uint Amount { get; set; }

        [Required]
        public string TransactionType { get; set; }
        [Required]
        public string TransactionCode { get; set; }
        [Required]
        public string SoftwareVendor { get; set; } = "BridgePay";


        public uint? SettlementDelay { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SecurityTechnology { get; set; }
        public string DeviceMake { get; set; }
        [StringLength(40)]
        public string DeviceModel { get; set; }
        [StringLength(40)]
        public string DeviceSerial { get; set; }
        [StringLength(50)]
        public string DeviceFirmware { get; set; }
        [StringLength(10)]
        public string RegistrationKey { get; set; }
        [StringLength(10)]
        public string AppHostMachineId { get; set; }
        [StringLength(6)]
        public string IntegrationMethod { get; set; }
        public string ReferenceNumber { get; set; }
        #endregion


        public CaptureRequestMessage(ICaptureRequest request, int transactionCode)
        {
            MerchantAccountCode = request.MerchantAccountCode;
            MerchantCode = request.MerchantCode;
            Amount = request.Amount;
            TransactionType = request.TransactionType;
            SettlementDelay = request.SettlementDelay;
            SecurityTechnology = request.SecurityTechnology;
            OriginatingTechnologySource = request.OriginatingTechnologySource;
            AppHostMachineId = request.AppHostMachineId;
            DeviceFirmware = request.DeviceFirmware;
            DeviceMake = request.DeviceMake;
            DeviceModel = request.DeviceModel;
            DeviceSerial = request.DeviceSerial;
            IntegrationMethod = request.IntegrationMethod;
            RegistrationKey = request.RegistrationKey;
            ReferenceNumber = request.ReferenceNumber;
            this.TransactionCode = transactionCode.ToString();
        }

        public CaptureRequestMessage() { }

        public override string GetResponseRootName()
        {
            return nameof(Responses.Capture);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<CaptureRequestMessage>();
        }

        public bool ShouldSerializeSettlementDelay()
        {
            return SettlementDelay.HasValue;
        }

    }
}
