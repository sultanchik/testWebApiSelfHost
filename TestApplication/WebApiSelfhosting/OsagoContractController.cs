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

        [HttpPost]
        //[Route("OsagoContracts({guid})/Annul")]
        public IHttpActionResult Annul(string guid)
        {
            //if(model.Guid.Equals(Guid.Empty))
            //    return StatusCode(HttpStatusCode.Forbidden);

            //var lastSymbol = model.Guid.ToString()[model.Guid.ToString().Length - 1];
            if (string.IsNullOrWhiteSpace(guid))
                return StatusCode(HttpStatusCode.Forbidden);

            var lastSymbol = guid[guid.Length - 1];

            int number;
            if (int.TryParse(lastSymbol.ToString(), out number))
            {
                return StatusCode(HttpStatusCode.Forbidden);
            }
            else
            {
                return StatusCode(HttpStatusCode.Accepted);
            }
        }
    }
}