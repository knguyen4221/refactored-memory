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
        Task<BaseResponse<GetToken>> GetToken(IGetTokenRequest request);
        Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey();
        Task<BaseResponse<Auth>> Capture(IAuthorizationRequest request);
        Task<BaseResponse<Capture>> Capture(ICaptureRequest request);
        Task<BaseResponse<Auth>> CaptureSwipe(ITrackRequest request);
        Task<BaseResponse<BINLookup>> BINLookup(IBINRequest request);
        Task<BaseResponse<GetToken>> TokenizeAccount(ITokenizeAccountRequest request);
        Task<BaseResponse<UpdatePassword>> ChangePassword(IUpdatePasswordRequest request);
        Task<BaseResponse<MerchantInfo>> GetMerchantInfo(Guid? purchaseToken);
        Task<BaseResponse<VoidRefund>> VoidOrRefund(IVoidRefundRequest request);
        Task<BaseResponse<AccountInquiry>> BalanceInquiry(IBalanceInquiryRequest request);
        Task<BaseResponse<CloseCycle>> InitiateSettlement(IInitiateSettlementRequest request);
        Task<BaseResponse<Find>> FindTransaction(IFindTransactionRequest request);
    }
}
