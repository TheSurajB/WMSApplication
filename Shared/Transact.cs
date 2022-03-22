

using System.ComponentModel.DataAnnotations;

namespace WMSAPP.Shared
{
    public class Transact
    {
        public int? ID { get; set; }
       // [Required]
        public string? SlipSrNo { get; set; }
        //[Required]
        public string? VehicleNo { get; set; }
        public string? Zone { get; set; }

        //[Required]
        //[StringLength(7, ErrorMessage = "LogsheetNo is too long.")]
        public int? LogsheetNo { get; set; }
        public string? WBINImage { get; set; }
        public string? WBOutImage { get; set; }
        public DateTime? TransDateTimeIn { get; set; }
        public DateTime? TransDateTimeOut { get; set; }
        public string? TypeOfMaterial { get; set; }

       // [Required]
        public string? Agency { get; set; }
        public int? CancelStatus { get; set; }
        public int? PrintStatus { get; set; }

        //[Required]
        public decimal? WeightIn { get; set; }

       // [Required]
        public decimal? WeightOut { get; set; }
        public decimal? ActualNetWeight { get; set; }
        public int? UpdatedByIn { get; set; }
        public int? UpdatedByOut { get; set; }
        public int? JobCodeEntryType { get; set; }
        public string? Remarks { get; set; }
       // [Required]
        public string? Ward { get; set; }
        public string? WorkCode { get; set; }

        //[Required]
        public int? WorkCodeID { get; set; }
        //[Required]
        public string? TPCCover { get; set; }
       // [Required]
        public string? OnBMCDuty { get; set; }
        public string? DisplayTime { get; set; }
        public decimal? TareWt { get; set; }
    }
}
