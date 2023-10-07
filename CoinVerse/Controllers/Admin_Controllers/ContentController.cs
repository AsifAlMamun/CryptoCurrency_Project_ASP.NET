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
    public class ContentController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllContent")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ContentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/GetContentById/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ContentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/AddContent")]
        public HttpResponseMessage Create(ContentDTO content)
        {
            try
            {
                ContentService.Create(content);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/UpdateContent")]
        public HttpResponseMessage Update(ContentDTO content)
        {
            try
            {
                ContentService.Update(content);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });


            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/DeleteContent/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                ContentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        /*  [HttpGet]
          [Route("api/SearchContent")]
          public HttpResponseMessage GetContents(
          string searchTerm = "",
          string sortBy = "Title",
          bool ascending = true,
          int page = 1,
          int pageSize = 10)
          {
              var query = _dbContext.Contents
                  .Where(c =>
                      c.Title.Contains(searchTerm) ||
                      c.Body.Contains(searchTerm) ||
                      c.Author.Contains(searchTerm))
                  .OrderByProperty(sortBy, ascending);

              var totalCount = query.Count();

              var contents = query
                  .Skip((page - 1) * pageSize)
                  .Take(pageSize)
                  .ToList();

              var response = new
              {
                  TotalCount = totalCount,
                  Page = page,
                  PageSize = pageSize,
                  Contents = contents
              };

              return Ok(response);
          }
      }*/


        [HttpGet]
        [Route("api/Content/title/{title}")]
        public HttpResponseMessage Get(string title)
        {
            try
            {
                var data = ContentService.Get(title);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



    }
}
