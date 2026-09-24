using BookMyHome.Domain.Entity;
using BookMyHome.Infrastructure.Repository.Interface;
using System.Collections.ObjectModel;

namespace BookMyHome.Infrastructure.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly List<Accommodation> itemList =
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
        Task<IReadOnlyList<Accommodation>> IAccommodationRepository.GetAllAsync()
        {
            return Task.FromResult<IReadOnlyList<Accommodation>>(itemList);
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