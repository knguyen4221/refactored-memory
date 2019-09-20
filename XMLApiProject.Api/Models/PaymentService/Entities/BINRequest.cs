using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class BINRequest: IBINRequest
    {
        public string BIN { get; set; }
    }
}
