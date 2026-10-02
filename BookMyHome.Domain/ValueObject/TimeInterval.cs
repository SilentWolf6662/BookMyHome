using BookMyHome.Domain.Exceptions;

namespace BookMyHome.Domain.ValueObject
{
    public class TimeInterval
    {
        public DateOnly Start { get; init; }
        public DateOnly End { get; init; }

        public TimeInterval(DateOnly start, DateOnly end)
        {
            // Hvis slut tiden er før start tiden, kastes en DomainException
            if (end <= start) throw new DomainException("Slut datoen kan ikke være før start datoen");

            Start = start;
            End = end;
        }

        // Tjek at 2 datoer ikke overlapper hinanden
        public bool Overlapping(TimeInterval other) => Start < other.End && End > other.Start;
    }
}
