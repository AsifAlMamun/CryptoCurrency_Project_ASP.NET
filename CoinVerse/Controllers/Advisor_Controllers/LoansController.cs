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
    public class LoansController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllLoanDetails")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = LoansService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }
        [HttpGet]
        [Route("api/GetLoandetailsByID/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = LoansService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddLoan")]
        public HttpResponseMessage Create(LoanDTO loan)
        {
            try
            {
                LoansService.Create(loan);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateLoan")]
        public HttpResponseMessage Update(LoanDTO loan)
        {
            try
            {
                LoansService.Update(loan);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteLoan/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                LoansService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
