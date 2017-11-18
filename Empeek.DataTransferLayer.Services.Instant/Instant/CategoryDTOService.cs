using AutoMapper;
using Empeek.DataAccessLayer.DAL;
using Empeek.DataTransferLayer.DTO;
using Empeek.DataTransferLayer.Services.Common;
using Empeek.RepositoriesInstantEntity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.DataTransferLayer.Services.Instant.Instant
{
	public class CategoryDTOService : CommonDTOService<CategoryDTO, Category>
	{
		public CategoryDTOService(CategoryRepository eRep) : base(eRep) { }

		// перевизначення конфігурації мапера для правильного відображення поля "ItemsCount"
		protected override MapperConfiguration MapConfig()
		{
			return new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<CategoryDTO, Category>();
				cfg.CreateMap<Category, CategoryDTO>()
				.ForMember("ItemsCount", opt=>opt.MapFrom (ef=>ef.Items.Count));
			});
		}

	}
}
