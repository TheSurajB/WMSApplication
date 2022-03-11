using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMSAPP.Shared;

namespace WMSAPP.Server.Repository
{
    internal class AllReportContent
    {
        SQLDAL sQLDAL = null;
        DataSet ds;
        public DataSet GetLogin(string Username, string password)
        {
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@UserName",SqlDbType.NVarChar),
                                        new SqlParameter("@Password",SqlDbType.NVarChar),
                                         new SqlParameter("@IPAddress",SqlDbType.NVarChar),
                                          new SqlParameter("@DeviceId",SqlDbType.NVarChar),
                                    };
                par[0].Value = Username;
                par[1].Value = password;
                par[2].Value = "1233";
                par[3].Value = "122";
                DataSet ds = sQLDAL.ExecuteDatasetSP("VaildUser", par);
                return ds;

            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
        }
        public DataSet GetWards()
        {
            DataSet ds;
            try   
            {
                sQLDAL = new SQLDAL();         
                ds = sQLDAL.ExecuteDatasetSP("spWard_GetWards");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetZones()
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                ds = sQLDAL.ExecuteDatasetSP("spZone_GetZones");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetYesNoDdl()
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                ds = sQLDAL.ExecuteDatasetSP("spBoolean_GetYesNoDDL");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetMaterialTypes()
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                ds = sQLDAL.ExecuteDatasetSP("spMaterialType_GetMaterialTypes");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetVehicleData(Vehicle vehicleModel)
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@VehicleNo",SqlDbType.NVarChar),
                                        new SqlParameter("@VehicleID",SqlDbType.NVarChar),
                                    };
                par[0].Value = !string.IsNullOrEmpty(vehicleModel.VehicleNo)? vehicleModel.VehicleNo : null;
                par[1].Value = vehicleModel.VehicleID;
                ds = sQLDAL.ExecuteDatasetSP("spVehicle_GetVehicle", par);
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetAgencyData(int agencyId)
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@AgencyID",SqlDbType.Int),
                                       
                                    };
                par[0].Value = !string.IsNullOrEmpty(Convert.ToString(agencyId)) ? agencyId : 0;
               
                ds = sQLDAL.ExecuteDatasetSP("spAgency_GetAgencies", par);
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet GetWorkCodeData(WorkCodeModel workCodeModel)
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@WorkcodeID",SqlDbType.NVarChar),
                                        new SqlParameter("@Zone",SqlDbType.NVarChar),
                                    };
                par[0].Value = !string.IsNullOrEmpty(Convert.ToString(workCodeModel.WorkcodeID)) ? workCodeModel.WorkcodeID : null;
                par[1].Value = !string.IsNullOrEmpty(Convert.ToString(workCodeModel.Zone)) ? workCodeModel.Zone : null; ;
                ds = sQLDAL.ExecuteDatasetSP("spWorkCode_GetWorkCodes", par);
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
        public DataSet AddTransactData(Transact transactModel)
        {
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@VehicleNo",SqlDbType.NVarChar),
                                        new SqlParameter("@LogsheetNo",SqlDbType.NVarChar),
                                         new SqlParameter("@WBINImage",SqlDbType.NVarChar),
                                          new SqlParameter("@WBOutImage",SqlDbType.NVarChar),
                                    };
                par[0].Value = transactModel.VehicleNo;
                par[1].Value = transactModel.LogsheetNo;
                par[2].Value = transactModel.WBINImage;
                par[3].Value = transactModel.WBOutImage;
                DataSet ds = sQLDAL.ExecuteDatasetSP("spTransact_InsertRecord", par);
                return ds;

            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
        }


        public DataSet GetVehicleData(Transact transactModel)
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@SlipSrNo",SqlDbType.NVarChar),
                                        new SqlParameter("@VehicleNo",SqlDbType.NVarChar),
                                         new SqlParameter("@LogsheetNo",SqlDbType.NVarChar),
                                        new SqlParameter("@TransDateIn",SqlDbType.NVarChar),
                                    };
                par[0].Value = !string.IsNullOrEmpty(transactModel.SlipSrNo) ? transactModel.SlipSrNo : null;
                par[1].Value = !string.IsNullOrEmpty(transactModel.VehicleNo) ? transactModel.VehicleNo : null; 
                par[0].Value = !string.IsNullOrEmpty(Convert.ToString(transactModel.LogsheetNo)) ? transactModel.LogsheetNo : null;
                par[1].Value = !string.IsNullOrEmpty(transactModel.SlipSrNo) ? transactModel.SlipSrNo : null; 
                ds = sQLDAL.ExecuteDatasetSP("spVehicle_GetVehicle", par);
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }

    }
}
