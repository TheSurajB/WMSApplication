using WMSAPP.Shared;

namespace WMSAPP.Client.Services
{
    public interface ICommonService
    {
        Task<List<WorkCodeModel>> GetZones();
        Task<List<Vehicle>> GetVehicles();
        Task<List<WardModel>> GetWards();
        Task<List<AgencyModel>> GetAgencies(int id);
        Task<List<MaterialTypeModel>> GetMaterialType();
        Task<List<CommonModel>> GetYesNo();
        Task<List<WorkCodeModel>> GetWorkCodes(WorkCodeModel workCodeModel);
        Task <Transact> AddTransactData(Transact transact);
        Task<Transact> UpdateTransactData(Transact transact);
        Task<List<Transact>> GetTransactData();
        Task<Transact> GetTransactDataBySlipNo(string id);
        Task<UserModel> Login(UserModel transact);
    }
}
