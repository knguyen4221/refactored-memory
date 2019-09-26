using System.Threading.Tasks;
using XMLApiProject.Services.Models.XML.RequestService.Request;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IRequestHandlerRepository
    {
        Task<string> SendRequestAsync(string requestMessage);
        Task<T2> SendRequestAsync<T2>(string responseRootName, BaseRequest request);
        Task<T> SendRequestAsync<T>(string responseRootName, string requestMessage);
        Task<string> SendRequestAsync(BaseRequest request);

    }
}
