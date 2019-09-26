using System;

namespace XMLApiProject.Services.Utilities
{
    public class SoapEndpointException : Exception
    {
        public SoapEndpointException(string message) : base(message)
        {
        }
    }
}
