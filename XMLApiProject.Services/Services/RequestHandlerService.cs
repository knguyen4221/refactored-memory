using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<Ping> Ping()
        {
            var baseRequest = _baseRequestFactory.CreateBaseRequest(1234567890, DateTime.Now, Utilities.Constants.RequestTypes.Ping, "");
            return await _requestHandlerRepository.SendRequestAsync<Ping>(baseRequest);
        }
    }
}
