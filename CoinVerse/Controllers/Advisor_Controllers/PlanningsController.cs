using BLL.DTOs.Advisor_DTOs;
using BLL.Services.Advisor_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinVerse.Controllers.Advisor_Controllers
{
    public class PlanningsController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllPlanDetails")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PlanningsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }
        [HttpGet]
        [Route("api/GetPlanDetailsByID/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = PlanningsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddPlan")]
        public HttpResponseMessage Create(PlanningsDTO planning)
        {
            try
            {
                PlanningsService.Create(planning);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdatePlan")]
        public HttpResponseMessage Update(PlanningsDTO planning)
        {
            try
            {
                PlanningsService.Update(planning);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeletePlan/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                PlanningsService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
