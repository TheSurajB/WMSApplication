using WMSAPP.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace WMSAPP.Client.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient _httpClient;
        public VehicleService(HttpClient httpClient )
        {
            _httpClient = httpClient;
        }
        public async Task<List<Vehicle>> GetVehicles()
        {
          return  await _httpClient.GetFromJsonAsync<List<Vehicle>>("api/vehicle/getvehicles");
        }
    }
}
