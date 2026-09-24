namespace BookMyHome.Facade.DTO
{
    public class AccommodationItem
    {
        public Guid Id { get; set; }
        public string BuildingType { get; set; } // fx "Lejlighed"
        public string Location { get; set; } // fx "København, Nørrebrovej 17"
        public string Facility { get; set; } // fx "Aircondition, Wifi, TV"
        public double Price { get; set; } // fx 1000 kr. for 3 dage
        public string HouseRule { get; set; } // fx "Ingen rygning, ingen husdyr"

        public AccommodationItem() { }

        public AccommodationItem(Guid id, string buildingType = "template", string location = "city", string facility = "A/C", double price = 100, string houseRule = "Clean up")
        {
            Id = id;
            BuildingType = buildingType;
            Location = location;
            Facility = facility;
            Price = price;
            HouseRule = houseRule;
        }
    }
}
