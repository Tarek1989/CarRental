namespace RentalCar.DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentalCarModel : DbContext
    {
        public RentalCarModel()
            : base("name=RentalCarModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<CarRental> CarRental { get; set; }
    }
}
