using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Services;
using XMLApiProject.Services.Services.Factories;

namespace XMLApiProject
{
    //Testing Console application for testing things immediately
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();



        }

        static async Task MainAsync()
        {
            var testRequest = new MultiUseTokenRequest
            {
                PaymentAccountNumber = "4111111111111111",
                ExpirationDate = "1222",
                SecurityCode = 999,
            };
            var testRequest2 = new PingRequest();
            var nameSpaces = new XmlSerializerNamespaces();
            nameSpaces.Add("", "");
            var request = new BaseRequest(12345678, DateTime.Now, Services.Utilities.Constants.RequestTypes.MultiUseToken, testRequest)
            {

            };

            var serializer = new XmlSerializer(typeof(BaseRequest), "");
            var setting = new XmlWriterSettings() {
                OmitXmlDeclaration = true
            };
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, setting))
            {
                serializer.Serialize(writer, request, nameSpaces);
                var res = stream.ToString();
            }

            //  var xmlString = @"<requestHeader>
            //    <ClientIdentifier>SOAP</ClientIdentifier> 
            //    <TransactionID>1234567890</TransactionID> 
            //    <RequestType>099</RequestType> 
            //    <RequestDateTime>2019-09-12</RequestDateTime> 
            //    <User>rev099test</User> 
            //    <Password>57!sE@3Fm</Password> 
            //    <requestMessage />
            //</requestHeader>";
            //  var baseRequest = new BaseRequest(1234567890, new DateTime(2019, 9, 12), Services.Utilities.Constants.RequestTypes.Ping, string.Empty)
            //  {
            //      User = "rev099test",
            //      Password = "57!sE@3Fm"
            //  };

            //  var emptyNamespaces = new XmlSerializerNamespaces();
            //  emptyNamespaces.Add("", "");
            //  var serializer = new XmlSerializer(typeof(BaseRequest), "");
            //  var settings = new XmlWriterSettings();
            //  settings.Indent = true;
            //  settings.OmitXmlDeclaration = true;
            //  string res;
            //  using (var stream = new StringWriter())
            //      using(var writer = XmlWriter.Create(stream, settings))
            //  {
            //      serializer.Serialize(writer, baseRequest, emptyNamespaces);
            //      res = stream.ToString();
            //      var service = new RequestClientHandlerWrapper();
            //      var sad = await service.ProcessRequest(res);
            //  }

            //var client = new RequestClientHandlerWrapper();
            //var returnObj = await client.ProcessRequest(xmlString);
            //await client.CloseAsync();
        }
        
    }
}
