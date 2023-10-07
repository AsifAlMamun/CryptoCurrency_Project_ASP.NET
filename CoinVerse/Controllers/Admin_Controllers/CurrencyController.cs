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
    public class CurrencyController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllCurrency")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CurrencyService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetCurrencyById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = CurrencyService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddCurrency")]
        public HttpResponseMessage Create(CurrencyDTO currency)
        {
            try
            {
                CurrencyService.Create(currency);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateCurrency")]
        public HttpResponseMessage Update(CurrencyDTO currency)
        {
            try
            {
                CurrencyService.Update(currency);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteCurrency/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                CurrencyService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    
    }
}
