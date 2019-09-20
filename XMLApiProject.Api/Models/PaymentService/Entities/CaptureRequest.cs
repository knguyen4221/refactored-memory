using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class CaptureRequest: ICaptureRequest
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public uint Amount { get; set; }
        public string TransactionType { get; set; }
        public uint? SettlementDelay { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SecurityTechnology { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceSerial { get; set; }
        public string DeviceFirmware { get; set; }
        public string RegistrationKey { get; set; }
        public string AppHostMachineId { get; set; }
        public string IntegrationMethod { get; set; }
        public string ReferenceNumber { get; set; }
    }
}
