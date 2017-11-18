using Empeek.DataAccessLayer.DAL;
using Empeek.RepositoriesCommon.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.RepositoriesInstantEntity.Repositories
{
	public class ItemRepository : GenericRepository<Item>
	{
		public ItemRepository(DbContext context) : base(context) { }
	}
}
