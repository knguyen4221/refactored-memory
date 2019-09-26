using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Services.Factories
{
    public class BaseRequestFactory : IHasBaseRequest
    {
        private IConfiguration _configuration;

        public BaseRequestFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public BaseRequest CreateBaseRequest(Guid transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage)
        {
            var baseRequest = new BaseRequest(transactionId, requestDateTime, requestType, requestMessage)
            {
                User = _configuration.GetSection("Credentials")["userName"],
                Password = _configuration.GetSection("Credentials")["password"]
            };
            return baseRequest;
        }

        public BaseRequest CreateAuthorizeBaseRequest(Guid transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage)
        {
            var baseRequest = new BaseRequest(transactionId, requestDateTime, requestType, requestMessage)
            {
                User = "dhaaspgtest1",
                Password = _configuration.GetSection("Credentials")["password"]
            };
            return baseRequest;
        }

        public BaseRequest CreateTrackBaseRequest(Guid transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage)
        {
            var baseRequest = new BaseRequest(transactionId, requestDateTime, requestType, requestMessage)
            {
                User = "bpntest",
                Password = _configuration.GetSection("Credentials")["password"]
            };
            return baseRequest;
        }

        public BaseRequest CreateBaseRequest(DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage)
        {
            var generatedGuid = Guid.NewGuid();
            return CreateBaseRequest(generatedGuid, requestDateTime, requestType, requestMessage);
        }
    }
}
