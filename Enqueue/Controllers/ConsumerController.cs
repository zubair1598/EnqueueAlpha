using System;
using System.Collections.Generic;
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
    public class ConsumerController : ApiController
    {
        /// <summary>
        /// Register Consumer
        /// </summary>
        /// <param name="consumer"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/consumer/register")]
        public HttpResponseMessage Register(Consumer consumer)
        {
            var repo = new ConsumerRepo();
            var results = repo.RegisterConsumer(consumer);
            if (results.Equals("success"))
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,
                        data = "",
                        msg= "Register Successfully" 
                    });
            }

            return Request.CreateResponse(
                HttpStatusCode.OK,
                new
                {
                    status = 1,
                    data = "",
                    msg=results
                });
        }

        /// <summary>
        /// Login Consumer
        /// </summary>
        /// <param name="consumer"></param>
        /// <returns></returns>
        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/consumer/login")]
        public HttpResponseMessage Login(Consumer consumer)
        {
            var repo = new ConsumerRepo();
            var results = repo.LoginConsumer(consumer);
            if (results!=null)
            {
                return Request.CreateResponse(
                    HttpStatusCode.OK,
                    new
                    {
                        status = 1,                       
                        data = new {user_id = results.Id,
                            user_name=results.UserName,
                            full_name = results.FullName,
                            email=results.Email,
                            phone = results.Phone,
                            active = results.isActive
                        },
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
    }
}

