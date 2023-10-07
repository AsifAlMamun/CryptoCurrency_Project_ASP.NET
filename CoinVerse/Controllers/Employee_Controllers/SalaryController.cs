using BLL.DTOs.Employee_DTOs;
using BLL.Services.Employee_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CoinVerse.Controllers.Employee_Controllers
{
    public class SalaryController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllSalary")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SalaryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetSalaryById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SalaryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddSalary")]
        public HttpResponseMessage Create(SalaryDTO salary)
        {
            try
            {
                SalaryService.Create(salary);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create Employee Salary" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateSalary")]
        public HttpResponseMessage Update(SalaryDTO salary)
        {
            try
            {
                SalaryService.Update(salary);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update Employee Salary details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpDelete]
        [Route("api/DeleteSalary/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                SalaryService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete Employee Salary" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

    }
}
