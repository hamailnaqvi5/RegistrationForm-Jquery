using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UserRegistration.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<db_user> db_user { get; set; }
        public object Users { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<db_user>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<db_user>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<db_user>()
               .Property(e => e.Email)
               .IsUnicode(false);

            modelBuilder.Entity<db_user>()
               .Property(e => e.Phone)
               .IsUnicode(false);
        }
    }
}
