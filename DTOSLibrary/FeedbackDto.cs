using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOSLibrary
{
    public class FeedbackDto
    {

        public long App_ID { get; set; }

        public int Comp_level { get; set; }

        public int Doctor_Rating { get; set; }

        public int Booking_Process { get; set; }

        public int Outcome { get; set; }
    }
}

