using BookMyHome.Domain.Entity;
using BookMyHome.Facade.DTO;

namespace BookMyHome.Infrastructure.Repository.Interface
{
    public interface IAccommodationRepository
    {
        Task<IReadOnlyList<AccommodationItem>> GetAllAsync();
        Task<IReadOnlyList<AccommodationItem>> GetByHostIdAsync(Guid hostId);
        Task<AccommodationItem?> GetByIdAsync(Guid id);
        Task AddAsync(AccommodationItem item);
        Task DeleteAsync(Guid id);
        Task UpdateDetailsAsync(Guid id, string title, decimal pricePerDay);
    }
}