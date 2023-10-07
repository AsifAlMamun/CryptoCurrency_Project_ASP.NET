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
    public class SupportTicketController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllTicket")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SupportTicketService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetTicketById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SupportTicketService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddTicket")]
        public HttpResponseMessage Create(SupportTicketDTO ticket)
        {
            try
            {
                SupportTicketService.Create(ticket);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateTicket")]
        public HttpResponseMessage Update(SupportTicketDTO ticket)
        {
            try
            {
                SupportTicketService.Update(ticket);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });


            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteTicket/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                SupportTicketService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpGet]
        [Route("api/SupportTicket/date/{date}")]
        public HttpResponseMessage Get(DateTime date)
        {
            try
            {
                var data = SupportTicketService.Get(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
