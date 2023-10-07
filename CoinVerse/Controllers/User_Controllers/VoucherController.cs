using BLL.DTOs.User_DTOs;
using BLL.Services.User_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace CoinVerse.Controllers.User_Controllers
{
    public class VoucherController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllVoucher")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = VoucherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }



        [HttpGet]
        [Route("api/GetVoucherById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = VoucherService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddVoucher")]
        public HttpResponseMessage Create(VoucherDTO V)
        {
            try
            {
                VoucherService.Create(V);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create Voucher" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateVoucher")]
        public HttpResponseMessage Update(VoucherDTO t)
        {
            try
            {
                VoucherService.Update(t);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update Voucher details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteVoucher/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                VoucherService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete Voucher" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
