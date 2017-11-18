using Empeek.DataAccessLayer.DAL;
using Empeek.DataTransferLayer.DTO;
using Empeek.DataTransferLayer.Services.Instant.Instant;
using Empeek.RepositoriesInstantEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empeek.API.Controllers
{
    public class CategoryController : ApiController
    {
		static readonly CategoryDTOService repService = new CategoryDTOService(new CategoryRepository(new EmpeekContext()));// потім переписатипід "внедрєніє залежності" автофаком

		// GET: api/Category
		public IHttpActionResult Get()
		{
			return Ok(repService.GetAll().AsEnumerable());
		}

		// GET: api/Category/5
		public IHttpActionResult Get(int id)
		{
			return Ok(repService.Get(id));
		}

		// POST: api/Category
		public void Post([FromBody]CategoryDTO value)
		{
			repService.AddOrUpdate(value);
		}		
		
		// DELETE: api/Category/5      
		public IHttpActionResult Delete([FromBody]CategoryDTO value)
		{
			repService.Delete(value);
			return Ok(value);
		}
	}
}
