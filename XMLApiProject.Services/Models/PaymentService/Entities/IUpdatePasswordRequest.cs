using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Models.PaymentService.Entities
{
    public interface IUpdatePasswordRequest
    {
        string NewPassword { get; set; }
        string ConfirmPassword { get; set; }
    }
}
