using BookMyHome.Domain.Entity;
using BookMyHome.Facade.DTO;
using BookMyHome.Infrastructure.Repository.Interface;

namespace BookMyHome.Infrastructure.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly List<Accommodation> _itemList =
        [
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 7100, "Vejle"), "Appartment",
                "House Rules", ["A/C"],
                [
                    DateOnly.FromDateTime(DateTime.Today).AddDays(2), DateOnly.FromDateTime(DateTime.Today).AddDays(3),
                    DateOnly.FromDateTime(DateTime.Today).AddDays(4)
                ]),
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 8500, "Grenaa"), "Appartment",
                "House Rules", ["A/C"],
                [
                    DateOnly.FromDateTime(DateTime.Today).AddDays(2), DateOnly.FromDateTime(DateTime.Today).AddDays(9),
                    DateOnly.FromDateTime(DateTime.Today).AddDays(6)
                ])
        ];
        Task<IReadOnlyList<AccommodationItem>> IAccommodationRepository.GetAllAsync()
        {
            List<AccommodationItem> accommodationItems = (from accommodation in _itemList
                let facilityStr = accommodation.Facility.Aggregate("", (current, t) => current + $", {t}")
                select new AccommodationItem
                {
                    Price = accommodation.Price,
                    HouseRule = accommodation.HouseRule,
                    BuildingType = accommodation.BuildingType,
                    Location = accommodation.Location.ToString(),
                    Facility = facilityStr
                })
                .ToList();
            return Task.FromResult<IReadOnlyList<AccommodationItem>>(accommodationItems);
        }

        Task<IReadOnlyList<AccommodationItem>> IAccommodationRepository.GetByHostIdAsync(Guid hostId)
        {
            throw new NotImplementedException();
        }

        Task<AccommodationItem?> IAccommodationRepository.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IAccommodationRepository.AddAsync(AccommodationItem item)
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