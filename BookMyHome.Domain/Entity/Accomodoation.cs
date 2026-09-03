using BookMyHome.Domain.ValueObject;

namespace BookMyHome.Domain.Entity
{
    public class Accomodoation : AggregateRoot
    {
        public double Price { get; private set;}
        public Location Location { get; private set;}
        public List<string> Facility { get; private set; } // example = aircondition (a/c)
        public string BuildingType { get; private set; }
        public string HouseRule { get; private set; }
        public List<DateOnly> AvailableDates { get; private set; }

        private Accomodoation(double price, Location location, string buildingType,string houseRule, List<string> facility, List<DateOnly> availableDates)
        {
            Price = price;
            Location = location;
            BuildingType = buildingType;
            HouseRule = houseRule;
            Facility = facility;
            AvailableDates = availableDates;
        }

        public static Accomodoation Create(double price, Location location, string buildingType, string houseRule,
            List<string> facility, List<DateOnly> availableDates)
        {
            var accomodoation = new Accomodoation(price, location, buildingType, houseRule, facility, availableDates);
            return accomodoation;
        }
    }
}
