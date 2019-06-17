using MegaClinic.Domain;
using System;

namespace MegaClinic.Domain.Billing
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string BillingAddress { get; set; }
        public bool BillingValidation { get; set; }
        public string CreditCard { get; set; }

        public void PayBill()
        {
            //Client pays pending bills
        }
    }
}
