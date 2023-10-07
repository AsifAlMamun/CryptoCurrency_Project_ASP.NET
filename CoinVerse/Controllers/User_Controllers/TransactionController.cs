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
    public class TransactionController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllTransaction")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TransactionService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }



        [HttpGet]
        [Route("api/GetTransactionById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = TransactionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddTransaction")]
        public HttpResponseMessage Create(TransactionDTO t)
        {
            try
            {
                TransactionService.Create(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create transaction" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateTransaction")]
        public HttpResponseMessage Update(TransactionDTO t)
        {
            try
            {
                TransactionService.Update(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update Transaction details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteTransaction/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                TransactionService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete transaction" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
