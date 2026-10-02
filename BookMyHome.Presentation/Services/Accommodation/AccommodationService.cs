using BookMyHome.Facade.DTO;
using System.Net.Http.Json;

namespace BookMyHome.Presentation.Services.Accommodation
{
    public class AccommodationService : IAccommodationService
    {
        private readonly HttpClient httpClient;
        private readonly string baseUrl = "https://localhost:7216/";
        private readonly string apiUrl = "api/accommodation-api";

        public AccommodationService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<AccommodationItem[]?> GetAllItems()
        {
            var response = await httpClient.GetFromJsonAsync<AccommodationItem[]>(baseUrl + apiUrl);
            return response;
        }
    }
}
