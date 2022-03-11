

namespace WMSAPP.Shared
{
    public class Transact
    {
        public int ID { get; set; }
        public string? SlipSrNo { get; set; }
        public string? VehicleNo { get; set; }
        public string? Zone { get; set; }
        public int ? LogsheetNo { get; set; }
        public string? WBINImage { get; set; }
        public string? WBOutImage { get; set; }
        public DateTime TransDateTimeIn { get; set; }
        public DateTime TransDateTimeOut { get; set; }
        public string? TypeOfMaterial { get; set; }
        public string? Agency { get; set; }
        public int CancelStatus { get; set; }
        public int PrintStatus { get; set; }
        public decimal WeightIn { get; set; }
        public decimal WeightOut { get; set; }
        public decimal ActualNetWeight { get; set; }
        public int UpdatedByIn { get; set; }
        public int UpdatedByOut { get; set; }
        public int JobCodeEntryType { get; set; }
        public string? Remarks { get; set; }
        public string? Ward { get; set; }
        public string? WorkCode { get; set; }
        public string? TPCCover { get; set; }
        public string? OnBMCDuty { get; set; }
        public string? DisplayTime { get; set; }
        public decimal TareWt { get; set; }
    }
}
