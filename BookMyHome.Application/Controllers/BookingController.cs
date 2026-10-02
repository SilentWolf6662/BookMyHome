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
    [Route("api/booking-api")]
    public class BookingController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
