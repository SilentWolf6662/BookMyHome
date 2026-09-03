using System;
using System.Collections.Generic;
using System.Text;

namespace BookMyHome.Domain
{
    public abstract class AggregateRoot
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}
