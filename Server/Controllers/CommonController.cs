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
        [HttpGet("GetVehicles")]
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
    }
}
