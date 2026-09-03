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

        private Booking(TimeInterval timeInterval, Guid accomodoationId, Guid guestId, Guid hostId)
        {
            TimeInterval = timeInterval;
            AccomodoationId = accomodoationId;
            GuestId = guestId;
            HostId = hostId;
        }

        public static Booking Create(TimeInterval timeInterval, Guid accomodoationId, Guid guestId, Guid hostId)
        {
            var booking = new Booking(timeInterval, accomodoationId, guestId, hostId);
            return booking;
        }
    }
}
