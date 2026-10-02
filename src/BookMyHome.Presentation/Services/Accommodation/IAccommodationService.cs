using BookMyHome.Facade.DTO;

namespace BookMyHome.Presentation.Services.Accommodation
{
    public interface IAccommodationService
    {
        Task<AccommodationItem[]?> GetAllItems();
    }
}
