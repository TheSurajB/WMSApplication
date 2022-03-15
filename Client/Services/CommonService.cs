using WMSAPP.Shared;
using System.Net.Http;
using System.Net.Http.Json;


namespace WMSAPP.Client.Services
{
    public class CommonService:ICommonService
    {

        private readonly HttpClient _httpClient;
        public CommonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Transact objTransact { get; set; } = new Transact();
        public UserModel objUserModel { get; set; } = new UserModel();
        public List<WorkCodeModel> workCodeModelList { get; set; } = new List<WorkCodeModel>();
        public async Task<List<WardModel>> GetWards()
        {
            return await _httpClient.GetFromJsonAsync<List<WardModel>>("api/common/getwards");
        }
        public async Task<List<WeighBridgeModel>> GetWeighBridges()
        {
            return await _httpClient.GetFromJsonAsync<List<WeighBridgeModel>>("api/common/getweighbridge");
        }
        public async Task<List<WorkCodeModel>> GetWorkCodes(WorkCodeModel workCodeModel)
        {
           
            var result = await _httpClient.PostAsJsonAsync("api/common/getworkcode", workCodeModel);
            return await SetWorkCode(result);
        }
        public async Task<List<WorkCodeModel>> GetZones()
        {
            return await _httpClient.GetFromJsonAsync<List<WorkCodeModel>>("api/common/getzones");
        }
        public async Task<List<MaterialTypeModel>> GetMaterialType()
        {
            return await _httpClient.GetFromJsonAsync<List<MaterialTypeModel>>("api/common/getmaterialtype");
        }
        public async Task<List<CommonModel>> GetYesNo()
        {
            return await _httpClient.GetFromJsonAsync<List<CommonModel>>("api/common/getyesno");
        }

        public async Task<List<Vehicle>> GetVehicles()
        {
            return await _httpClient.GetFromJsonAsync<List<Vehicle>>("api/common/getvehicles");
        }

        public async Task<List<AgencyModel>> GetAgencies(int id)
        {
            return await _httpClient.GetFromJsonAsync<List<AgencyModel>>("api/common/getagencies/"+id);
        }

        public async Task<Transact> AddTransactData(Transact transact)
        {
          var result=  await  _httpClient.PostAsJsonAsync($"api/common/addtransactdata", transact);
            return  await SetTransact(result);
        }

        public async Task<Transact> UpdateTransactData(Transact transact)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/common/updatetransactdata", transact);
            return await SetTransact(result);
        }
        private async Task<List<WorkCodeModel>> SetWorkCode(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<List<WorkCodeModel>>();
            workCodeModelList = response;
            return workCodeModelList;
            // _navigationManager.NavigateTo("superheroes");
        }
        private async Task<Transact> SetTransact(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<Transact>();
            objTransact = response;
            return objTransact;
           // _navigationManager.NavigateTo("superheroes");
        }

        private async Task<UserModel> SetUser(HttpResponseMessage result)
        {
            var response = await result.Content.ReadFromJsonAsync<UserModel>();
            objUserModel = response;
            return objUserModel;
            // _navigationManager.NavigateTo("superheroes");
        }
        public async Task<List<Transact>> GetTransactData()
        {
            return await _httpClient.GetFromJsonAsync<List<Transact>>("api/common/gettransactdata");
        }
        public async Task<Transact> GetTransactDataBySlipNo(string id)
        {
        return  await _httpClient.GetFromJsonAsync<Transact>($"api/common/gettransactdatabyslipNo/{id}");
          
        }

        public async Task<UserModel> Login(UserModel transact)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/common/userlogin", transact);
            return await SetUser(result);
        }
    }
}
