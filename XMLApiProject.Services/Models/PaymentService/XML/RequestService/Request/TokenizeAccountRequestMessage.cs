using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class TokenizeAccountRequestMessage : RequestMessageBase
    {

        #region Properties
        [Required]
        public string SoftwareVendor { get; set; }
        [Required]
        public string BankAccountNum { get; set; }
        public string OriginatingTechnologySource { get; set; }
        public string SecurityTechnology { get; set; }
        [StringLength(40)]
        public string DeviceMake { get; set; }
        [StringLength(40)]
        public string DeviceModel { get; set; }
        [StringLength(40)]
        public string DeviceSerial { get; set; }
        [StringLength(50)]
        public string DeviceFirmware { get; set; }
        [StringLength(10)]
        public string RegistrationKey { get; set; }
        [StringLength(36)]
        public string AppHostMachineId { get; set; }
        //TODO: Turn integration method into its own enum
        [StringLength(6)]
        public string IntegrationMethod { get; set; }
        #endregion

        public TokenizeAccountRequestMessage()
        {
            
        }

        public TokenizeAccountRequestMessage(ITokenizeAccountRequest request)
        {
            BankAccountNum = request.BankAccountNum;
            SoftwareVendor = request.SoftwareVendor;
        }

        public override string GetResponseRootName()
        {
            return nameof(GetToken);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<TokenizeAccountRequestMessage>();
        }
    }
}
