using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using XMLApiProject.Services.Models.PaymentService.Interfaces;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    public abstract class RequestMessageBase: ICanGetResponseRootName, IXmlRequestTranslatable
    {
        public abstract string GetResponseRootName();
        public abstract RawRequestMessageString ToXmlRequestString();


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
