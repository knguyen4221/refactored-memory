using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IRequestHandlerService
    {
        Task<BaseResponse<Ping>> Ping();
        Task<BaseResponse<GetToken>> GetToken(GetTokenRequest request);
        Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey();
    }
}
