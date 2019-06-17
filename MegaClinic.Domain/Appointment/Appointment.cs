using System;
using System.Collections.Generic;
using System.Text;

namespace MegaClinic.Domain.Appointment
{
    class Appointment 
    {
        public Guid AppointmentId { get; set; }
        public DateTime Schedule { get; set; }
    }
}
