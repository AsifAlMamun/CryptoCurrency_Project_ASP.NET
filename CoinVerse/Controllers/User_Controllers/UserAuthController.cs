using BLL.Services.Advisor_Services;
using BLL.Services.User_Services;
using CoinVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CoinVerse.Controllers.User_Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserAuthController : ApiController
    {
        [HttpPost]
        [Route("api/UserLogin")]
        public HttpResponseMessage Login(LoginModel data)
        {
            var token = UserAuthService.Login(data.Username, data.Password);

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
