using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Services
{
    public interface IHasBaseRequest
    {
        BaseRequest CreateBaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, string requestMessage);
    }
}
