using BookMyHome.Domain.ValueObject;

namespace BookMyHome.Domain.Entity
{
    public class Accomodoation : AggregateRoot
    {
        public double Price { get; private set;}

        public Location Location { get; private set;}

        public List<string> Facility { get; private set; } // example = aircondition (a/c)

        public string BuildingType { get; private set; }

        public string HouseRules { get; private set; }

        public List<DateOnly> AvailableDates { get; private set; }


    }
}
