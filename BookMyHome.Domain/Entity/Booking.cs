using System;
using System.Collections.Generic;
using System.Text;
using BookMyHome.Domain.ValueObject;

namespace BookMyHome.Domain.Entity
{
    public class Booking : AggregateRoot
    {
        public TimeInterval TimeInterval { get; private set; }
        public Guid AccomodoationId { get; private set; }
        public Guid GuestId { get; private set; }
        public Guid HostId { get; private set; }

    }
}
