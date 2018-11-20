namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICE_THERAPIST
    {
        [Key]
        public int IDST { get; set; }

        public int? IDService { get; set; }

        public int? IDTherapist { get; set; }
    }
}
