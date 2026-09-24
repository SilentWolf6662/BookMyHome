using BookMyHome.Domain.ValueObject;

namespace BookMyHome.Domain.Entity
{
    public class Accommodation : AggregateRoot
    {
        public double Price { get; private set;}
        public Location Location { get; private set;}
        public List<string> Facility { get; private set; } // example = aircondition (a/c), wifi, tv, osv.
        public string BuildingType { get; private set; }
        public string HouseRule { get; private set; }
        public List<DateOnly> AvailableDates { get; private set; } = new List<DateOnly>(); // Bruges senere til host kan sætte booking tilgængelighed

        private Accommodation(double price, Location location, string buildingType,string houseRule, List<string> facility)
        {
            Price = price;
            Location = location;
            BuildingType = buildingType;
            HouseRule = houseRule;
            Facility = facility;
        }

        public static Accommodation Create(double price, Location location, string buildingType, string houseRule, List<string> facility)
        {
            var accommodation = new Accommodation(price, location, buildingType, houseRule, facility);
            return accommodation;
        }
    }
}
