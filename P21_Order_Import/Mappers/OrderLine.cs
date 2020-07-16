#nullable enable
using System;
using FileHelpers;

namespace P21_Order_Import
{
    [DelimitedRecord("\t")]
    public class OrderLine
    {
        [FieldOptional]
        public string? ImportSetNo { get; set;}
        [FieldOptional]
        public int? LineNo { get; set; }
        [FieldOptional]
        public string? ItemID { get; set; }
        [FieldOptional]
        public decimal? UnitQty { get; set; }
        [FieldOptional]
        public string? UOM { get; set; } //5
        [FieldOptional]
        public decimal? UnitPrice { get; set; }
        [FieldOptional]
        public string? ExtDesc { get; set; }
        [FieldOptional]
        public int? SourceLocID { get; set; }
        [FieldOptional]
        public int? ShipLocID { get; set; }
        [FieldOptional]
        public string? ProdGroupID { get; set; } //10
        [FieldOptional]
        public long? SupplierID { get; set; }
        [FieldOptional]
        public string? SupplierName { get; set; }
        [FieldOptional]
        [FieldConverter(ConverterKind.Date, "M/d/yy")]
        public DateTime? RequiredDate { get; set; }
        [FieldConverter(ConverterKind.Date, "M/d/yy")]
        [FieldOptional]
        public DateTime? ExpediteDate { get; set; }
        [FieldOptional]
        public string? WillCall { get; set; } //15
        [FieldOptional]
        public string? TaxItem { get; set; }
        [FieldOptional]
        public string? OKtoInterchange { get; set; }
        [FieldOptional]
        public string? PricingUnit { get; set; }
        [FieldOptional]
        public decimal? CommissionCost { get; set; }
        [FieldOptional]
        public decimal? OtherCost { get; set; } //20
        [FieldOptional]
        public decimal? POCost { get; set; }
        [FieldOptional]
        public string? Disposition { get; set; }
        [FieldOptional]
        public string? Scheduled { get; set; }
        [FieldOptional]
        public string? ManualPriceOverride { get; set; }
        [FieldOptional]
        public string? CommissionCostEdited { get; set; } //25
        [FieldOptional]
        public string? OtherCostEdited { get; set; } 
        [FieldOptional]
        public string? CaptureUsage  { get; set; }
        [FieldOptional]
        public string? TagAndHoldClassID { get; set; }
        [FieldOptional]
        public string? ContractBinID { get; set; }
        [FieldOptional]
        public string? ContractNo { get; set; } //30
        [FieldOptional]
        public int? AllocationQty { get; set; } 
        [FieldOptional]
        public string? PromiseDate { get; set; }
        [FieldOptional]
        public string? RevisionLevel { get; set; }
        [FieldOptional]
        public string? ResolveItemContract { get; set; }
        [FieldOptional]
        public string? Sample { get; set; } //35
        [FieldOptional]
        public string? QuoteLineNo { get; set; }
        [FieldOptional]
        public string? QuoteComplete { get; set; }
    }
}
