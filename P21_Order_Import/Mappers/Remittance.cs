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
        public DateTime? CCExpirationDate { get; set; } //10
        [FieldOptional]
        public DateTime? CCAuthorizedDate { get; set; }
        [FieldOptional]
        public DateTime? CCAuthorizedNumber { get; set; }
        [FieldOptional]
        public int? Period { get; set; }
        [FieldOptional]
        public long? Year { get; set; }
        [FieldOptional]
        public string? CreditNumber { get; set; }
        [FieldOptional]
        public long? WebProcessingCenterID { get; set; }
        
    }
}
