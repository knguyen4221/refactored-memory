using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request
{
    //Note: Raw XML string let each class handle how it serializes itself. Forget about dealing with 
    //Note: Generally this class isn't really used for deserializing...
    //Note: This is probably a hack
    public class RawRequestMessageString : IXmlSerializable
    {

        public string Value { get; set; }

        public RawRequestMessageString() { }

        public RawRequestMessageString(string value)
        {
            Value = value;
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        //Note: Not really necessary since RawXmlStrings are usually used for sending requests...
        public void ReadXml(XmlReader reader)
        {
            Value = reader.ReadInnerXml();
        }

        public void WriteXml(XmlWriter writer)
        {
            if (string.IsNullOrEmpty(Value))
            {
                return;
            }
            using (var stream = new StringReader(Value))
            using (var reader = XmlReader.Create(stream))
            {
                reader.Read();
                var xmlWithoutParent = reader.ReadInnerXml();
                writer.WriteRaw(xmlWithoutParent);
            }
        }
    }
}
