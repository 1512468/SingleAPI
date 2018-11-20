namespace Domain.package
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROOM")]
    public partial class ROOM
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string RoomName { get; set; }

        public int? Amount { get; set; }

        [StringLength(250)]
        public string Describe { get; set; }

        public bool? Status { get; set; }
    }
}
