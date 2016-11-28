using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Enqueue.Data;
using Enqueue.Data.Repositories;


namespace Enqueue.Controllers
{
   
    public class TokenController : BaseController
    {

       
        [Route("api/token/get/{providerId}/{consumerId}/{locationId}/{patientName}/{phone}/{onlineToken}")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        public HttpResponseMessage GetToken(int providerId, int consumerId,int locationId,string patientName,string phone, bool onlineToken)
        {
            try
            {
                var repo = new TokenRepo();
                string message = "";
                int status = 1;
                var result = repo.GetToken(providerId, consumerId, locationId, patientName, phone, onlineToken);

                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = status,
                        data =
                            new
                            {
                                yourToken = result.YourToken,
                                currentToken = result.CurrentToken,
                                next_available = result.NextAvailble,
                                token_id = result.Token_Id,
                                date = result.Today,
                                message = message
                            },
                        msg = message
                    });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 0,
                        data =
                            new
                            {
                                yourToken = -1,
                                currentToken = -1,
                                message = ex.StackTrace
                            },
                        msg = ex.Message
                    });
            }
        }

       
        [Route("api/token/nowserving/{providerId}/{consumerId}/{locationId}")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        public HttpResponseMessage GetCurrentToken(int providerId, int consumerId, int locationId)
        {
            var repo = new TokenRepo();
            string message = "";
            int status = 1;
            var result = repo.GetCurrentToken(consumerId, locationId, providerId);
            if (result.NextToken == -1 && result.CurrentToken == -1)
            {
                status = 0;
                message = "Booking not started yet";
                return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = status,
                    data =
                        new
                        {
                            now_serving = result.CurrentToken,
                            available_token = result.NextAvailable,
                            your_token = result.YourToken,
                            current_token_id = result.CurrentTokenId,
                            your_token_id = result.YourTokenId,
                            message = message
                        },
                    msg = message
                });
            }
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = status,
                    data =
                        new
                        {
                            now_serving = result.CurrentToken,
                            available_token = result.NextAvailable,
                            your_token = result.YourToken,
                            current_token_id = result.CurrentTokenId,
                            your_token_id = result.YourTokenId,
                            message = message
                        },
                    msg = message
                });
        }

        [Route("api/token/completeskip/{tokenId}/{complete}/{rating}/{comments}")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        public HttpResponseMessage UpdateTokenComments(int tokenid,bool complete ,int rating,string comments)
        {
            var repo = new TokenRepo();
            
            int status = 1;
            var result = repo.UpdateTokenComments(tokenid, complete,rating, comments);
           string message = result? "Saved": "Error";
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = status,
                    data =
                        new
                        {
                            data= "",
                            message = message
                        },
                    msg = message
                });
        }

        [Route("api/token/paytoken/{tokenId}/{followUp}/{amount}")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        public HttpResponseMessage UpdateTokenPayment(int tokenid, bool followUp, decimal amount)
        {
            var repo = new TokenRepo();

            int status = 1;
            var result = repo.UpdateTokenPayment(tokenid, followUp, amount);
            string message = result ? "Saved" : "Error";
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = status,
                    data =
                        new
                        {
                            data = "",
                            message = message
                        },
                    msg = message
                });
        }
       
    }
}