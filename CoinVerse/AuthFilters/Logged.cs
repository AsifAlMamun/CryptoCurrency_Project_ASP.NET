﻿using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace CoinVerse.AuthFilters
{
    public class Logged : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null && token.ToString()==null && !AuthService.IsTokenValid(token.ToString()))
            {
                actionContext.Response=actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new {Msg="No Token Supplied"});
            }
            base.OnAuthorization(actionContext);
        }
    }
}