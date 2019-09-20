using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public class VoidRefundBody
    {
        public string MerchantCode { get; set; }
        public string MerchantAccountCode { get; set; }
        public uint Amount { get; set; }
        public string ReferenceNumber { get; set; }
        public string TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public Guid? PurchaseToken { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }
        public string CustomerAccountCode { get; set; }
        public string InvoiceNum { get; set; }
        public string DeviceMake { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceSerial { get; set; }
        public string DeviceFirmware { get; set; }
        public string RegistrationKey { get; set; }
        public string AppHostMachineId { get; set; }
        public string IntegrationMethod { get; set; }
        public string EMVTags { get; set; }
        public string VoidReasonCode { get; set; }
    }
}
