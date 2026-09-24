namespace BookMyHome.Facade.DTO
{
    public class AccommodationItem
    {
        public Guid Id { get; set; }
        public double Price { get; set; } // fx 1000 kr. for 3 dage
        public string Location { get; set; } // fx "København, Nørrebrovej 17"
        public string Facility { get; set; } // fx "Aircondition, Wifi, TV"
        public string BuildingType { get; set; } // fx "Lejlighed"
        public string HouseRule { get; set; } // fx "Ingen rygning, ingen husdyr"

        public AccommodationItem() { }
    }
}
