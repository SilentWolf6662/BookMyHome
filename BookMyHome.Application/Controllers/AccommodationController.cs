using Microsoft.AspNetCore.Mvc;
using BookMyHome.Facade.DTO;
//using BookMyHome.Infrastructure;
using System.Net;

namespace BookMyHome.Application.Controllers
{
    [ApiController]
    [Route("api/accommodation-api")]
    public class AccommodationController : ControllerBase
    {
        //private readonly IAccommodationRepository _repository = new IAccommodationRepository();

        // Constructor injection af repository (hvis nødvendigt)
        //public AccommodationController(IAccommodationRepository repository)
        //{
        //    if (_repository == null && repository != null) // Hvis _repository ikke er initialiseret, men repository existerer, så initialiser _repository med repository
        //    {
        //        _repository = repository;
        //        Console.WriteLine("Repository initialized");
        //    }
        //}

        [HttpGet]
        // Hent alle accommodation items og return dem som
        //public IEnumerable<AccommodationItem> GetAllAccommodations()
        //{
        //    ////return _repository.GetAllAccommodations();
        //}
    }
}
