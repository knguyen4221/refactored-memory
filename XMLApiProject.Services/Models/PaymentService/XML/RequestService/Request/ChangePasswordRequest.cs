using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class ChangePasswordRequest : RequestMessageBase
    {
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public ChangePasswordRequest()
        {
        }

        public ChangePasswordRequest(string newPassword, string confirmPassword)
        {
            NewPassword = newPassword;
            ConfirmPassword = confirmPassword;
        }

        public override string GetResponseRootName()
        {
            return nameof(UpdatePassword);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<ChangePasswordRequest>();
        }
    }
}
