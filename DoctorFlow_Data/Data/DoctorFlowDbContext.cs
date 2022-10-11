using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoctorFlow_Data.Entities
{
    public partial class DoctorFlowDbContext : DbContext
    {
        public DoctorFlowDbContext()
            : base("name=DoctorFlowDbContext")
        {
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .Property(e => e.DoctorName)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Speciality)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Clinic)
                .IsFixedLength();

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Image)
                .IsFixedLength();
        }
    }
}
