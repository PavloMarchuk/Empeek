using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Empeek.DataTransferLayer.DTO
{
	//[DataContract]
	public class ItemDTO
	{
		//[DataMember]
		[Key]
		public int ItemId { get; set; }

		//[DataMember]
		public int CategoryId { get; set; }

		//[DataMember]
		[Required]
		[StringLength(128)]
		public string ItemName { get; set; }

		//[DataMember]
		[Required]
		[StringLength(128)]
		public string CategoryName { get; set; }
	}
}
