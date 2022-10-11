namespace DoctorFlow_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Feedback_ID { get; set; }

        public long? App_ID { get; set; }

        public int? Comp_level { get; set; }

        public int? Doctor_Rating { get; set; }

        public int? Booking_Process { get; set; }

        public int? Outcome { get; set; }
    }
}
