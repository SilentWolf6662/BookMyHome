using BookMyHome.Domain.Entity;
using BookMyHome.Facade.DTO;

namespace BookMyHome.Infrastructure.Repository.Interface
{
    public interface IAccommodationRepository
    {
        Task<IReadOnlyList<AccommodationItem>> GetAllAsync();
        Task<IReadOnlyList<Accommodation>> GetByHostIdAsync(Guid hostId);
        Task<Accommodation?> GetByIdAsync(Guid id);
        Task AddAsync(Accommodation item);
        Task DeleteAsync(Guid id);
        Task UpdateDetailsAsync(Guid id, string title, decimal pricePerDay);
    }
}