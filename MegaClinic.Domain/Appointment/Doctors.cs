using System;
using System.Collections.Generic;
using System.Text;

namespace MegaClinic.Domain.Appointment
{
    class Doctors
    {
        public Guid DoctorId { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorFirstName { get; set; }
    }
}
