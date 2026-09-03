using BookMyHome.Domain.ValueObject;

namespace BookMyHome.Domain.Entity
{
    public class Accommodation : AggregateRoot
    {
        public double Price { get; private set;}
        public Location Location { get; private set;}
        public List<string> Facility { get; private set; } // example = aircondition (a/c)
        public string BuildingType { get; private set; }
        public string HouseRule { get; private set; }
        public List<DateOnly> AvailableDates { get; private set; }

        private Accommodation(double price, Location location, string buildingType,string houseRule, List<string> facility, List<DateOnly> availableDates)
        {
            Price = price;
            Location = location;
            BuildingType = buildingType;
            HouseRule = houseRule;
            Facility = facility;
            AvailableDates = availableDates;
        }

        public static Accommodation Create(double price, Location location, string buildingType, string houseRule,
            List<string> facility, List<DateOnly> availableDates)
        {
            var accommodation = new Accommodation(price, location, buildingType, houseRule, facility, availableDates);
            return accommodation;
        }
    }
}
