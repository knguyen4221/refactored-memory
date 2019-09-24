using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    //TODO: Support for custom fields
    public class AuthorizationRequest: IAuthorizationRequest
    {
        [DefaultValue(12137000)]
        public uint? MerchantCode { get; set; }
        [DefaultValue(12137001)]
        public uint? MerchantAccountCode { get; set; }
        [DefaultValue(500)]
        public uint Amount { get; set; }
        /// <summary>
        /// We can change this to DateTime or leave it as string and change the others afterwards
        /// </summary>
        [DefaultValue(1025)]
        public string ExpirationDate { get; set; }
        [DefaultValue("RE")]
        public string TransIndustryType { get; set; }
        [DefaultValue("sale")]
        public string TransactionType { get; set; }
        [DefaultValue("R")]
        public string TransCatCode { get; set; }
        [DefaultValue("R")]
        public string AcctType { get; set; }
        [DefaultValue("O")]
        public string HolderType { get; set; }
        /// <summary>
        /// This is pretty useful for when you have a purchase token because the purchase token makes comparison with this and several other properties to verify things
        /// </summary>
        [DefaultValue(null)]
        public uint? InvoiceNum { get; set; }
        [DefaultValue(500)]
        public uint? FeeAmount { get; set; }
        [DefaultValue(null)]
        public uint? TipAmount { get; set; }
        [DefaultValue(999)]
        public uint? SecurityCode { get; set; }
        /// <summary>
        /// This becomes optional if there's a multi-use token involved
        /// </summary>
        [DefaultValue("5499740000000057")]
        public string PaymentAccountNumber { get; set; }
        [DefaultValue("John Smith")]
        public string AccountHolderName { get; set; }
        [DefaultValue("123 Main Street")]
        public string AccountStreet { get; set; }
        [DefaultValue("28540")]
        public string AccountZip { get; set; }
        /// <summary>
        /// Purchase order number, user supplied. Optional
        /// </summary>
        [DefaultValue(null)]
        public string PONum { get; set; }
        /// <summary>
        /// This is pretty useful for when you have a purchase token because the purchase token makes comparison with this and several other properties to verify things
        /// </summary>
        [DefaultValue(null)]
        public string CustomerAccountCode { get; internal set; }
        /// <summary>
        /// Contract Id for recurring billing
        /// </summary>
        [DefaultValue(20)]
        public uint? ContractId { get; set; }
    }
}
