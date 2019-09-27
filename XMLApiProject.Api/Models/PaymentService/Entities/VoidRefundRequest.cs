﻿using Newtonsoft.Json;
using System;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class VoidRefundRequest: IVoidRefundRequest
    {
        [DefaultValue("12137000")]
        public string MerchantCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantAccountCode { get; set; }
        [DefaultValue(500)]
        public uint Amount { get; set; }
        [DefaultValue("GRAB THE GATEWAYTRANSID FROM THE AUTH RESPONSE")]
        public string ReferenceNumber { get; set; }
        [DefaultValue("refund")]
        public string TransactionType { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public Guid? PurchaseToken { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string OriginatingTechnologySource { get; set; }
        [DefaultValue("BridgePay")]
        public string SoftwareVendor { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string SecurityTechnology { get; set; }
        /// <summary>
        /// If you use a purchase token to void or refund, this must match the credentials you provided for that token
        /// </summary>
        [DefaultValue(null)]
        [JsonIgnore]
        public string CustomerAccountCode { get; set; }
        /// <summary>
        /// If you use a purchase token to void or refund, this must match the credentials you provided for that token
        /// </summary>
        [DefaultValue(null)]
        [JsonIgnore]
        public string InvoiceNum { get; set; }
        /// <summary>
        /// Device parameters are probably useless
        /// </summary>
        [DefaultValue(null)]
        [JsonIgnore]
        public string DeviceMake { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string DeviceModel { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string DeviceSerial { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string DeviceFirmware { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string RegistrationKey { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string AppHostMachineId { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string IntegrationMethod { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string EMVTags { get; set; }
        /// <summary>
        /// Idenitifies the reason a transaction was voided from a device. Acceptable values are: CustomerInitiated, TimeoutReversal, System Malfunction, SuspectedFraud, PrematureCardRemoval, ChipDecline
        /// Optional however
        /// </summary>
        [DefaultValue(null)]
        [JsonIgnore]
        public string VoidReasonCode { get; set; }
    }
}
