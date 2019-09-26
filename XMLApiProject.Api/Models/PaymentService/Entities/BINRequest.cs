using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class BINRequest: IBINRequest
    {
        [DefaultValue("51496122")]
        public string BIN { get; set; }
    }
}
