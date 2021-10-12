using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace umeAPI.Controllers.API
{
    public class MainController : ApiController
    {
        // GET: Main
        [System.Web.Mvc.Route("api/Main")]
        public object Index()
        {
            return 0;
        }
    }
}