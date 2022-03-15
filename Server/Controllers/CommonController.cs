using Microsoft.AspNetCore.Mvc;
using System.Data;
using WMSAPP.Server.Repository;
using WMSAPP.Shared;

namespace WMSAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {

        AllReportContent allReportContent = new AllReportContent();

        [HttpGet("getweighbridge")]
        public async Task<ActionResult<List<WeighBridgeModel>>> GetWeighBridges()
        {

            DataSet ds = allReportContent.GetWeighBridge();
            List<WeighBridgeModel> weighBridgeModelList = new List<WeighBridgeModel>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    weighBridgeModelList.Add(new WeighBridgeModel
                    {
                        WBID = Convert.ToInt32(ds.Tables[0].Rows[i]["WBID"]),
                        WBName = Convert.ToString(ds.Tables[0].Rows[i]["WBName"]),
                    });
                }
                // cbvehicleno.Items.Insert(0, "--Select Vehicle No--");              
            }
            await Task.Yield();
            return Ok(weighBridgeModelList);
        }


        [HttpGet("getzones")]
        public async Task<ActionResult<List<WorkCodeModel>>> GetZones()
        {

            DataSet ds = allReportContent.GetZones();
            List<WorkCodeModel> workCodeModelList = new List<WorkCodeModel>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    workCodeModelList.Add(new WorkCodeModel
                    {
                        Zone = Convert.ToString(ds.Tables[0].Rows[i]["Zone"]),
                    });
                }
                // cbvehicleno.Items.Insert(0, "--Select Vehicle No--");              
            }
            await Task.Yield();
            return Ok(workCodeModelList);
        }

        [HttpGet("getwards")]
        public async Task<ActionResult<List<WardModel>>> GetWards()
        {

            DataSet ds = allReportContent.GetWards();
            List<WardModel> wardList = new List<WardModel>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                wardList.Add(new WardModel
                {                  
                    WardName = Convert.ToString(ds.Tables[0].Rows[i]["WardName"]),                    
                });

            }

            await Task.Yield();
            return Ok(wardList);

        }

        [HttpGet("getvehicles")]
        public async Task<ActionResult<List<Vehicle>>> GetVehicles()
        {

            Vehicle vehicle = new Vehicle();
            DataSet ds = allReportContent.GetVehicleData(vehicle);

            List<Vehicle> vehicleList = new List<Vehicle>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                vehicleList.Add(new Vehicle
                {
                    VehicleID = Convert.ToInt32(ds.Tables[0].Rows[i]["VehicleID"]),
                    VehicleNo = Convert.ToString(ds.Tables[0].Rows[i]["VehicleNo"]),
                    VehicleType = Convert.ToString(ds.Tables[0].Rows[i]["VehicleType"]),
                });

            }

            await Task.Yield();
            return Ok(vehicleList);


        }


        [HttpGet("getagencies/{id}")]
        public async Task<IActionResult> GetAgencies(int id)
        {

            DataSet ds = allReportContent.GetAgencyData(id);
            List<AgencyModel> agencyModelList = new List<AgencyModel>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                agencyModelList.Add(new AgencyModel
                {
                    AgencyID = Convert.ToInt32(ds.Tables[0].Rows[i]["AgencyID"]),
                    AgencyName = Convert.ToString(ds.Tables[0].Rows[i]["AgencyName"]),
                    IsActive = Convert.ToInt32(ds.Tables[0].Rows[i]["IsActive"]),
                });
            }
            await Task.Yield();
            return Ok(agencyModelList);
        }

        [HttpPost("getworkcode")]
        public async Task<IActionResult> GetWorkCodes(WorkCodeModel workCodeModel)
        {
           
            DataSet ds = allReportContent.GetWorkCodeData(workCodeModel);
            List<WorkCodeModel> workCodeModellList = new List<WorkCodeModel>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    workCodeModellList.Add(new WorkCodeModel
                    {
                        WorkcodeID = Convert.ToInt32(ds.Tables[0].Rows[i]["WorkcodeID"]),
                        Workcode = Convert.ToString(ds.Tables[0].Rows[i]["Workcode"]),
                       
                    });
                }
               
            }
            await Task.Yield();
            return Ok(workCodeModellList);
        }


        [HttpGet("getmaterialtype")]
        public async Task<IActionResult> GetMaterialType()
        {

            DataSet ds = allReportContent.GetMaterialTypes();
            List<MaterialTypeModel> materialTypeModellList = new List<MaterialTypeModel>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    materialTypeModellList.Add(new MaterialTypeModel
                    {
                       // MaterialTypeID = Convert.ToInt32(ds.Tables[0].Rows[i]["MaterialTypeName"]),
                        MaterialTypeName = Convert.ToString(ds.Tables[0].Rows[i]["MaterialTypeName"]),

                    });
                }
            }
            await Task.Yield();
            return Ok(materialTypeModellList);
        }
        [HttpGet("getyesno")]
        public async Task<IActionResult> GetYesNo()
        {

            DataSet ds = allReportContent.GetYesNoDdl();
            List<CommonModel> commonModellList = new List<CommonModel>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    commonModellList.Add(new CommonModel
                    {
                        // MaterialTypeID = Convert.ToInt32(ds.Tables[0].Rows[i]["MaterialTypeName"]),
                        Name = Convert.ToString(ds.Tables[0].Rows[i]["DisplayText"]),

                    });
                }
            }
            await Task.Yield();
            return Ok(commonModellList);
        }

        [HttpPost("addtransactdata")]
        public async Task<IActionResult> AddTransactData(Transact objTransact)
        {

            DataSet ds = allReportContent.AddTransactData(objTransact);
            Transact trans =new Transact ();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                trans.SlipSrNo =Convert.ToString( ds.Tables[0].Rows[0]["SlipSrNo"]);
            }
                await Task.Yield();
            return Ok(trans);
        }

        [HttpPost("updatetransactdata")]
        public async Task<IActionResult> UpdateTransactData(Transact objTransact)
        {

            DataSet ds = allReportContent.UpdateTransactData(objTransact);
            Transact trans = new Transact();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                trans.SlipSrNo = Convert.ToString(ds.Tables[0].Rows[0]["SlipSrNo"]);
            }
            await Task.Yield();
            return Ok(trans);
        }


        [HttpGet("gettransactdata")]
        public async Task<IActionResult> Getransact()
        {

            DataSet ds = allReportContent.GetTransactData();
            List<Transact> trancastList = new List<Transact>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    trancastList.Add(new Transact
                    {
                        SlipSrNo = Convert.ToString(ds.Tables[0].Rows[i]["SlipSrNo"]),
                        VehicleNo = Convert.ToString(ds.Tables[0].Rows[i]["VehicleNo"]),
                        LogsheetNo = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["LogsheetNo"]))? Convert.ToInt32(ds.Tables[0].Rows[i]["LogsheetNo"]):null,
                        WeightIn = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["WeightIn"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["WeightIn"]):null,
                        WeightOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["WeightOut"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["WeightOut"]):null,
                        TransDateTimeIn =!string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["TransDateTimeIn"]))? Convert.ToDateTime(ds.Tables[0].Rows[i]["TransDateTimeIn"]): null,
                        TransDateTimeOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["TransDateTimeOut"])) ? Convert.ToDateTime(ds.Tables[0].Rows[i]["TransDateTimeOut"]) : null,
                        TypeOfMaterial = Convert.ToString(ds.Tables[0].Rows[i]["TypeOfMaterial"]),
                        Agency = Convert.ToString(ds.Tables[0].Rows[i]["Agency"]),
                        ActualNetWeight = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["ActualNetWeight"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["ActualNetWeight"]):null,
                        OnBMCDuty = Convert.ToString(ds.Tables[0].Rows[i]["OnBMCDuty"]),
                        TPCCover = Convert.ToString(ds.Tables[0].Rows[i]["TPCCover"]),
                        UpdatedByIn = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["UpdatedByIn"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["UpdatedByIn"]):null,
                        UpdatedByOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["UpdatedByOut"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["UpdatedByOut"]):null,
                        CancelStatus = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["CancelStatus"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["CancelStatus"]):null,
                        PrintStatus = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["PrintStatus"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["PrintStatus"]):null,
                        Ward = Convert.ToString(ds.Tables[0].Rows[i]["Ward"]),
                        WorkCode = Convert.ToString(ds.Tables[0].Rows[i]["WorkCode"]),
                    });
                }
            }
            await Task.Yield();
            return Ok(trancastList);
        }

        [HttpGet("gettransactdatabyslipNo/{id}")]
        public async Task<IActionResult> GetTransactDataBySlipNo(string id)
        {

            DataSet ds = allReportContent.GetTransactDataBySlipNo(id);
           Transact trancastList = new Transact();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    trancastList=  new Transact
                    {
                        SlipSrNo = Convert.ToString(ds.Tables[0].Rows[i]["SlipSrNo"]),
                        VehicleNo = Convert.ToString(ds.Tables[0].Rows[i]["VehicleNo"]),
                        LogsheetNo = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["LogsheetNo"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["LogsheetNo"]) : null,
                        WeightIn = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["WeightIn"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["WeightIn"]) : null,
                        WeightOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["WeightOut"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["WeightOut"]) : null,
                        TransDateTimeIn = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["TransDateTimeIn"])) ? Convert.ToDateTime(ds.Tables[0].Rows[i]["TransDateTimeIn"]) : null,
                        TransDateTimeOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["TransDateTimeOut"])) ? Convert.ToDateTime(ds.Tables[0].Rows[i]["TransDateTimeOut"]) : null,
                        TypeOfMaterial = Convert.ToString(ds.Tables[0].Rows[i]["TypeOfMaterial"]),
                        Agency = Convert.ToString(ds.Tables[0].Rows[i]["Agency"]),
                        ActualNetWeight = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["ActualNetWeight"])) ? Convert.ToDecimal(ds.Tables[0].Rows[i]["ActualNetWeight"]) : null,
                        OnBMCDuty = Convert.ToString(ds.Tables[0].Rows[i]["OnBMCDuty"]),
                        TPCCover = Convert.ToString(ds.Tables[0].Rows[i]["TPCCover"]),
                        UpdatedByIn = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["UpdatedByIn"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["UpdatedByIn"]) : null,
                        UpdatedByOut = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["UpdatedByOut"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["UpdatedByOut"]) : null,
                        CancelStatus = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["CancelStatus"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["CancelStatus"]) : null,
                        PrintStatus = !string.IsNullOrEmpty(Convert.ToString(ds.Tables[0].Rows[i]["PrintStatus"])) ? Convert.ToInt32(ds.Tables[0].Rows[i]["PrintStatus"]) : null,
                        Ward = Convert.ToString(ds.Tables[0].Rows[i]["Ward"]),
                        WorkCode = Convert.ToString(ds.Tables[0].Rows[i]["WorkCode"]),
                    };
                }
            }
            await Task.Yield();
            return Ok(trancastList);
        }



        [HttpPost("userlogin")]
        public async Task<IActionResult> Login(UserModel objUser)
        {

            DataSet ds = allReportContent.GetLogin(objUser);
            UserModel userModel = new UserModel();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                userModel.UserID = Convert.ToInt32(ds.Tables[0].Rows[0]["UserID"]);
                userModel.Username = Convert.ToString(ds.Tables[0].Rows[0]["Username"]);
                userModel.RoleId = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleId"]);
                userModel.WBId = Convert.ToInt32(ds.Tables[0].Rows[0]["WBID"]);
            }
            await Task.Yield();
            return Ok(userModel);
        }
    }
}
