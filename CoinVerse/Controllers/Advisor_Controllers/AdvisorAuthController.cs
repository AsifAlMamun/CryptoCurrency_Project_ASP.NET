using BLL.Services;
using BLL.Services.Advisor_Services;
using CoinVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CoinVerse.Controllers.Advisor_Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdvisorAuthController : ApiController
    {
        [HttpPost]
        [Route("api/AdvisorLogin")]
        public HttpResponseMessage Login(LoginModel data)
        {
            var token = AdvisorAuthService.Login(data.Username, data.Password);

            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { Msg = "User Not Found" });
            }
        }
    }
}
