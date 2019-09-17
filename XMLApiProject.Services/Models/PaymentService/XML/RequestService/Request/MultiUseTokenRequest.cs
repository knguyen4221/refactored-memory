using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class MultiUseTokenRequest: RequestMessageBase
    {

        #region Constructor

        public MultiUseTokenRequest()
        {
        }
        public MultiUseTokenRequest(string paymentAccountNumber, string expirationDate, string mSRKey, string secureFormat, int bDKSlot, string track1, 
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

        #endregion

        public string PaymentAccountNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string MSRKey { get; set; }
        public string SecureFormat { get; set; }
        public int BDKSlot { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        public int SecurityCode { get; set; }
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

        public override string GetResponseRootName()
        {
            return nameof(GetToken);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<MultiUseTokenRequest>();
        }
    }
}
