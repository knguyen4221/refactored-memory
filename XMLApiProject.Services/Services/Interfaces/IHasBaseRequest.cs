﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XMLApiProject.Services.Models.PaymentService.Interfaces;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Request;
using XMLApiProject.Services.Models.PaymentService.XML.RequestService.Responses;
using XMLApiProject.Services.Models.XML.RequestService.Request;
using XMLApiProject.Services.Utilities.Constants;

namespace XMLApiProject.Services.Services
{
    public interface IHasBaseRequest
    {
        BaseRequest CreateBaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage);
        /// <summary>
        /// Temp fix for authorize not working with our own credentials
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestDateTime"></param>
        /// <param name="requestType"></param>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        BaseRequest CreateAuthorizeBaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage);

        /// <summary>
        /// Temp fix fortrack not working with our own credentials
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestDateTime"></param>
        /// <param name="requestType"></param>
        /// <param name="requestMessage"></param>
        /// <returns></returns>
        BaseRequest CreateTrackBaseRequest(int transactionId, DateTime requestDateTime, RequestTypes requestType, RequestMessageBase requestMessage);
    }
}
