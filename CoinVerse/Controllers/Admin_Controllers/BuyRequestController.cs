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
    public class BuyRequestController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllRequest")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = BuyRequestService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetRequestById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = BuyRequestService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddRequest")]
        public HttpResponseMessage Create(BuyRequestDTO request)
        {
            try
            {
                BuyRequestService.Create(request);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateRequest")]
        public HttpResponseMessage Update(BuyRequestDTO request)
        {
            try
            {
                BuyRequestService.Update(request);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });


            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteRequest/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                BuyRequestService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
