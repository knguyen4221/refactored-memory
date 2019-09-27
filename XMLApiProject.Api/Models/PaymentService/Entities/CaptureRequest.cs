using Newtonsoft.Json;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class CaptureRequest: ICaptureRequest
    {
        [DefaultValue("12137000")]
        public string MerchantCode { get; set; }
        [DefaultValue("12137001")]
        public string MerchantAccountCode { get; set; }
        [DefaultValue(500)]
        public uint Amount { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public uint? SettlementDelay { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string OriginatingTechnologySource { get; set; }
        [DefaultValue(null)]
        [JsonIgnore]
        public string SecurityTechnology { get; set; }
        /// <summary>
        /// Devices are probably unnecessary? Since most transactions will be online.
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
        [DefaultValue("GRAB THE GATEWAYTRANSID FROM THE AUTH RESPONSE")]
        public string ReferenceNumber { get; set; }
    }
}
