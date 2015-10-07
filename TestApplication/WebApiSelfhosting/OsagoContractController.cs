using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSelfhosting
{
    public class OsagoContractsController : ApiController
    {
        public IHttpActionResult GetOsago()
        {
            return StatusCode(HttpStatusCode.Accepted);
        }
    }
}