using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Services.Factories
{
    public class BaseRequestFactory: IHasBaseRequest
    {
        private IConfiguration _configuration;

        public BaseRequestFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        BaseRequest IHasBaseRequest.CreateBaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, string requestMessage)
        {
            var baseRequest = new BaseRequest(transactionId, requestDateTime, requestType, requestMessage) {
                User = _configuration.GetSection("Credentials")["userName"],
                Password = _configuration.GetSection("Credentials")["password"]
            };
            return baseRequest;
        }
    }
}
