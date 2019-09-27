using Newtonsoft.Json;
using System.ComponentModel;
using XMLApiProject.Services.Models.PaymentService.Entities;

namespace XMLApiProject.Api.Models.PaymentService.Entities
{
    public class BINRequest: IBINRequest
    {
        [DefaultValue("51496122")]
        public string Bin { get; set; }
        [JsonIgnore]
        public string BIN { get { return Bin; } set { Bin = value; } }
    }
}
