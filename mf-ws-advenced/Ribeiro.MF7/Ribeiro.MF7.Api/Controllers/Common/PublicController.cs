using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ribeiro.MF7.Api.Controllers.Common
{
    [Authorize]
    [RoutePrefix("api/public")]
    public class PublicController : ApiControllerBase
    {
        [HttpGet]
        [Route("is-alive")]
        public IHttpActionResult IsAlive()
        {
            return Ok(true);
        }
    }
}