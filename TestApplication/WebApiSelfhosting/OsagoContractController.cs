using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Routing;

namespace WebApiSelfhosting
{
    public class OsagoContractsController : ApiController
    {
        public IHttpActionResult GetOsago()
        {
            return StatusCode(HttpStatusCode.Accepted);
        }

        
        [Route("api/OsagoContracts({guid})/K3.Annul")]
        public IHttpActionResult Post(string guid)
        {
            return StatusCode(HttpStatusCode.Accepted);
        }
    }
}