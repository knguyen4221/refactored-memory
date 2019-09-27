using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XMLApiProject.Api.Models.PaymentService.Entities;
using XMLApiProject.Services.Services.Interfaces;
using XMLApiProject.Services.Utilities;

namespace XMLApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestHandlerController : ControllerBase
    {
        private IRequestHandlerService _requestHandlerService;

        public RequestHandlerController(IRequestHandlerService requestHandlerService)
        {
            _requestHandlerService = requestHandlerService;
        }

        /// <summary>
        /// Sends a ping request to the BridgePay Gateway
        /// </summary>
        /// <returns></returns>
        [HttpGet("ping")]
        public async Task<ActionResult> Ping()
        {
            try
            {
                var response = await _requestHandlerService.Ping();
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
            
        }

        /// <summary>
        /// Sends a request for a Multi-Use Request Token, which is used to tokenize a single card entry without the CVV
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("multiUseToken")]
        public async Task<ActionResult> GetToken([FromBody]GetTokenRequest request)
        {
            try
            { 
                var response = await _requestHandlerService.GetToken(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        
        /// <summary>
        /// Sends a request to look up the attached BIN, or return Credit if no BIN is defined
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("binLookup")]
        public async Task<ActionResult> BINLookup([FromBody]BINRequest request)
        {
            try
            {
                var response = await _requestHandlerService.BINLookup(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Authorize request with non-swipe
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("authorize")]
        public async Task<ActionResult> Authorize([FromBody]AuthorizationRequest request)
        {
            try
            {
                var response = await _requestHandlerService.Authorize(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Use to tokenize a bank account number for ACH transactions
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("tokenizeAccount")]
        public async Task<ActionResult> TokenizeAccount([FromBody]TokenizeAccountRequest request)
        {
            try
            {
                var response = await _requestHandlerService.TokenizeAccount(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        /// <summary>
        /// Account inquiry request. Mainly just a balance inquiry. Any account inquiries are disabled.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("balanceInquiry")]
        public async Task<ActionResult> BalanceInquiry([FromBody]BalanceInquiryRequest request)
        {
            try
            {
                var response = await _requestHandlerService.BalanceInquiry(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


        // Keeping this inaccessible for now to avoid development issues
        ///// <summary>
        ///// Sends a request to update the user's password
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //[HttpPost("changePassword")]
        //public async Task<ActionResult> ChangePassword([FromBody]NewPasswordRequest request)
        //{
        //    try
        //    {
        //        var response = await _requestHandlerService.ChangePassword(request);
        //        return Ok(response);
        //    }
        //    catch (SoapEndpointException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex);
        //    }
        //}

        /// <summary>
        /// Gets Merchant Info for a merchant with a particular set of credentials
        /// </summary>
        /// <param name="purchaseToken"></param>
        /// <returns></returns>
        [HttpGet("merchantInfo")]
        public async Task<ActionResult> GetMerchantInfo(Guid? purchaseToken)
        {
            try
            {
                var response = await _requestHandlerService.GetMerchantInfo(purchaseToken);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Use the void/refund request to issue a void against an unsettled authorization or a refund against a settled transaction
        /// </summary>
        /// <returns></returns>
        [HttpPost("voidRefund")]
        public async Task<ActionResult> VoidOrRefund([FromBody]VoidRefundRequest request)
        {
            try
            {
                var response = await _requestHandlerService.VoidOrRefund(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Sends a request to initiate a settlement. Unsettled transactions will be submitted to the processors for settlement.
        /// </summary>
        /// <returns></returns>
        [HttpPost("initiateSettlement")]
        public async Task<ActionResult> InitiateSettlement([FromBody]InitiateSettlementRequest request)
        {
            try
            {
                var response = await _requestHandlerService.InitiateSettlement(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Sends a request to find a transaction
        /// </summary>
        /// <returns></returns>
        [HttpPost("findTransaction")]
        public async Task<ActionResult> FindTransaction([FromBody]FindTransactionRequest request)
        {
            try
            {
                var response = await _requestHandlerService.FindTransaction(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /// <summary>
        /// Used to confirm a previously authorized sale. Transactions that are not confirmed will be voided at settlement time.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("capture")]
        public async Task<ActionResult> CaptureRequest([FromBody]CaptureRequest request)
        {
            try
            {
                var response = await _requestHandlerService.Capture(request);
                return Ok(response);
            }
            catch (SoapEndpointException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}