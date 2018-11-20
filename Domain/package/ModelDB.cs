namespace Domain.package
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<BED> BEDs { get; set; }
        public virtual DbSet<BOOKING> BOOKINGs { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERs { get; set; }
        public virtual DbSet<OULET> OULETs { get; set; }
        public virtual DbSet<REVIEW> REVIEWs { get; set; }
        public virtual DbSet<ROOM> ROOMs { get; set; }
        public virtual DbSet<SERVICE> SERVICEs { get; set; }
        public virtual DbSet<SERVICE_THERAPIST> SERVICE_THERAPIST { get; set; }
        public virtual DbSet<STORE> STOREs { get; set; }
        public virtual DbSet<STORE_SERVICE> STORE_SERVICE { get; set; }
        public virtual DbSet<THERAPIST> THERAPISTs { get; set; }
        public virtual DbSet<TYPE_SERVICE> TYPE_SERVICE { get; set; }
        public virtual DbSet<BODYMEANSURE> BODYMEANSUREs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BED>()
                .Property(e => e.BedName)
                .IsUnicode(false);

            modelBuilder.Entity<BED>()
                .Property(e => e.Describe)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Passwords)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CUSTOMER>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Passwords)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Describes)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OULET>()
                .Property(e => e.Job)
                .IsUnicode(false);

            modelBuilder.Entity<REVIEW>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM>()
                .Property(e => e.RoomName)
                .IsUnicode(false);

            modelBuilder.Entity<ROOM>()
                .Property(e => e.Describe)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE>()
                .Property(e => e.ServiceName)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICE>()
                .Property(e => e.Describe)
                .IsUnicode(false);

            modelBuilder.Entity<STORE>()
                .Property(e => e.StoreName)
                .IsUnicode(false);

            modelBuilder.Entity<STORE>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Passwords)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Describes)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Sex)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<THERAPIST>()
                .Property(e => e.Level)
                .IsUnicode(false);

            modelBuilder.Entity<TYPE_SERVICE>()
                .Property(e => e.TypeName)
                .IsUnicode(false);
        }
    }
}
