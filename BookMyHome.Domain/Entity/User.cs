using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyHome.Domain.Entity
{
    public class User : AggregateRoot
    {
        public bool Host { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
    }
}
