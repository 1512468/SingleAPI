namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OULET")]
    public partial class OULET
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Passwords { get; set; }

        public int? TypeAccount { get; set; }

        [StringLength(25)]
        public string FullName { get; set; }

        public int? IDStore { get; set; }

        public int? DoB { get; set; }

        [StringLength(100)]
        public string Describes { get; set; }

        [StringLength(5)]
        public string Sex { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        public int? CMND { get; set; }

        [StringLength(10)]
        public string Address { get; set; }

        [StringLength(25)]
        public string Email { get; set; }

        [StringLength(25)]
        public string Job { get; set; }

        public int? PhoneNumber { get; set; }
    }
}
