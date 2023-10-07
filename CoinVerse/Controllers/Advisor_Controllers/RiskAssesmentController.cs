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
    public class RiskAssesmentController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllRiskAssesmentDetails")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RiskAssesmentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }
        [HttpGet]
        [Route("api/GetRiskAssesmentByID/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = RiskAssesmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddRiskassesment")]
        public HttpResponseMessage Create(RiskAssesmentDTO riskassesment)
        {
            try
            {
                RiskAssesmentService.Create(riskassesment);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateRiskAssesment")]
        public HttpResponseMessage Update(RiskAssesmentDTO riskassesment)
        {
            try
            {
                RiskAssesmentService.Update(riskassesment);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteRiskAssesment" +
             "/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                RiskAssesmentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}