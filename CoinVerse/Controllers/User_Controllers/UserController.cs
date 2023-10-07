using BLL.DTOs.User_DTOs;
using BLL.Services.User_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinVerse.Controllers.User_Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllUser")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = UserService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }



        [HttpGet]
        [Route("api/GetUserById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = UserService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddUser")]
        public HttpResponseMessage Create(UserDTO user)
        {
            try
            {
                UserService.Create(user);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create user" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateUser")]
        public HttpResponseMessage Update(UserDTO user)
        {
            try
            {
                UserService.Update(user);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update user details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteUser/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                UserService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete User" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }
    }
}
