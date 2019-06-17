using System;
using System.Collections.Generic;
using System.Text;

namespace MegaClinic.Domain.Billing
{
    class Bills
    {
        public Guid BillId { get; set; }
        public double BillAmount { get; set; }
        public DateTime BillDate { get; set; }
    }
}
