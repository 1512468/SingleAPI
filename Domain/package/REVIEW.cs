namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("REVIEW")]
    public partial class REVIEW
    {
        public int ID { get; set; }

        [Column("Review")]
        public int? Review1 { get; set; }

        public int? ByReview { get; set; }

        public int? TypeReview { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }

        public int? StartNumber { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }
    }
}
