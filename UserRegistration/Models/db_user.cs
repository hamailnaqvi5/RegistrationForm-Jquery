namespace UserRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    [Table("[db.user]")]
    public partial class db_user
    {
        internal object email;

        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public bool IsAdmin { get; set; }

        public static implicit operator DbSet<object>(db_user v)
        {
            throw new NotImplementedException();
        }
    }
}
