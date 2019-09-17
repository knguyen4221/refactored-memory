using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;

namespace XMLApiProject.Services.Models.PaymentService.Interfaces
{
    public interface IXmlRequestTranslatable
    {
        RawRequestMessageString ToXmlRequestString();
    }
}
