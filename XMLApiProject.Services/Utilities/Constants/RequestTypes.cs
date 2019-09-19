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
        ManageGiftCard = 014,
        Capture = 019,
        InitiateSettlement = 020,
        Ping = 099,
        AccountInquiry = 015,
        TokenizeAccount = 013
    }
}
