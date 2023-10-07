using BLL.DTOs.Admin_DTOs;
using BLL.Services.Admin_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinVerse.Controllers.Admin_Controllers
{
    public class AdminController : ApiController
    {

        [HttpGet]
        [Route("api/GetAdminById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/Addadmin")]
        public HttpResponseMessage Create(AdminDTO admin)
        {
            try
            {
                AdminService.Create(admin);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpDelete]
        [Route("api/DeleteAdmin/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }




    }
}
