using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class AuthorizationRequestMessage: RequestMessageBase
    {

        #region Properties
        public uint? MerchantCode { get; set; }
        public uint? MerchantAccountCode { get; set; }
        public Guid? PurchaseToken { get; set; }
        /// <summary>
        /// Codependent value. Required of track or EMV data is not present
        /// </summary>
        [StringLength(19)]
        public string PaymentAccountNumber { get; set; }
        public string ExpirationDate { get; set; }
        /// <summary>
        /// Used in place of the PaymentAccountNUmber when gotten from the multiuse token request
        /// </summary>
        public string Token { get; set; }
        public Guid? WalletPaymentMethodID { get; set; }
        public string WalletToken { get; set; }
        public string WalletKey { get; set; }
        public string CustomerWalletId { get; set; }
        public uint? SecurityCode { get; set; }

        /// <summary>
        /// Required amount
        /// </summary>
        [Required]
        public uint Amount { get; set; }

        public string EncryptionId { get; set; }
        [StringLength(50)]
        public string MSRKey { get; set; }
        [StringLength(50)]
        public string SecureFormat { get; set; }
        public uint? BDKSlot { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        [Required]
        [StringLength(11)]
        public string TransactionType { get; set; }
        [Required]
        [StringLength(3)]
        public string TransIndustryType { get; set; }
        [StringLength(1)]
        public string TransactionMode { get; set; }
        [StringLength(1)]
        public string TransCatCode { get; set; }
        [StringLength(25)]
        public string Descriptor { get; set; }
        [StringLength(15)]
        public string VoiceAuthCode { get; set; }
        [StringLength(5)]
        public string PartialAuthorization { get; set; }
        /// <summary>
        /// For ACH and Check transactions
        /// </summary>
        public string BankAccountNum { get; set; }
        [StringLength(10)]
        public string RoutingNum { get; set; }

        [StringLength(1)]
        [Required]
        public string AcctType { get; set; }

        [StringLength(20)]
        public string DUKPT { get; set; }
        [StringLength(16)]
        public string PINCode { get; set; }
        [StringLength(15)]
        public string VoucherNumber { get; set; }
        
        public uint? InvoiceNum { get; set; }
        [StringLength(24)]
        public string PONum { get; set; }
        [StringLength(24)]
        public string CustomerAccountCode { get; set; }
        [StringLength(60)]
        public string PaymentType { get; set; }
        [StringLength(150)]
        public string AccountHolderName { get; set; }
        [StringLength(1)]
        [Required]
        public string HolderType { get; set; }
        public uint? CashBackAmount { get; set; }
        public uint? FeeAmount { get; set; }
        public uint? TipAmount { get; set; }
        [StringLength(15)]
        public string TipRecipientCode { get; set; }
        public uint? HealthCareAmt { get; set; }
        public uint? TransitAmt { get; set; }
        public uint? PrescriptionAmt { get; set; }
        public uint? VisionAmt { get; set; }
        public uint? DentalAmt { get; set; }
        public uint? ClinicAmt { get; set; }
        public string IsQualifiedIIAS { get; set; }
        [StringLength(128)]
        public string AccountStreet { get; set; }
        [StringLength(10)]
        public string AccountZip { get; set; }
        [StringLength(20)]
        public string AccountPhone { get; set; }
        public uint? ContractId { get; set; }
        #region C (Access for level 3?) We probably don't need this. Fill this section out more if it turns out we need this, but I don't think we do for recurring billing
        public uint? TaxRate { get; set; }
        public uint? TaxAmount { get; set; }
        [StringLength(1)]
        public string TaxIndicator { get; set; }
        [StringLength(100)]
        public string ShipToName { get; set; }
        [StringLength(128)]
        public string ShipToStreet { get; set; }
        [StringLength(50)]
        public string ShipToCity { get; set; }
        [StringLength(2)]
        public string ShipToState { get; set; }
        public uint? ItemCount { get; set; }
        [XmlElement]
        public List<ItemRequestMessage> Item { get; set; }
        #endregion

        [StringLength(64000)]
        public string CheckImageFront { get; set; }
        [StringLength(64000)]
        public string CheckImageBack { get; set; }
        [StringLength(255)]
        public string MICR { get; set; }
        [StringLength(255)]
        public string EMVTags { get; set; }
        public uint? SettlementDelay { get; set; }

        [StringLength(2)]
        //Possible enum
        public string EntryMode { get; set; }

        [StringLength(2)]
        //Possible enum
        public string EntryMedium { get; set; }

        [StringLength(1)]
        //Possible enum
        public string EntryPinCode { get; set; }

        [StringLength(255)]
        public string TerminalCapabilities { get; set; }
        [StringLength(255)]
        public string TerminalType { get; set; }
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
        //Possible enum
        public string IntegrationMethod { get; set; }
        public string OriginatingTechnologySource { get; set; }
        [Required]
        public string SoftwareVendor { get; set; }
        public string SecurityTechnology { get; set; }

        #endregion


        #region Constructors

        public AuthorizationRequestMessage() { }

        /// <summary>
        /// This is a constructor for all types that are marked as required. Any other optional types should be directly set via initialization list
        /// </summary>
        /// <param name="paymentAccountNumber"></param>
        /// <param name="transactionType">Possible values: sale, sale-auth, cred, credit-auth, increment, sale-info, credit-info, adjustment</param>
        /// <param name="transIndustryType">Supported RE, RS, EC, DM, LD, CR, HC, CCD, PPD, POP, TEL, WEB, C21</param>
        /// <param name="acctType">Single character R, D, S, C, F, H, G, L, K, A</param>
        /// <param name="holderType">Single character either P or O</param>
        /// <param name="amount">Amount request for authorization</param>
        /// <param name="expirationDate">Expiry date of the card of the format MMyy or MM/yy</param>
        /// <param name="softwareVendor"></param>
        public AuthorizationRequestMessage(string paymentAccountNumber, string transactionType, string transIndustryType, string acctType, string holderType, 
            string softwareVendor, uint amount, string expirationDate)
        {
            PaymentAccountNumber = paymentAccountNumber;
            TransactionType = transactionType;
            TransIndustryType = transIndustryType;
            AcctType = acctType;
            HolderType = holderType;
            SoftwareVendor = softwareVendor;
            Amount = amount;
            ExpirationDate = expirationDate;
        }

        public AuthorizationRequestMessage(IAuthorizationRequest authorizationRequest)
        {
            //Missing custom fields for now
            MerchantCode = authorizationRequest.MerchantCode;
            MerchantAccountCode = authorizationRequest.MerchantAccountCode;
            PaymentAccountNumber = authorizationRequest.PaymentAccountNumber;
            ExpirationDate = authorizationRequest.ExpirationDate;
            SecurityCode = authorizationRequest.SecurityCode;
            Amount = (uint)authorizationRequest.Amount;
            TransactionType = authorizationRequest.TransactionType;
            TransIndustryType = authorizationRequest.TransIndustryType;
            TransCatCode = authorizationRequest.TransCatCode;
            AcctType = authorizationRequest.AcctType;
            InvoiceNum = authorizationRequest.InvoiceNum;
            PONum = authorizationRequest.PONum;
            CustomerAccountCode = authorizationRequest.CustomerAccountCode;
            AccountHolderName = authorizationRequest.AccountHolderName;
            HolderType = authorizationRequest.HolderType;
            AccountStreet = authorizationRequest.AccountStreet;
            AccountZip = authorizationRequest.AccountZip;
            Token = authorizationRequest.Token;
            ContractId = authorizationRequest.ContractId;
            SettlementDelay = authorizationRequest.SettlementDelay;
            FeeAmount = authorizationRequest.FeeAmount;
            PartialAuthorization = authorizationRequest.PartialAuthorization;
        }

        public AuthorizationRequestMessage(IAuthorizeSwipeRequest trackRequest)
        {
            MerchantCode = trackRequest.MerchantCode;
            MerchantAccountCode = trackRequest.MerchantAccountCode;
            Amount = trackRequest.Amount;
            TransIndustryType = trackRequest.TransIndustryType;
            TransactionType = trackRequest.TransactionType;
            TransCatCode = trackRequest.TransCatCode;
            Track1 = trackRequest.Track1;
            Track2 = trackRequest.Track2;
            AcctType = trackRequest.AcctType;
            HolderType = trackRequest.HolderType;
            InvoiceNum = trackRequest.InvoiceNum;
            FeeAmount = trackRequest.FeeAmount;
            TipAmount = trackRequest.TipAmount;
            EntryMode = trackRequest.EntryMode;
            EntryMedium = trackRequest.EntryMediumType;
            EntryPinCode = trackRequest.EntryPINModeType;
        }
        #endregion

        public override string GetResponseRootName()
        {
            return nameof(Auth);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<AuthorizationRequestMessage>();
        }

        public bool ShouldSerializePurchaseToken()
        {
            return PurchaseToken.HasValue;
        }

        public bool ShouldSerializeWalletPaymentMethodID()
        {
            return WalletPaymentMethodID.HasValue;
        }

        public bool ShouldSerializeSecurityCode()
        {
            return SecurityCode.HasValue;
        }

        public bool ShouldSerializeCashBackAmount()
        {
            return CashBackAmount.HasValue;
        }

        public bool ShouldSerializeHealthCareAmt()
        {
            return HealthCareAmt.HasValue;
        }

        public bool ShouldSerializePrescriptionAmt()
        {
            return PrescriptionAmt.HasValue;
        }

        public bool ShouldSerializeVisionAmt()
        {
            return VisionAmt.HasValue;
        }

        public bool ShouldSerializeDentalAmt()
        {
            return DentalAmt.HasValue;
        }

        public bool ShouldSerializeClinicAmt()
        {
            return ClinicAmt.HasValue;
        }

        public bool ShouldSerializeContractId()
        {
            return ContractId.HasValue;
        }

        public bool ShouldSerializeItemCount()
        {
            return ItemCount.HasValue;
        }

        public bool ShouldSerializeTaxRate()
        {
            return TaxRate.HasValue;
        }

        public bool ShouldSerializeTaxAmount()
        {
            return TaxAmount.HasValue;
        }

        public bool ShouldSerializeSettlementDelay()
        {
            return SettlementDelay.HasValue;
        }

        public bool ShouldSerializeTransitAmt()
        {
            return TransitAmt.HasValue;
        }

        public bool ShouldSerializeBDKSlot()
        {
            return BDKSlot.HasValue;
        }

        public bool ShouldSerializeTipAmount()
        {
            return TipAmount.HasValue;
        }

        public bool ShouldSerializeFeeAmount()
        {
            return FeeAmount.HasValue;
        }

    }

}
