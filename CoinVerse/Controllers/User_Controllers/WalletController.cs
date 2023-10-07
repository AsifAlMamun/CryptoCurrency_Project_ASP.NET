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
    public class WalletController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllWallet")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = WalletService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }



        [HttpGet]
        [Route("api/GetWalletById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = WalletService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddWallet")]
        public HttpResponseMessage Create(WalletDTO w)
        {
            try
            {
                WalletService.Create(w);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create wallet" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateWallet")]
        public HttpResponseMessage Update(WalletDTO w)
        {
            try
            {
                WalletService.Update(w);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update wallet details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteWallet/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                WalletService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete wallet" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
