using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sunil M S
namespace DTOSLibrary
{
    public class DoctorDto
    {

        
        public string DoctorName { get; set; }
      
        public string Speciality { get; set; }
        public long NPI { get; set; }
        public long Mobile { get; set; }

        public string Email { get; set; }

        public string Clinic { get; set; }


        public string Image { get; set; }
    }
}
