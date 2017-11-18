using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empeek.API.Controllers
{
    public class HomeController : ApiController
    {
		string[] homeDocumentation = new string[]
		{
			"Api Documentation :    " +
			"GET: api/Home => Documentation   ",
			
			"GET: api/Item => Get()   ",
			"GET: api/Item/5 => Get(int id)    ",
			"POST: api/Item => AddOrUpdate([FromBody] obj)  ",
			"DELETE: api/Delete=> Delete([FromBody] obj)  ",



		};

		public IHttpActionResult Get()
		{
			return Ok(homeDocumentation);
		}
	}
}
