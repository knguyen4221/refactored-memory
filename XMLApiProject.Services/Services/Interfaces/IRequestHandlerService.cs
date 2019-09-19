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
        Task<BaseResponse<Auth>> Capture(AuthorizationRequest request);
        Task<BaseResponse<Auth>> Track(TrackRequest request);
        Task<BaseResponse<BINLookup>> BINLookup(BINRequest request);
        Task<BaseResponse<GetToken>> TokenizeAccount(TokenizeAccountRequest request);
        Task<BaseResponse<UpdatePassword>> ChangePassword(UpdatePasswordRequest request);
        Task<BaseResponse<MerchantInfo>> GetMerchantInfo(Guid? purchaseToken);
        Task<BaseResponse<VoidRefund>> VoidOrRefund(VoidRefundRequest request);
        Task<BaseResponse<CloseCycle>> InitiateSettlement(InitiateSettlement request);
        Task<BaseResponse<Find>> FindTransaction(FindTransaction request);
    }
}
