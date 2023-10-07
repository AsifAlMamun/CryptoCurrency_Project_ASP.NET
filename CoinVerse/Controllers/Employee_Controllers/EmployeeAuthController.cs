using BLL.Services.Employee_Services;
using BLL.Services.User_Services;
using CoinVerse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CoinVerse.Controllers.Employee_Controllers
{
    [EnableCors("*", "*", "*")]
    public class EmployeeAuthController : ApiController
    {
        [HttpPost]
        [Route("api/EmployeeLogin")]
        public HttpResponseMessage Login(LoginModel data)
        {
            var token = EmployeeAuthService.Login(data.Username, data.Password);

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
