#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace P21_Order_Import
{
    [DelimitedRecord("\t")]
    public class Remittance
    {
        [FieldOptional]
        public int? ImportSetNo { get; set;}
        [FieldOptional]
        public int? PaymentTypeID { get; set; }
        [FieldOptional]
        public int? PaymentAmount { get; set; }
        [FieldOptional]
        [FieldConverter(ConverterKind.Date, "MM/dd/yy")]
        public DateTime? PaymentDate { get; set; }
        [FieldOptional]
        public string? PaymentDesc { get; set; }
        [FieldOptional]
        public string? CheckNumber { get; set; }
        [FieldOptional]
        public string? CCName { get; set; }
        [FieldOptional]
        public string? CCNumber { get; set; }
        [FieldOptional]
        public string? CustomerVerificationValue { get; set; }
        [FieldOptional]
        [FieldConverter(ConverterKind.Date, "MM/dd/yy")]
        public DateTime? CCExpirationDate { get; set; } //10
        [FieldOptional]
        [FieldConverter(ConverterKind.Date, "MM/dd/yy")]
        public DateTime? CCAuthorizedDate { get; set; }
        [FieldOptional]
        public long? CCAuthorizedNumber { get; set; }
        [FieldOptional]
        public int? Period { get; set; }
        [FieldOptional]
        public long? Year { get; set; }
        [FieldOptional]
        public long? CreditNumber { get; set; }
        [FieldOptional]
        public long? WebProcessingCenterID { get; set; }
        
    }
}
