using System.ComponentModel.DataAnnotations;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class ItemRequestMessage
    {
        [StringLength(12)]
        [Required]
        public string ItemCode { get; set; }

        [StringLength(12)]
        [Required]
        public string ItemCommodityCode { get; set; }
        
        [StringLength(35)]
        [Required]
        public string ItemDescription { get; set; }

        [Required]
        public uint ItemQuantity { get; set; }
        
        [Required]
        public uint ItemUnitCostAmt { get; set; }

        [StringLength(12)]
        [Required]
        public string ItemUnitMeasure { get; set; }

        [Required]
        public uint ItemTaxRate { get; set; }

        [Required]
        public uint ItemTaxAmount { get; set; }

        [Required]
        [StringLength(1)]
        //Possible enum
        public string ItemTaxIndicator { get; set; }

        [Required]
        [StringLength(4)]
        public string ItemTaxCode { get; set; }

        [Required]
        public uint ItemDiscountRate { get; set; }

        [Required]
        public uint ItemDiscountAmount { get; set; }

        [Required]
        public uint ItemTotalAmount { get; set; }
        
        [StringLength(1)]
        [Required]
        //Possible enum
        public string ItemIsCredit { get; set; }
    }
}
