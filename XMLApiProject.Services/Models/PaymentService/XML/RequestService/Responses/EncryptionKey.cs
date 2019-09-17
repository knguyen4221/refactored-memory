using System;
using System.Collections.Generic;
using System.Text;
using XMLApiProject.Services.Models.PaymentService.Interfaces;

namespace XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses
{
    public class EncryptionKey
    {
        public string Algorithm { get; set; }
        public DateTime CreateDate { get; set; }
        public uint ID { get; set; }
        public uint KeySize { get; set; }
        public string PublicKey { get; set; }

        public EncryptionKey() { }

    }
}
