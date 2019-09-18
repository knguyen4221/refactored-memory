﻿using System;
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
            //Note: want to at some point generate the transactionIDs
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234567890, DateTime.Now, Utilities.Constants.RequestTypes.Ping, new PingRequest());
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Ping>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }

        public async Task<BaseResponse<Auth>> Capture(AuthorizationRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateAuthorizeBaseRequest(123456890, DateTime.Now, Utilities.Constants.RequestTypes.Authorization,
                new Authorization(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        } 

        public async Task<BaseResponse<Auth>> Track(TrackRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateTrackBaseRequest(123456890, DateTime.Now, Utilities.Constants.RequestTypes.Authorization,
                new Authorization(request));
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<Auth>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
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

        public async Task<BaseResponse<ChangePassword>> ChangePassword(NewPasswordRequest request)
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234, DateTime.Now, Utilities.Constants.RequestTypes.UpdatePassword,
                new ChangePasswordRequest()
                {
                    NewPassword = request.NewPassword,
                    ConfirmPassword = request.ConfirmPassword
                });
            return await _requestHandlerRepository.SendRequestAsync<BaseResponse<ChangePassword>>(baseRequest._requestMessage.GetResponseRootName(), baseRequest);
        }
    }
}
