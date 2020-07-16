#nullable enable
using System;
using FileHelpers;

namespace P21_Order_Import
{
    [DelimitedRecord("\t")]
    public class OrderHeader
    {
        [FieldOptional]
        public string? ImportSetNo { get; set;}
        [FieldOptional]
        public decimal? CustID { get; set; }
        [FieldOptional]
        public string? CustName { get; set; }
        [FieldOptional]
        public string? CompanyID { get; set; }
        [FieldOptional]
        public decimal? SalesLocID { get; set; }
        [FieldOptional]
        public string? CustPONum { get; set; }
        [FieldOptional]
        public string? ContactID { get; set; }
        [FieldOptional]
        public string? ContactName { get; set; }
        [FieldOptional]
        public string? Taker { get; set; }
        [FieldOptional]
        public string? JobName { get; set; } //10

        [FieldOptional]
        
        public DateTime? OrderDate { get; set; }

        [FieldOptional]
        
        public DateTime? ReqDate { get; set; }

        [FieldOptional]
        public string? Quote { get; set; }

        [FieldOptional]
        public string? Approved { get; set; }
        [FieldOptional]
        public int? ShipToID { get; set; }
        [FieldOptional]
        public string? ShipToName { get; set; }
        [FieldOptional]
        public string? ShipToAddress1 { get; set; }

        [FieldOptional]
        public string? ShipToAddress2 { get; set; }
        [FieldOptional]
        public string? ShipToCity { get; set; }
        [FieldOptional]
        public string? ShipToState { get; set; } //20
        [FieldOptional]
        public string? ShipToZip { get; set; }
        [FieldOptional]
        public string? ShipToCountry { get; set; }
        [FieldOptional]
        //[FieldNullValue(typeof(int), "0")]
        public int? SourceLocID { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(int), "0")]
        public int? CarrierID { get; set; }

        [FieldOptional]
        public string? CarrierName { get; set; } //25

        [FieldOptional]
        public string? Route { get; set; }

        [FieldOptional]
        public string? PackingBasis { get; set; }

        [FieldOptional]
        public string? DeliveryInstructions { get; set; }

        [FieldOptional]
        public string? Terms { get; set; }

        [FieldOptional]
        public string? TermsDesc { get; set; } //30

        [FieldOptional]
        public string? WillCall { get; set; }

        [FieldOptional]
        public string? Class1 { get; set; }

        [FieldOptional]
        public string? Class2 { get; set; }

        [FieldOptional]
        public string? Class3 { get; set; }

        [FieldOptional]
        public string? Class4 { get; set; } //35

        [FieldOptional]
        public string? Class5 { get; set; }

        [FieldOptional]
        public string? RmaFlag { get; set; }

        [FieldOptional]
        public string? Freightcode { get; set; }

        [FieldOptional]
        public string? ThirdPartyBillingFlagDesc { get; set; }

        [FieldOptional]
        public string? CaptureusageDefault { get; set; } //40

        [FieldOptional]
        public string? Allocate { get; set; }

        [FieldOptional]
        public string? ContractNum { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(long), "0")]
        public long? InvoiceBatchNum { get; set; }

        [FieldOptional]
        public string? ShipToEmail { get; set; }

        [FieldOptional]
        public string? SetInvoiceExchangerateSourceDesc { get; set; } //45

        [FieldOptional]
        public string? ShipToPhone { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(long), "0")]
        public long? CurrencyID { get; set; }

        [FieldOptional]
        public string? ApplyBuilderAllowanceFlag { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(DateTime), "1900-01-01")]
        //[FieldConverter(ConverterKind.Date, "MM-dd-yyyy")]
        public DateTime? QuoteExpirationDate { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(DateTime), "1900-01-01")]
        //[FieldConverter(ConverterKind.Date, "MM-dd-yyyy")]
        public DateTime? PromiseDate { get; set; } //50

        [FieldOptional]
        public string? ImportAsQuote { get; set; }

        [FieldOptional]
        public string? QuoteNum { get; set; }

        [FieldOptional]
        public string? WebRefNum { get; set; }

        [FieldOptional]
        public string? CreateInvoice { get; set; }

        [FieldOptional]
        public string? StrategicPricingLibraryID { get; set; } //55
         
        [FieldOptional]
        public string? MerchandiseCredit { get; set; }

        [FieldOptional]
        public string? OrderTypePriority { get; set; }

        [FieldOptional]
        public string? UpsCode { get; set; }

        [FieldOptional]
        public string? SupplierOrderNum { get; set; }

        [FieldOptional]
        public string? SupplierReleaseNum { get; set; } //60

        [FieldOptional]
        public string? PlacedByName { get; set; }

        [FieldOptional]
        //[FieldNullValue(typeof(long), "0")]
        public long? OrderType830 { get; set; }
        [FieldOptional]
        public string? ShipToAddress3 { get; set; }

    }
}
