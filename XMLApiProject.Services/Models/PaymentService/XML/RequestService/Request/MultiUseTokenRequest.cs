using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService
{
    public class MultiUseTokenRequest
    {
        public string PaymentAccountNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string MSRKey { get; set; }
        public string SecureFormat { get; set; }
        public int BDKSlot { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        public string EncryptionId { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceSerial { get; set; }
        public string DeviceFirmware { get; set; }
        public string RegistrationKey { get; set; }
        public string AppHostMachineId { get; set; }
        public string IntegrationMethod { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }
    }
}
