using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface ICaptureRequest
    {
        string MerchantCode { get; set; }
        string MerchantAccountCode { get; set; }
        uint Amount { get; set; }
        uint? SettlementDelay { get; set; }
        string OriginatingTechnologySource { get; set; }
        string SecurityTechnology { get; set; }
        string DeviceMake { get; set; }
        string DeviceModel { get; set; }
        string DeviceSerial { get; set; }
        string DeviceFirmware { get; set; }
        string RegistrationKey { get; set; }
        string AppHostMachineId { get; set; }
        string IntegrationMethod { get; set; }
        string ReferenceNumber { get; set; }
    }
}
