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
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllEmployee")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetEmployeeById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = EmployeeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddEmployee")]
        public HttpResponseMessage Create(EmployeeDTO employee)
        {
            try
            {
                EmployeeService.Create(employee);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Create employee" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateEmployee")]
        public HttpResponseMessage Update(EmployeeDTO employee)
        {
            try
            {
                EmployeeService.Update(employee);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Update Employee details" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteEmployee/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                EmployeeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Delete Employee" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
