using BookMyHome.Domain.Entity;
using BookMyHome.Infrastructure.Repository.Interface;
using BookMyHome.Facade.DTO;

namespace BookMyHome.Infrastructure.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly List<Accommodation> _itemList =
        [
            // Format: Pris, Location, BuildingType, HouseRule, Facility
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 7100, "Vejle"), "Appartment", "House Rules", ["A/C"]),
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 8500, "Grenaa"), "Appartment", "House Rules", ["A/C"])
        ];

        // Return alle Accommodations i repo til en list
        Task<IReadOnlyList<AccommodationItem>> IAccommodationRepository.GetAllAsync()
        {
            IReadOnlyList<AccommodationItem> items = _itemList
                .Select(accommodation => new AccommodationItem
                {
                    Id = accommodation.Id,
                    BuildingType = accommodation.BuildingType,
                    Location = accommodation.Location.ToString(),
                    Facility = string.Join(", ", accommodation.Facility),
                    Price = accommodation.Price,
                    HouseRule = accommodation.HouseRule
                })
                .ToList();

            return Task.FromResult(items);
        }

        Task<IReadOnlyList<Accommodation>> IAccommodationRepository.GetByHostIdAsync(Guid hostId)
        {
            throw new NotImplementedException();
        }

        Task<Accommodation?> IAccommodationRepository.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IAccommodationRepository.AddAsync(Accommodation item)
        {
            throw new NotImplementedException();
        }

        Task IAccommodationRepository.UpdateDetailsAsync(Guid id, string title, decimal pricePerDay)
        {
            throw new NotImplementedException();
        }

        Task IAccommodationRepository.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}