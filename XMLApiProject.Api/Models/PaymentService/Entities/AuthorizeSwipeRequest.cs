using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class AuthorizeSwipeRequest: IAuthorizeSwipeRequest
    {
        [DefaultValue(12137000)]
        public uint? MerchantCode { get; set; }
        [DefaultValue(12137001)]
        public uint? MerchantAccountCode { get; set; }
        [DefaultValue(500)]
        public uint Amount { get; set; }
        [DefaultValue("EC")]
        public string TransIndustryType { get; set; }
        [DefaultValue("sale")]
        public string TransactionType { get; set; }
        [DefaultValue("B")]
        public string TransCatCode { get; set; }
        [DefaultValue("%B4111111111111111^Smith/John^25101011000 1111A123456789012?")]
        public string Track1 { get; set; }
        [DefaultValue(null)]
        public string Track2 { get; set; }
        [DefaultValue("R")]
        public string AcctType { get; set; }
        [DefaultValue("P")]
        public string HolderType { get; set; }
        [DefaultValue(null)]
        public uint? InvoiceNum { get; set; }
        /// <summary>
        /// Additional fee amount
        /// </summary>
        [DefaultValue(null)]
        public uint? FeeAmount { get; set; }
        /// <summary>
        /// Additional Tip amount
        /// </summary>
        [DefaultValue(null)]
        public uint? TipAmount { get; set; }
        /// <summary>
        /// Method of entering the transaction. Possible values: MX = Manual with Signature, 
        /// SX = Swipe/Scan with Signature, HX = Chip with Signature, CX = Contactless with Signature, SP = Swipe with PIN, HP = Chip with PIN
        /// </summary>
        [DefaultValue("SX")]
        public string EntryMode { get; set; }
        /// <summary>
        /// The medium type used to initiate the transaction. Possible values: NP = Not Present, MC = Magnetic Card, CC = Chip Card, CH = Check
        /// </summary>
        [DefaultValue("MC")]
        public string EntryMediumType { get; set; }
        /// <summary>
        /// Indicates whether the input source supports PIN entry. Possible values: X = unknown, S = supported, U = Unsupported, N = Inoperative, O = Offline.
        /// </summary>
        [DefaultValue("S")]
        public string EntryPINModeType { get; set; }
    }
}
