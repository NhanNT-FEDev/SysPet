namespace LoginForm.DbContext
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class myConnectionString : DbContext
	{
		public myConnectionString()
			: base("name=myConnectionString")
		{
		}

		public virtual DbSet<Breed> Breeds { get; set; }
		public virtual DbSet<Carer> Carers { get; set; }
		public virtual DbSet<Owner> Owners { get; set; }
		public virtual DbSet<PetDetail> PetDetails { get; set; }
		public virtual DbSet<Species> Species { get; set; }
		public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Breed>()
				.HasMany(e => e.PetDetails)
				.WithRequired(e => e.Breed1)
				.HasForeignKey(e => e.Breed)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Carer>()
				.Property(e => e.CarerID)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Carer>()
				.HasMany(e => e.PetDetails)
				.WithMany(e => e.Carers)
				.Map(m => m.ToTable("Pet_Carer").MapLeftKey("CarerID").MapRightKey("PetID"));

			modelBuilder.Entity<Owner>()
				.Property(e => e.OwnerID)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Owner>()
				.HasMany(e => e.PetDetails)
				.WithRequired(e => e.Owner)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<PetDetail>()
				.Property(e => e.PetID)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<PetDetail>()
				.Property(e => e.OwnerID)
				.IsFixedLength()
				.IsUnicode(false);

			modelBuilder.Entity<Species>()
				.HasMany(e => e.PetDetails)
				.WithRequired(e => e.Species1)
				.HasForeignKey(e => e.Species)
				.WillCascadeOnDelete(false);
		}
	}
}
