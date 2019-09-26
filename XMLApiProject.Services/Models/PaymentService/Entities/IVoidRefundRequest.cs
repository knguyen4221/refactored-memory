using System;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IVoidRefundRequest
    {
        string MerchantCode { get; set; }
        string MerchantAccountCode { get; set; }
        uint Amount { get; set; }
        string ReferenceNumber { get; set; }
        string TransactionType { get; set; }
        Guid? PurchaseToken { get; set; }
        string OriginatingTechnologySource { get; set; }
        string SoftwareVendor { get; set; }
        string SecurityTechnology { get; set; }
        string CustomerAccountCode { get; set; }
        string InvoiceNum { get; set; }
        string DeviceMake { get; set; }
        string DeviceModel { get; set; }
        string DeviceSerial { get; set; }
        string DeviceFirmware { get; set; }
        string RegistrationKey { get; set; }
        string AppHostMachineId { get; set; }
        string IntegrationMethod { get; set; }
        string EMVTags { get; set; }
        string VoidReasonCode { get; set; }
    }
}
