namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVICE")]
    public partial class SERVICE
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string ServiceName { get; set; }

        public int? Price { get; set; }

        public int? TypeService { get; set; }

        [Column(TypeName = "image")]
        public byte[] Image { get; set; }

        [StringLength(100)]
        public string Describe { get; set; }

        public bool? RequireEmployee { get; set; }
    }
}
