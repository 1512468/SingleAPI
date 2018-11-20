namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOOKING")]
    public partial class BOOKING
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BookingDay { get; set; }

        public bool? Status { get; set; }

        public int? IDStore { get; set; }

        public int? IDTherapist { get; set; }

        public int? IDCustomer { get; set; }
    }
}
