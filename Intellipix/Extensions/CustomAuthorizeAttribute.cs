using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace Intellipix.Extensions
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public static bool AuthorizationEnabled { get; set; } = true;
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (!AuthorizationEnabled)
                return true;

            return base.AuthorizeCore(httpContext);
        }
    }
}