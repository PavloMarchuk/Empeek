using Empeek.DataAccessLayer.DAL;
using Empeek.DataTransferLayer.DTO;
using Empeek.DataTransferLayer.Services.Instant.Instant;
using Empeek.RepositoriesInstantEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empeek.API.Controllers
{
    public class ItemController : ApiController
    {
		static readonly ItemDTOService repService = new ItemDTOService(new ItemRepository(new EmpeekContext()));// потім переписатипід "внедрєніє залежності" автофаком


		// GET: api/Item
		public IHttpActionResult Get()
        {	
			return Ok(repService.GetAll().AsEnumerable());
		}

		// GET: api/Item/5
		public IHttpActionResult Get(int id)
        {
             return Ok(repService.Get(id));
		}

		// POST: api/Item
		public void Post([FromBody]ItemDTO value)
        {
			repService.AddOrUpdate(value);
		}

		// DELETE: api/Item/ItemDTO
		public IHttpActionResult Delete([FromBody]ItemDTO value)
        {
			repService.Delete(value);
			return Ok(value);			
		}
    }
}
