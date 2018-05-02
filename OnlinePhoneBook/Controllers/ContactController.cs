using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnlinePhoneBook.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Contact.CreateContact());
        }

    }

    #region Helpers

   

    #endregion
}
