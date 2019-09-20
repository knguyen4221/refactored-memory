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
        Task<BaseResponse<GetToken>> GetToken(GetTokenBody request);
        Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey();
        Task<BaseResponse<Auth>> Capture(AuthorizationBody request);
        Task<BaseResponse<Capture>> Capture(CaptureBody request);
        Task<BaseResponse<Auth>> Track(TrackBody request);
        Task<BaseResponse<BINLookup>> BINLookup(BINLookupBody request);
        Task<BaseResponse<GetToken>> TokenizeAccount(TokenizeAccountBody request);
        Task<BaseResponse<UpdatePassword>> ChangePassword(UpdatePasswordBody request);
        Task<BaseResponse<MerchantInfo>> GetMerchantInfo(Guid? purchaseToken);
        Task<BaseResponse<VoidRefund>> VoidOrRefund(VoidRefundBody request);
        Task<BaseResponse<AccountInquiry>> BalanceInquiry(BalanceInquiryBody request);
        Task<BaseResponse<CloseCycle>> InitiateSettlement(InitiateSettlementBody request);
        Task<BaseResponse<Find>> FindTransaction(FindTransactionBody request);
    }
}
