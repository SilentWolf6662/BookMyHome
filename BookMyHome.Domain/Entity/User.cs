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

        private User(bool host, string firstName, string lastName, string phoneNumber, string email)
        {
            Host = host;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public static User Create(bool host, string firstName, string lastName, string phoneNumber, string email)
        {
            var user = new User(host, firstName, lastName, phoneNumber, email);
            return user;
        }
    }
}
