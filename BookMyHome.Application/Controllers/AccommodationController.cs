using BookMyHome.Domain.ValueObject;
using BookMyHome.Facade.DTO;
using BookMyHome.Infrastructure.Repository;
using BookMyHome.Infrastructure.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using BookMyHome.Domain.Entity;

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
        public ActionResult<IEnumerable<AccommodationItem>> GetAllItems()
        {
            var result = _repository.GetAllAsync().Result;
            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public ActionResult<AccommodationItem> GetAsync(Guid id)
        {
            var result = _repository.GetByIdAsync(id).Result;
            return result is null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id:guid}")]
        public ActionResult DeleteItem(Guid id)
        {
            bool deleted = _repository.DeleteAsync(id);
            if(deleted)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<AccommodationItem> Create(double price, Location location, string buildingType,
            string houseRule, List<string> facility)
        {
            var accommodation = Accommodation.Create(price, location, buildingType, houseRule, facility);
            _repository.AddAsync(accommodation);
            return Ok();
        }

    }
}
