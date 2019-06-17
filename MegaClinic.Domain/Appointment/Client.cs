using MegaClinic.Domain;
using System;

namespace MegaClinic.Domain.Appointment
{
    public class Client 
    {
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }

        public void SetAppointment()
        {
            // Client can set appoiintment
        }


    }
}

