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
        public DataSet GetLogin(UserModel user)
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
                par[0].Value = user.Username;
                par[1].Value = user.Password;
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

        public DataSet GetWeighBridge()
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                ds = sQLDAL.ExecuteDatasetSP("spWeighBridge_GetWeighBridges");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
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
                par[0].Value = !string.IsNullOrEmpty(vehicleModel.VehicleNo) ? vehicleModel.VehicleNo : null;
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
                                         new SqlParameter("@TransDateTimeIn",SqlDbType.DateTime),
                                        new SqlParameter("@TypeOfMaterial",SqlDbType.NVarChar),
                                         new SqlParameter("@Agency",SqlDbType.NVarChar),
                                          new SqlParameter("@CancelStatus",SqlDbType.Int),
                                          new SqlParameter("@PrintStatus",SqlDbType.Int),
                                        new SqlParameter("@WeightIn",SqlDbType.Decimal),
                                         new SqlParameter("@UpdatedByIn",SqlDbType.Int),
                                          new SqlParameter("@WorkCode",SqlDbType.Int),
                                          new SqlParameter("@JobCodeEntryType",SqlDbType.NVarChar),
                                           new SqlParameter("@OnBMCDuty",SqlDbType.NVarChar),
                                            new SqlParameter("@TPCCover",SqlDbType.NVarChar),
                                    };
                par[0].Value = transactModel.VehicleNo;
                par[1].Value = transactModel.LogsheetNo;
                par[2].Value = transactModel.WBINImage;               
                par[3].Value = transactModel.TransDateTimeIn;
                par[4].Value = transactModel.TypeOfMaterial;
                par[5].Value = transactModel.Agency;
                par[6].Value = transactModel.CancelStatus;
                par[7].Value = transactModel.PrintStatus;
                par[8].Value = transactModel.WeightIn;
                par[9].Value = transactModel.UpdatedByIn;
                par[10].Value = transactModel.WorkCode;
                par[11].Value = transactModel.JobCodeEntryType;
                par[12].Value = transactModel.OnBMCDuty;
                par[13].Value = transactModel.TPCCover;
                DataSet ds = sQLDAL.ExecuteDatasetSP("spTransact_InsertRecord", par);
                return ds;

            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
        }

        public DataSet UpdateTransactData(Transact transactModel)
        {
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@SlipSrNo",SqlDbType.NVarChar),
                                        new SqlParameter("@WBOutImage",SqlDbType.NVarChar),                                        
                                         new SqlParameter("@TransDateTimeOut",SqlDbType.DateTime),
                                        new SqlParameter("@WeightOut",SqlDbType.Decimal),
                                         new SqlParameter("@ActualNetWeight",SqlDbType.Decimal),
                                          new SqlParameter("@UpdatedByOut",SqlDbType.Int),
                                          new SqlParameter("@Remarks",SqlDbType.NVarChar),
                              
                                    };
                par[0].Value = transactModel.SlipSrNo;
                par[1].Value = transactModel.WBOutImage;
                par[2].Value = transactModel.TransDateTimeOut;
                par[3].Value = transactModel.WeightOut;
                par[4].Value = transactModel.ActualNetWeight;
                par[5].Value = transactModel.UpdatedByOut;
                par[6].Value = transactModel.Remarks;
                DataSet ds = sQLDAL.ExecuteDatasetSP("spTransact_UpdateRecord", par);
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

        public DataSet GetTransactData()
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                //SqlParameter[] par ={
                //                        new SqlParameter("@SlipSrNo",SqlDbType.NVarChar),
                //                        new SqlParameter("@VehicleNo",SqlDbType.NVarChar),
                //                         new SqlParameter("@LogsheetNo",SqlDbType.NVarChar),
                //                        new SqlParameter("@TransDateIn",SqlDbType.NVarChar),
                //                    };
                //par[0].Value = !string.IsNullOrEmpty(transactModel.SlipSrNo) ? transactModel.SlipSrNo : null;
                //par[1].Value = !string.IsNullOrEmpty(transactModel.VehicleNo) ? transactModel.VehicleNo : null;
                //par[0].Value = !string.IsNullOrEmpty(Convert.ToString(transactModel.LogsheetNo)) ? transactModel.LogsheetNo : null;
                //par[1].Value = !string.IsNullOrEmpty(transactModel.SlipSrNo) ? transactModel.SlipSrNo : null;
                ds = sQLDAL.ExecuteDatasetSP("spTransact_GetTransactData");
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }

        public DataSet GetTransactDataBySlipNo(string slipno)
        {
            DataSet ds;
            try
            {
                sQLDAL = new SQLDAL();
                SqlParameter[] par ={
                                        new SqlParameter("@SlipSrNo",SqlDbType.NVarChar),                                       
                                    };
                par[0].Value = !string.IsNullOrEmpty(slipno) ? slipno : null;            
                ds = sQLDAL.ExecuteDatasetSP("spTransact_GetTransactData", par);
            }
            catch (Exception w)
            {
                throw new Exception(w.Message);
            }
            return ds;
        }
    }
}
