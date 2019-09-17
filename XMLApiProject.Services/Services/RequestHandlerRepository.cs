using BridgePayService;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Services.Interfaces;
using XMLApiProject.Services.Utilities;

namespace XMLApiProject.Services.Services
{
    public class RequestHandlerRepository: IRequestHandlerRepository
    {
        private IRequestHandler _client;
        private IHasBaseRequest _baseRequestFactory;
        private string _requestHandlerErrorResponse;
        public RequestHandlerRepository(IRequestHandler client, IHasBaseRequest baseRequestFactory, IConfiguration configuration)
        {
            _client = client;
            _baseRequestFactory = baseRequestFactory;
            _requestHandlerErrorResponse = configuration.GetSection("RequestServiceConfiguration")["errorElement"];
        }

        /// <summary>
        /// Send request with already serialized XML
        /// </summary>
        /// <param name="requestMsg"></param>
        /// <returns></returns>
        public async Task<string> SendRequestAsync(string requestMsg)
        {
            var encodedRequest = System.Convert.ToBase64String(Encoding.ASCII.GetBytes(requestMsg));
            var response = await _client.ProcessRequestAsync(encodedRequest);
            var decodedResponse = Encoding.UTF8.GetString(Convert.FromBase64String(response));
            if (decodedResponse.StartsWith(_requestHandlerErrorResponse))
            {
                throw new SoapEndpointException(decodedResponse);
            }
            return decodedResponse;
        }

        public async Task<string> SendRequestAsync(BaseRequest request)
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");
            var serializer1 = new XmlSerializer(typeof(BaseRequest), "");
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true
            };
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer1.Serialize(writer, request, namespaces);
                var res = stream.ToString();
                return await SendRequestAsync(res);
            }
        }

        /// <summary>
        /// Sends request using BridgePay connected service with already serialized XML
        /// </summary>
        /// <typeparam name="T">The type you want it to return</typeparam>
        /// <param name="responseRootName">The root element of the response that's coming back</param>
        /// <param name="requestMessage">The xml serialized request</param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(string responseRootName, string requestMsg)
        {
            var decodedResponse = await SendRequestAsync(requestMsg);
            T response;
            using(var stream = new StringReader(decodedResponse))
            {
                XmlSerializer serializer;
                if (!string.IsNullOrEmpty(responseRootName)) { 
                    serializer = new XmlSerializer(typeof(T),
                        new XmlRootAttribute { ElementName = responseRootName }); //It's almost always going to be deserializing as BaseResponse<T>
                }
                else
                {
                    serializer = new XmlSerializer(typeof(T), "");
                }
                response = (T)serializer.Deserialize(stream);
            }
            return response;
        }

        /// <summary>
        /// Sends request using BridgePay connected service with a BaseRequestObject
        /// </summary>
        /// <typeparam name="T">The object we want to send</typeparam>
        /// <typeparam name="R">The object we want back</typeparam>
        /// <param name="responseRootName">The root element name of the response coming back</param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<T2> SendRequestAsync<T2>(string responseRootName, BaseRequest request)
        {
            var serializer1 = new XmlSerializer(typeof(BaseRequest));
            var settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true
            };
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, settings))
            {
                serializer1.Serialize(writer, request);
                var res = stream.ToString();
                return await SendRequestAsync<T2>(responseRootName, res);
            }
        }
    }
}
