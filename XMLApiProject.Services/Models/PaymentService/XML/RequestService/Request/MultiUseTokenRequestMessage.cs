using System.ComponentModel.DataAnnotations;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class MultiUseTokenRequestMessage: RequestMessageBase
    {
        #region Properties
        [Required]
        [StringLength(16)]
        public string PaymentAccountNumber { get; set; }
        [StringLength(7)]
        public string ExpirationDate { get; set; }
        public string MSRKey { get; set; }
        public string SecureFormat { get; set; }
        public uint? BDKSlot { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        public string EncryptionId { get; set; }
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
        [StringLength(6)]
        public string IntegrationMethod { get; set; }
        public string OriginatingTechnologySource { get; set; }
        [Required]
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }
        #endregion

        #region Constructor
        public MultiUseTokenRequestMessage()
        {
        }

        public MultiUseTokenRequestMessage(string paymentAccountNumber, string expirationDate, string mSRKey, string secureFormat, uint bDKSlot, string track1, 
            string track2, string track3, string encryptionId, string deviceMake, string deviceModel, string deviceSerial, 
            string deviceFirmware, string registrationKey, string appHostMachineId, string integrationMethod, string originatingTechnologySource, 
            string softwareVendor, string securityTechnology)
        {
            PaymentAccountNumber = paymentAccountNumber;
            ExpirationDate = expirationDate;
            MSRKey = mSRKey;
            SecureFormat = secureFormat;
            BDKSlot = bDKSlot;
            Track1 = track1;
            Track2 = track2;
            Track3 = track3;
            EncryptionId = encryptionId;
            DeviceMake = deviceMake;
            DeviceModel = deviceModel;
            DeviceSerial = deviceSerial;
            DeviceFirmware = deviceFirmware;
            RegistrationKey = registrationKey;
            AppHostMachineId = appHostMachineId;
            IntegrationMethod = integrationMethod;
            OriginatingTechnologySource = originatingTechnologySource;
            SoftwareVendor = softwareVendor;
            SecurityTechnology = securityTechnology;
        }

        public MultiUseTokenRequestMessage(GetTokenRequest request)
        {
            {
                PaymentAccountNumber = request.PaymentAccountNumber;
                ExpirationDate = request.ExpirationDate.ToString("MMyy");
                MSRKey = request.MSRKey;
                SecureFormat = request.SecureFormat;
                BDKSlot = request.BDKSlot;
                Track1 = request.Track1;
                Track2 = request.Track2;
                Track3 = request.Track3;
                EncryptionId = request.EncryptionId;
                DeviceMake = request.DeviceMake;
                DeviceModel = request.DeviceModel;
                DeviceSerial = request.DeviceSerial;
                DeviceFirmware = request.DeviceFirmware;
                RegistrationKey = request.RegistrationKey;
                AppHostMachineId = request.AppHostMachineId;
                IntegrationMethod = request.IntegrationMethod;
                OriginatingTechnologySource = request.OriginatingTechnologySource;
                SoftwareVendor = request.SoftwareVendor;
                SecurityTechnology = request.SecurityTechnology;
            }
        }
        #endregion

        public override string GetResponseRootName()
        {
            return nameof(GetToken);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<MultiUseTokenRequestMessage>();
        }

        public bool ShouldSerializeBDKSlot()
        {
            return BDKSlot.HasValue;
        }
    }
}
