using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XMLApiProject.Services.Models.PaymentService.Entities;
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
        /// Sends a request for a Multi-Use Request Token
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
        /// Generate Encryption Key request. Note: However unusable because there's a key missing? Not sure.
        /// </summary>
        /// <returns></returns>
        [HttpGet("encryptionKey")]
        public async Task<ActionResult> GenerateEncryptionKey()
        {
            try
            {
                var response = await _requestHandlerService.GenerateEncryptionKey();
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
        /// Public track request...One of the sampel operations
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("trackData")]
        public async Task<ActionResult> TrackData([FromBody] TrackRequest request)
        {
            try
            {
                var response = await _requestHandlerService.Track(request);
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

        [HttpPost("capture")]
        public async Task<ActionResult> Capture([FromBody] AuthorizationRequest request)
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
    }
}