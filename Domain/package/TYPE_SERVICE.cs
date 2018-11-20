namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TYPE_SERVICE
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }
    }
}
