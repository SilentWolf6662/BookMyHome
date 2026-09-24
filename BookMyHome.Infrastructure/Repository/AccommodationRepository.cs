using BookMyHome.Domain.Entity;
using BookMyHome.Infrastructure.Repository.Interface;

namespace BookMyHome.Infrastructure.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly List<Accommodation> _itemList =
        [
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 7100, "Vejle"), "Appartment", "House Rules", ["A/C"]),
            Accommodation.Create(250.0, new Domain.ValueObject.Location("Street Name", 8500, "Grenaa"), "Appartment", "House Rules", ["A/C"])
        ];
        Task<IReadOnlyList<Accommodation>> IAccommodationRepository.GetAllAsync()
        {
            return Task.FromResult<IReadOnlyList<Accommodation>>(_itemList);
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