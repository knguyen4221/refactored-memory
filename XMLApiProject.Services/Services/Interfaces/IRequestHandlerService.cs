using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;

namespace XMLApiProject.Services.Services.Interfaces
{
    public interface IRequestHandlerService
    {
        Task<Ping> Ping();
    }
}
