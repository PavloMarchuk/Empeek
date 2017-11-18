using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.DataTransferLayer.DTO
{
	public class CategoryDTO
	{
		[Key]
		public int CategoryId { get; set; }

		[Required]
		[StringLength(128)]
		public string CategoryName { get; set; }
				
		public int ItemsCount { get; set; }
	}
}
