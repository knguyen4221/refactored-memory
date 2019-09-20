using System;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;
using XMLApiProject.Services.Services.Interfaces;

namespace XMLApiProject.Services.Services
{
    public class RequestHandlerService : IRequestHandlerService
    {

        private IRequestHandlerRepository _requestHandlerRepository;
        private IHasBaseRequest _baseRequestFactory;

        public RequestHandlerService(IRequestHandlerRepository requestHandlerRepository, IHasBaseRequest baseRequestFactory)
        {
            _baseRequestFactory = baseRequestFactory;
            _requestHandlerRepository = requestHandlerRepository;
        }

        //Note: Hits the endpoint but can't generate a key for some reason on their side.
        public async Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey()
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(12345, DateTime.Now, Utilities.Constants.RequestTypes.EncryptionKey, new GenerateEncryptionKeyRequest());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<EncryptionKey>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<GetToken>> GetToken(GetTokenBody request)
        {
            var baseRequest = _baseRequestFactory.CreateAuthorizeBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.MultiUseToken, new MultiUseTokenRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<GetToken>>(baseRequest._requestMessage.GetResponseRootName(),
                baseRequest);
        }

        public async Task<BaseResponse<Ping>> Ping()
        {
            //Note: want to at some point generate the transactionIDs
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234567890, DateTime.Now, Utilities.Constants.RequestTypes.Ping, new PingRequest());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Ping>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Auth>> Capture(AuthorizationBody request)
        {
            var baseRequest = _baseRequestFactory.CreateAuthorizeBaseRequest(123456890, DateTime.Now, Utilities.Constants.RequestTypes.Authorization, new Authorization(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        } 

        public async Task<BaseResponse<Auth>> Track(TrackBody request)
        {
            var baseRequest = _baseRequestFactory.CreateTrackBaseRequest(123456890, DateTime.Now, Utilities.Constants.RequestTypes.Authorization, new Authorization(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
        public async Task<BaseResponse<BINLookup>> BINLookup(BINLookupBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.BINLookup, new BINLookupRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<BINLookup>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<UpdatePassword>> ChangePassword(UpdatePasswordBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.UpdatePassword, new ChangePasswordRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<UpdatePassword>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<MerchantInfo>> GetMerchantInfo(Guid? purchaseToken)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.GetMerchantInfo, new GetMerchantInfoRequest(purchaseToken));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<MerchantInfo>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<VoidRefund>> VoidOrRefund(VoidRefundBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.VoidOrRefund, new VoidOrRefundRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<VoidRefund>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<GetToken>> TokenizeAccount(TokenizeAccountBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.TokenizeAccount, new TokenizeAccountRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<GetToken>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        //Note: Doesn't work with our credentials
        //Note: returns merchant service lookup unavailable
        //Note: Not sure if this endpoint will even be leveraged
        public async Task<BaseResponse<AccountInquiry>> BalanceInquiry(BalanceInquiryBody request)
        {
            var baseRequest = _baseRequestFactory.CreateAuthorizeBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.AccountInquiry, new BalanceInquiryRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<AccountInquiry>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        //Note: Able to hit the endpoint, but can't uniquely hit them....
        public async Task<BaseResponse<Capture>> Capture(CaptureBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(123456, DateTime.Now, Utilities.Constants.RequestTypes.Capture, new CaptureRequest(request, 123456));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Capture>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
	
	    public async Task<BaseResponse<CloseCycle>> InitiateSettlement(InitiateSettlementBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.InitiateSettlement, new InitiateSettlementRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<CloseCycle>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Find>> FindTransaction(FindTransactionBody request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.FindTransaction, new FindTransactionRequest(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Find>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
    }
}
