using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Enqueue.Data;
using Enqueue.Data.Repositories;

namespace Enqueue.Controllers
{
   [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProviderController : BaseController
    {
       /// <summary>
       /// Login Consumer
       /// </summary>
       /// <param name="provider"></param>
       /// <returns></returns>
       [HttpPost]
       [EnableCors(origins: "*", headers: "*", methods: "*")]
       [Route("api/provider/login")]
       public HttpResponseMessage Login(ServiceProvider provider)
       {
           var repo = new ServiceProviderRepo();
           var results = repo.LoginProvider(provider);
           if (results != null)
           {
               return Request.CreateResponse(
                   HttpStatusCode.OK,
                   new
                   {
                       status = 1,
                       data = results,
                       msg = "Successfully Login"
                   });
           }
           return Request.CreateResponse(
               HttpStatusCode.OK,
               new
               {
                   status = 0,
                   data = "",
                   msg = "Invalid usernname or password"
               });
       }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/{Id}")]
        [HttpGet]
        public HttpResponseMessage Search(string Id)
        {
            var repo = new ServiceProviderRepo();

            var result = repo.SearchServiceProvider(Id);
            if (result != null)
            {
                var locations = repo.GetServiceProviderLocations(result.Id);
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,
                        message = "found",
                        data = new
                        {
                            doctor = new
                            {
                                doc_id = result.Id,
                                doc_code = result.Code,
                                name = result.Name,
                                email = result.Email,
                                phone = result.ContactNo,
                                qualification = result.Qualification
                            },
                            locations = locations
                        },                        
                    });
            }
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = 0,
                    message = "Doctor not found",
                    data = "",                    
                });
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/location/{locationId}/{providerId}")]
        [HttpGet]
        public HttpResponseMessage GetLocationDetails(int locationId,int providerId)
        {
            var repo = new ServiceProviderRepo();

            var result = repo.GetLocationsDetails(locationId, providerId);
            if (result != null)
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,
                        message = "found",
                        data =result,
                    });
            }
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = 0,
                    message = "Location not found",
                    data = "",
                });
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/token/list/{locationId}/{providerId}")]
        [HttpGet]
        public HttpResponseMessage GetTodaysTokens(int locationId, int providerId)
        {
            var repo = new ServiceProviderRepo();

            var result = repo.GetTodaysTokens(locationId, providerId);
            if (result != null)
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,
                        message = "found",
                        data = result,
                    });
            }
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = 0,
                    message = "Couldn't retrieve",
                    data = "",
                });
        }
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/token/next/{tokenId}/{status}")]
        [HttpGet]
        public HttpResponseMessage Next(int tokenId,int status)
        {
            var repo = new ServiceProviderRepo();

            var result = repo.Next(tokenId, status);
            if (result >0)
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,
                        message = "Complted",
                        data =result,
                    });
            }
            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = 0,
                    message = "Next Failed",
                    data = "",
                });
        } 
        
       [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/booking/start/{providerId}/{locationId}")]
        [HttpGet]
        public HttpResponseMessage StartBooking(int providerId, int locationId)
        {
            var repo = new ServiceProviderRepo();
            var result = repo.StartBooking(providerId, locationId);

            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = "success",
                    data =
                        new
                        {
                            message = result
                        }
                });
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/booking/close/{providerId}/{locationId}")]
        [HttpGet]
        public HttpResponseMessage CloseBooking(int providerId, int locationId)
        {
            var repo = new ServiceProviderRepo();
            var result = repo.CloseBooking(providerId, locationId);

            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = "success",
                    data =
                        new
                        {
                            message = result
                        }
                });
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/session/start/{providerId}/{locationId}")]
        [HttpGet]
        public HttpResponseMessage StartSession(int providerId, int locationId)
        {
            var repo = new ServiceProviderRepo();
            var result = repo.StartSession(providerId, locationId);

            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = "success",
                    data =
                        new
                        {
                            message = result
                        }
                });
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/provider/session/close/{providerId}/{locationId}")]
        [HttpGet]
        public HttpResponseMessage CloseSession(int providerId, int locationId)
        {
            var repo = new ServiceProviderRepo();
            var result = repo.CloseSession(providerId, locationId);

            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = "success",
                    data =
                        new
                        {
                            message = result
                        }
                });
        }
    }
}
