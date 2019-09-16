using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BridgePayService;

namespace XMLApiProject.Services.Services
{
    public class RequestClientHandlerWrapper: RequestHandlerClient
    {
        public RequestClientHandlerWrapper(): base()
        {

        }

        public async Task<string> ProcessRequest(string requestMsg)
        {
            var encodedRequest = System.Convert.ToBase64String(Encoding.ASCII.GetBytes(requestMsg));
            var response = await base.ProcessRequestAsync(encodedRequest);
            return Encoding.UTF8.GetString(Convert.FromBase64String(response));
        }
    }
}
