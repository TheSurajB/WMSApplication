using WMSAPP.Shared;

namespace WMSAPP.Client.Services
{
    public interface ICommonService
    {

        Task<List<Vehicle>> GetVehicles();
    }
}
