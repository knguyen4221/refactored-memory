using System;
using System.Collections.Generic;
using System.Text;

namespace XMLApiProject.Services.Utilities.Constants
{
    public enum RequestTypes
    {
        MultiUseToken = 001,
        EncryptionKey = 003,
        Authorization = 004,
        BINLookup = 005,
        UpdatePassword = 007,
        GetMerchantInfo = 011,
        VoidOrRefund = 012,
        TokenizeAccount = 013,
        ManageGiftCard = 014,
        AccountInquiry = 015,
        Capture = 019,
        InitiateSettlement = 020,
        FindTransaction = 023,
        Ping = 099
    }
}
