using Empeek.DataTransferLayer.Services.Common;
using Empeek.DataAccessLayer.DAL;
using Empeek.DataTransferLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empeek.RepositoriesInstantEntity.Repositories;
using AutoMapper;

namespace Empeek.DataTransferLayer.Services.Instant.Instant
{
	public class ItemDTOService: CommonDTOService<ItemDTO, Item>
	{		
		public ItemDTOService(ItemRepository eRep) : base(eRep) { }

		// перевизначення конфігурації мапера для правильного відображення поля "CategoryName"
		protected override MapperConfiguration MapConfig()
		{			
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<ItemDTO, Item>();
				cfg.CreateMap<Item, ItemDTO>().ForMember("CategoryName", opt=>opt.MapFrom(ef=>ef.Category.CategoryName));
			});
			return config;			
		}

		

		
	}
}
 