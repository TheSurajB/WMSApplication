using WMSAPP.Shared;

namespace WMSAPP.Client.Services
{
    public static class CustomMapper
    {
        public static Transact TransactInModelToTransact(TransactInModel transactIn)
        {
            Transact trans = new Transact();
            trans.ID =transactIn.ID;
            trans.SlipSrNo =transactIn.SlipSrNo;
            trans.WBINImage =transactIn.WBINImage;
            trans.WBOutImage =transactIn.WBOutImage;
            trans.LogsheetNo =transactIn.LogsheetNo;
            trans.Zone =transactIn.Zone;
            trans.VehicleNo =transactIn.VehicleNo;
            trans.Agency =transactIn.Agency;
            trans.TypeOfMaterial =transactIn.TypeOfMaterial;
            trans.Ward =transactIn.Ward;
            trans.WorkCodeID =transactIn.WorkCodeID;
            trans.WorkCode =transactIn.WorkCode;
            trans.CancelStatus =transactIn.CancelStatus;
            trans.PrintStatus =transactIn.PrintStatus;
            trans.WeightIn =transactIn.WeightIn;
            trans.WeightOut =transactIn.WeightOut;
            trans.ActualNetWeight =transactIn.ActualNetWeight;
            trans.UpdatedByIn =transactIn.UpdatedByIn;
            trans.UpdatedByOut =transactIn.UpdatedByOut;
            trans.JobCodeEntryType =transactIn.JobCodeEntryType;
            trans.Remarks =transactIn.Remarks;
            trans.TPCCover =transactIn.TPCCover;
            trans.OnBMCDuty =transactIn.OnBMCDuty;
            trans.DisplayTime =transactIn.DisplayTime;
            trans.TareWt =transactIn.TareWt;
            trans.TransDateTimeIn = transactIn.TransDateTimeIn;
            trans.TransDateTimeOut=transactIn.TransDateTimeOut;
            return trans;
        }

        public static Transact TransactOutModelToTransact(TransactOutModel transactOut)
        {
            Transact trans = new Transact();
            trans.ID = transactOut.ID;
            trans.SlipSrNo = transactOut.SlipSrNo;
            trans.WBINImage = transactOut.WBINImage;
            trans.WBOutImage = transactOut.WBOutImage;
            trans.LogsheetNo = transactOut.LogsheetNo;
            trans.Zone = transactOut.Zone;
            trans.VehicleNo = transactOut.VehicleNo;
            trans.Agency = transactOut.Agency;
            trans.TypeOfMaterial = transactOut.TypeOfMaterial;
            trans.Ward = transactOut.Ward;
            trans.WorkCodeID = transactOut.WorkCodeID;
            trans.WorkCode = transactOut.WorkCode;
            trans.CancelStatus = transactOut.CancelStatus;
            trans.PrintStatus = transactOut.PrintStatus;
            trans.WeightIn = transactOut.WeightIn;
            trans.WeightOut = transactOut.WeightOut;
            trans.ActualNetWeight = transactOut.ActualNetWeight;
            trans.UpdatedByIn = transactOut.UpdatedByIn;
            trans.UpdatedByOut = transactOut.UpdatedByOut;
            trans.JobCodeEntryType = transactOut.JobCodeEntryType;
            trans.Remarks = transactOut.Remarks;
            trans.TPCCover = transactOut.TPCCover;
            trans.OnBMCDuty = transactOut.OnBMCDuty;
            trans.DisplayTime = transactOut.DisplayTime;
            trans.TareWt = transactOut.TareWt;
            trans.TransDateTimeIn = transactOut.TransDateTimeIn;
            trans.TransDateTimeOut = transactOut.TransDateTimeOut;
            return trans;
        }


        public static TransactInModel TransactToTransactInModel(Transact transact)
        {
            TransactInModel transactIn = new TransactInModel();
            transactIn.ID = transact.ID;
            transactIn.SlipSrNo = transact.SlipSrNo;
            transactIn.WBINImage = transact.WBINImage;
            transactIn.WBOutImage = transact.WBOutImage;
            transactIn.LogsheetNo = transact.LogsheetNo;
            transactIn.Zone = transact.Zone;
            transactIn.VehicleNo = transact.VehicleNo;
            transactIn.Agency = transact.Agency;
            transactIn.TypeOfMaterial = transact.TypeOfMaterial;
            transactIn.Ward = transact.Ward;
            transactIn.WorkCodeID = transact.WorkCodeID;
            transactIn.WorkCode = transact.WorkCode;
            transactIn.CancelStatus = transact.CancelStatus;
            transactIn.PrintStatus = transact.PrintStatus;
            transactIn.WeightIn = transact.WeightIn;
            transactIn.WeightOut = transact.WeightOut;
            transactIn.ActualNetWeight = transact.ActualNetWeight;
            transactIn.UpdatedByIn = transact.UpdatedByIn;
            transactIn.UpdatedByOut = transact.UpdatedByOut;
            transactIn.JobCodeEntryType = transact.JobCodeEntryType;
            transactIn.Remarks = transact.Remarks;
            transactIn.TPCCover = transact.TPCCover;
            transactIn.OnBMCDuty = transact.OnBMCDuty;
            transactIn.DisplayTime = transact.DisplayTime;
            transactIn.TareWt = transact.TareWt;
            transactIn.TransDateTimeIn = transact.TransDateTimeIn;
            transactIn.TransDateTimeOut = transact.TransDateTimeOut;
            return transactIn;
        }

        public static TransactOutModel TransactToTransactOutModel(Transact transact)
        {
            TransactOutModel transactOut = new TransactOutModel();
            transactOut.ID = transact.ID;
            transactOut.SlipSrNo = transact.SlipSrNo;
            transactOut.WBINImage = transact.WBINImage;
            transactOut.WBOutImage = transact.WBOutImage;
            transactOut.LogsheetNo = transact.LogsheetNo;
            transactOut.Zone = transact.Zone;
            transactOut.VehicleNo = transact.VehicleNo;
            transactOut.Agency = transact.Agency;
            transactOut.TypeOfMaterial = transact.TypeOfMaterial;
            transactOut.Ward = transact.Ward;
            transactOut.WorkCodeID = transact.WorkCodeID;
            transactOut.WorkCode = transact.WorkCode;
            transactOut.CancelStatus = transact.CancelStatus;
            transactOut.PrintStatus = transact.PrintStatus;
            transactOut.WeightIn = transact.WeightIn;
            transactOut.WeightOut = transact.WeightOut;
            transactOut.ActualNetWeight = transact.ActualNetWeight;
            transactOut.UpdatedByIn = transact.UpdatedByIn;
            transactOut.UpdatedByOut = transact.UpdatedByOut;
            transactOut.JobCodeEntryType = transact.JobCodeEntryType;
            transactOut.Remarks = transact.Remarks;
            transactOut.TPCCover = transact.TPCCover;
            transactOut.OnBMCDuty = transact.OnBMCDuty;
            transactOut.DisplayTime = transact.DisplayTime;
            transactOut.TareWt = transact.TareWt;
            transactOut.TransDateTimeIn = transact.TransDateTimeIn;
            transactOut.TransDateTimeOut = transact.TransDateTimeOut;
            return transactOut;
        }
    }
}
