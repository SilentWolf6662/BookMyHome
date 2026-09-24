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

        // Return alle Accommodations i repo
        Task<IReadOnlyList<AccommodationItem>> IAccommodationRepository.GetAllAsync()
        {
            IReadOnlyList<AccommodationItem> items = _itemList
                .Select(a => new AccommodationItem
                {
                    Id = a.Id,
                    Price = a.Price,
                    Location = a.Location.ToString(),
                    Facility = string.Join(", ", a.Facility),
                    BuildingType = a.BuildingType,
                    HouseRule = a.HouseRule
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