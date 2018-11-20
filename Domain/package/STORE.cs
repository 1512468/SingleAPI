namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STORE")]
    public partial class STORE
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string StoreName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        public int? PhoneNumber { get; set; }
    }
}
