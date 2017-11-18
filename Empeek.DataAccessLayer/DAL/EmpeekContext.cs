namespace Empeek.DataAccessLayer.DAL
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class EmpeekContext : DbContext
	{
		public EmpeekContext()
			: base("name=EmpeekContext")
		{
		}

		public virtual DbSet<Category> Categories { get; set; }
		public virtual DbSet<Item> Items { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>()
				.Property(e => e.CategoryName)
				.IsUnicode(false);

			modelBuilder.Entity<Category>()
				.HasMany(e => e.Items)
				.WithRequired(e => e.Category)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Item>()
				.Property(e => e.ItemName)
				.IsUnicode(false);
		}
	}
}
