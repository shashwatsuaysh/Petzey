namespace DoctorFlow_Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DoctorID { get; set; }

        [Required]
       
        public string DoctorName { get; set; }

        [Required]
       
        public string Speciality { get; set; }

        public long NPI { get; set; }

        public long Mobile { get; set; }

        [Required]
       
        public string Email { get; set; }

        [Required]
       
        public string Clinic { get; set; }

       
        public string Image { get; set; }
    }
}
