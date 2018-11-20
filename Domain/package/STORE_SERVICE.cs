namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STORE_SERVICE
    {
        [Key]
        public int IDSS { get; set; }

        public int? IDService { get; set; }

        public int? IDTherapist { get; set; }

        public bool? Status { get; set; }
    }
}
