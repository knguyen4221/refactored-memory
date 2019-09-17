using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public abstract class RequestMessageBase
    {
        public virtual RawRequestMessageString ToXmlRequestString<T>()
        {
            var xmlSerializer = new XmlSerializer(typeof(T), "");
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");
            var xmlWriterSettings = new XmlWriterSettings()
            {
                Indent = false,
                OmitXmlDeclaration = true
            };
            using (var stream = new StringWriter())
            using (var xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
            {
                xmlSerializer.Serialize(xmlWriter, this, namespaces);
                var test = stream.ToString();
                //Note: this leads to a coupling between RawXmlString and most xml request types
                return new RawRequestMessageString(stream.ToString());
            }
        }
    }
}
