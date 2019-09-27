using System;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    /// <summary>
    /// Get Token on our end for our REST endpoint
    /// </summary>
    public interface IGetTokenRequest
    {
        string MerchantAccountCode { get; set; }
        string MerchantCode { get; set; }
        string PaymentAccountNumber { get; set; }
        /// <summary>
        /// As DateTime but only the year and month matter since input to XML api only needs string
        /// </summary>
        DateTime ExpirationDate { get; set; }
        string MSRKey { get; set; }
        string SecureFormat { get; set; }
        uint? BDKSlot { get; set; }
        string Track1 { get; set; }
        string Track2 { get; set; }
        string Track3 { get; set; }
        string EncryptionId { get; set; }
        string DeviceMake { get; set; }
        string DeviceModel { get; set; }
        string DeviceSerial { get; set; }
        string DeviceFirmware { get; set; }
        string RegistrationKey { get; set; }
        string AppHostMachineId { get; set; }
        string IntegrationMethod { get; set; }
        string OriginatingTechnologySource { get; set; }
        string SoftwareVendor { get; set; }
        string SecurityTechnology { get; set; }
    }
}
