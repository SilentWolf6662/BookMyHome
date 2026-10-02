using BookMyHome.Facade.DTO;
using BookMyHome.Infrastructure.Repository;
using BookMyHome.Infrastructure.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyHome.Application.Controllers
{
    [ApiController]
    [Route("api/accommodation-api")]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationRepository _repository = new AccommodationRepository();

        // Constructor injection af repository (hvis nødvendigt)
        public AccommodationController(IAccommodationRepository repository)
        {
            if (_repository == null && repository != null) // Hvis _repository ikke er initialiseret, men repository existerer, så initialiser _repository med repository
            {
                _repository = repository;
                Console.WriteLine("Repository initialized");
            }
        }

        [HttpGet]
        // Hent alle accommodation items og return dem som JSON
        public IEnumerable<AccommodationItem> GetAllItems()
        {
            return _repository.GetAllAsync().Result;
        }
    }
}
