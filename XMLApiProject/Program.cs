using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Services;

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
            var xmlString = @"<requestHeader>
              <ClientIdentifier>SOAP</ClientIdentifier> 
              <TransactionID>1234567890</TransactionID> 
              <RequestType>099</RequestType> 
              <RequestDateTime>2019-09-12</RequestDateTime> 
              <User>rev099test</User> 
              <Password>57!sE@3Fm</Password> 
              <requestMessage />
          </requestHeader>";
            var baseRequest = new BaseRequest(1234567890, new DateTime(2019, 9, 12), Services.Utilities.Constants.RequestTypes.Ping, string.Empty)
            {
                User = "rev099test",
                Password = "57!sE@3Fm"
            };
            
            var emptyNamespaces = new XmlSerializerNamespaces();
            emptyNamespaces.Add("", "");
            var serializer = new XmlSerializer(typeof(BaseRequest), "");
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            string res;
            using (var stream = new StringWriter())
                using(var writer = XmlWriter.Create(stream, settings))
            {
                serializer.Serialize(writer, baseRequest, emptyNamespaces);
                res = stream.ToString();
                var service = new RequestClientHandlerWrapper();
                var sad = await service.ProcessRequest(res);
            }

            //var client = new RequestClientHandlerWrapper();
            //var returnObj = await client.ProcessRequest(xmlString);
            //await client.CloseAsync();
        }
        
    }
}
