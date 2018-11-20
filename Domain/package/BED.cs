namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BED")]
    public partial class BED
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string BedName { get; set; }

        public int? IDRoom { get; set; }

        public int? IDService { get; set; }

        [StringLength(100)]
        public string Describe { get; set; }

        public bool? Status { get; set; }
    }
}
