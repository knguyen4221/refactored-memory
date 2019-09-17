using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Utilities
{
    public class SoapEndpointException : Exception
    {
        public SoapEndpointException(string message) : base(message)
        {
        }
    }
}
