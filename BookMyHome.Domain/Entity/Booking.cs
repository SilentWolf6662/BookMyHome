using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyHome.Domain.Entity
{
    public class Booking : AggregateRoot
    {
        public DateOnly DateStart {  get; private set; }
        public DateOnly DateEnd { get; private set; }
        public Guid AccomodoationId { get; private set; }
        public Guid GuestId { get; private set; }
        public Guid HostId { get; private set; }

    }
}
