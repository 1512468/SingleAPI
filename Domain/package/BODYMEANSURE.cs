namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BODYMEANSURE")]
    public partial class BODYMEANSURE
    {
        [Key]
        public int IDBODY { get; set; }

        public int? CMND { get; set; }

        public int? Heigh { get; set; }

        public int? Weight { get; set; }

        public int? BMI { get; set; }

        public int? BodyMass { get; set; }

        public int? FatContent { get; set; }

        public int? MuscleContent { get; set; }

        public int? StomachFat { get; set; }
    }
}
