using Microsoft.Extensions.Configuration;
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
        private IConfiguration _configuration;

        public RequestHandlerService(IRequestHandlerRepository requestHandlerRepository, IHasBaseRequest baseRequestFactory, IConfiguration configuration)
        {
            _baseRequestFactory = baseRequestFactory;
            _requestHandlerRepository = requestHandlerRepository;
            _configuration = configuration;
        }

        //Note: Hits the endpoint but can't generate a key for some reason on their side.
        public async Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey()
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(DateTime.Now, Utilities.Constants.RequestTypes.EncryptionKey, 
                new GenerateEncryptionKeyRequestMessage());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<EncryptionKey>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<GetToken>> GetToken(IGetTokenRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(DateTime.Now, Utilities.Constants.RequestTypes.MultiUseToken, 
                new MultiUseTokenRequestMessage(request, _configuration.GetSection("Credentials")["merchantAccountCode"],
                _configuration.GetSection("Credentials")["merchantCode"]));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<GetToken>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Ping>> Ping()
        {
            //Note: want to at some point generate the transactionIDs
            var baseRequest = _baseRequestFactory.CreateBaseRequest(DateTime.Now, Utilities.Constants.RequestTypes.Ping, new PingRequestMessage());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Ping>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        //Note: uses authorize request
        public async Task<BaseResponse<Auth>> Capture(IAuthorizationRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.Authorization,
                new AuthorizationRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        } 

        public async Task<BaseResponse<Auth>> CaptureSwipe(IAuthorizeSwipe request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.Authorization, new AuthorizationRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
        public async Task<BaseResponse<BINLookup>> BINLookup(IBINRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.BINLookup, new BINLookupRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<BINLookup>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<UpdatePassword>> ChangePassword(IUpdatePasswordRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.UpdatePassword, new ChangePasswordRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<UpdatePassword>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<MerchantInfo>> GetMerchantInfo(Guid? purchaseToken)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.GetMerchantInfo, 
                new GetMerchantInfoRequestMessage(purchaseToken));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<MerchantInfo>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<VoidRefund>> VoidOrRefund(IVoidRefundRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.VoidOrRefund, new VoidOrRefundRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<VoidRefund>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<GetToken>> TokenizeAccount(ITokenizeAccountRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.TokenizeAccount, new TokenizeAccountRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<GetToken>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        //Note: Doesn't work with our credentials
        //Note: returns merchant service lookup unavailable
        //Note: Not sure if this endpoint will even be leveraged
        public async Task<BaseResponse<AccountInquiry>> BalanceInquiry(IBalanceInquiryRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(Guid.NewGuid(), DateTime.Now, Utilities.Constants.RequestTypes.AccountInquiry,
                new BalanceInquiryRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<AccountInquiry>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        //Note: Able to hit the endpoint, but can't uniquely hit them....
        public async Task<BaseResponse<Capture>> Capture(ICaptureRequest request)
        {
            var generatedGuid = Guid.NewGuid();
            var baseRequest = _baseRequestFactory.CreateBaseRequest(generatedGuid, DateTime.Now, Utilities.Constants.RequestTypes.Capture,
                new CaptureRequestMessage(request, generatedGuid));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Capture>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
	
	    public async Task<BaseResponse<CloseCycle>> InitiateSettlement(IInitiateSettlementRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(DateTime.Now, Utilities.Constants.RequestTypes.InitiateSettlement, 
                new InitiateSettlementRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<CloseCycle>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Find>> FindTransaction(IFindTransactionRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(DateTime.Now, Utilities.Constants.RequestTypes.FindTransaction,
                new FindTransactionRequestMessage(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Find>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
    }
}
