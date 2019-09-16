using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.XML.RequestService.Request;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IRequestHandlerRepository
    {
        Task<string> SendRequestAsync(string requestMessage);
        Task<T2> SendRequestAsync<T2>(BaseRequest request);
        Task<T> SendRequestAsync<T>(string requestMessage);
        Task<string> SendRequestAsync(BaseRequest request);

    }
}
