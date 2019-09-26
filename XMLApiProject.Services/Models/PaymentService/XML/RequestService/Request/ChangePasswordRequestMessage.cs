using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public class ChangePasswordRequestMessage : RequestMessageBase
    {
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public ChangePasswordRequestMessage()
        {
        }

        public ChangePasswordRequestMessage(string newPassword, string confirmPassword)
        {
            NewPassword = newPassword;
            ConfirmPassword = confirmPassword;
        }

        public ChangePasswordRequestMessage(IUpdatePasswordRequest request)
        {
            NewPassword = request.NewPassword;
            ConfirmPassword = request.ConfirmPassword;
        }

        public override string GetResponseRootName()
        {
            return nameof(UpdatePassword);
        }

        public override RawRequestMessageString ToXmlRequestString()
        {
            return ToXmlRequestString<ChangePasswordRequestMessage>();
        }
    }
}
