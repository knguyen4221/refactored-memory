using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.Entities;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService;
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

        public async Task<BaseResponse<EncryptionKey>> GenerateEncryptionKey()
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(12345, DateTime.Now, Utilities.Constants.RequestTypes.EncryptionKey, new GenerateEncryptionKey());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<EncryptionKey>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<GetToken>> GetToken(GetTokenRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.MultiUseToken,
                new MultiUseTokenRequest()
                {
                    PaymentAccountNumber = request.PaymentAccountNumber,
                    ExpirationDate = request.ExpirationDate.ToString("MMyy")
                });
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<GetToken>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Ping>> Ping()
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234567890, DateTime.Now, Utilities.Constants.RequestTypes.Ping, new PingRequest());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Ping>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<BINLookup>> BINLookup(BINRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.BINLookup,
                new BINLookupRequest()
                {
                    BIN = request.BIN
                });
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<BINLookup>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<UpdatePassword>> ChangePassword(UpdatePasswordRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.UpdatePassword,
                new ChangePasswordRequest()
                {
                    NewPassword = request.NewPassword,
                    ConfirmPassword = request.ConfirmPassword
                });
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<UpdatePassword>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<MerchantInfo>> GetMerchantInfo(GetMerchantRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.GetMerchantInfo, new GetMerchantInfoRequest());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<MerchantInfo>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<VoidRefund>> VoidOrRefund(VoidRefundRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.VoidOrRefund,
                new VoidOrRefundRequest()
                {
                    MerchantCode = request.MerchantCode,
                    MerchantAccountCode = request.MerchantAccountCode,
                    Amount = request.Amount,
                    ReferenceNumber = request.ReferenceNumber,
                    TransactionType = request.TransactionType,
                    TransactionCode = request.TransactionCode,
                    SoftwareVendor = request.SoftwareVendor
                });
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<VoidRefund>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

    }
}
