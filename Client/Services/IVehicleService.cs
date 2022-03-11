using WMSAPP.Shared;

namespace WMSAPP.Client.Services
{
    public interface IVehicleService
    {
        Task<List<Vehicle>> GetVehicles();
    }
}
