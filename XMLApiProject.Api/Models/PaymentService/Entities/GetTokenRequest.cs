﻿using System;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    /// <summary>
    /// Get Token on our end for our REST endpoint
    /// </summary>
    public class GetTokenRequest: IGetTokenRequest
    {
        [DefaultValue("12137000")]
        public string MerchantAccountCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantCode { get; set; }
        [DefaultValue("4111111111111111")]
        public string PaymentAccountNumber { get; set; }
        [DefaultValue(typeof(DateTime), "2025-10-23T17:31:08.365Z")]
        public DateTime ExpirationDate { get; set; }
        [DefaultValue(null)]
        public string MSRKey { get; set; }
        [DefaultValue(null)]
        public string SecureFormat { get; set; }
        public uint? BDKSlot { get; set; }
        [DefaultValue(null)]
        public string Track1 { get; set; }
        [DefaultValue(null)]
        public string Track2 { get; set; }
        [DefaultValue(null)]
        public string Track3 { get; set; }
        [DefaultValue(null)]
        public string EncryptionId { get; set; }
        [DefaultValue(null)]
        public string DeviceMake { get; set; }
        [DefaultValue(null)]
        public string DeviceModel { get; set; }
        [DefaultValue(null)]
        public string DeviceSerial { get; set; }
        [DefaultValue(null)]
        public string DeviceFirmware { get; set; }
        [DefaultValue(null)]
        public string RegistrationKey { get; set; }
        [DefaultValue(null)]
        public string AppHostMachineId { get; set; }
        [DefaultValue(null)]
        public string IntegrationMethod { get; set; }
        [DefaultValue(null)]
        public string OriginatingTechnologySource { get; set; }
        [DefaultValue("BridgePay")]
        public string SoftwareVendor { get; set; }
        [DefaultValue(null)]
        public string SecurityTechnology { get; set; }
    }
}
