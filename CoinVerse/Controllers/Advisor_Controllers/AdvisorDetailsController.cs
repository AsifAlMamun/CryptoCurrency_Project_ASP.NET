using BLL.DTOs.Advisor_DTOs;
using BLL.Services.Advisor_Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace CoinVerse.Controllers.Advisor_Controllers
{
    public class AdvisorDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/GetAllAdvisorDetails")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdvisorDetailervice.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);



            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }



        }
        [HttpGet]
        [Route("api/GetAdvisorDetailsByID/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AdvisorDetailervice.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPost]
        [Route("api/AddAdvisor")]
        public HttpResponseMessage Create(AdvisorDetailsDTO advisorDetails)
        {
            try
            {
                AdvisorDetailervice.Create(advisorDetails);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Created" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpPut]
        [Route("api/UpdateAdvisor")]
        public HttpResponseMessage Update(AdvisorDetailsDTO advisorDetails)
        {
            try
            {
                AdvisorDetailervice.Update(advisorDetails);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Updated" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }



        [HttpDelete]
        [Route("api/DeleteAdvisor/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                AdvisorDetailervice.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Deleted" });
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPost]
        [Route("api/SendEmail")]
        public IHttpActionResult SendEmail(EmailModel emailModel)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                string smtpUsername = "zahidhasanaiubedu@gmail.com";
                string smtpPassword = "djnobhbrdcioppjc";



                using (SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    smtpClient.EnableSsl = true;



                    using (MailMessage mailMessage = new MailMessage())
                    {
                        mailMessage.From = new MailAddress(smtpUsername);
                        mailMessage.To.Add(emailModel.To);
                        mailMessage.Subject = emailModel.Subject;
                        mailMessage.Body = emailModel.Body;
                        mailMessage.IsBodyHtml = true;



                        smtpClient.Send(mailMessage);
                    }
                }



                return Ok("Email sent successfully");
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    

    public class EmailModel
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }






  /*  [HttpPost]
    [Route("/api/CoinVerse/FileUpload")]
    public Task<IHttpActionResult> FileUpload()
    {
        List<string> savedFilePath = new List<string>();

        if (!Request.Content.IsMimeMultipartContent())
        {
            throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        }

        string rootPath = HttpContext.Current.Server.MapPath("~/xtz");
        var provider = new MultipartFileStreamProvider(rootPath);

        var task = Request.Content.ReadAsMultipartAsync(provider).
            ContinueWith<IHttpActionResult>(t =>
            {
                if (t.IsCanceled || t.IsFaulted)
                {
                    Request.CreateErrorResponse(HttpStatusCode.InternalServerError, t.Exception);
                }
                foreach (MultipartFileData dataitem in provider.FileData)
                {
                    try
                    {

                        string name = dataitem.Headers.ContentDisposition.FileName.Replace("\"", "");

                        string newFileName = Guid.NewGuid() + Path.GetExtension(name);

                        File.Move(dataitem.LocalFileName, Path.Combine(rootPath, newFileName));





                    }
                    catch (Exception ex)
                    {
                        string message = ex.Message;
                    }
                }



                return (IHttpActionResult)Request.CreateResponse(HttpStatusCode.Created, savedFilePath);
            });
        return task;
    }*/
}
}
