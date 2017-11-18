namespace Empeek.DataAccessLayer.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        public int ItemId { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(128)]
        public string ItemName { get; set; }

        public virtual Category Category { get; set; }
    }
}
