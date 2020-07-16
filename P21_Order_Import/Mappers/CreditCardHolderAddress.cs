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
    public class CreditCardHolderAddress
    {
        [FieldOptional]
        public int? ImportSetNo { get; set; }
        [FieldOptional]
        public int? CardNumber { get; set; }
        [FieldOptional]
        public int? FirstName { get; set; }
        [FieldOptional]
        public DateTime? LasttName { get; set; }
        [FieldOptional]
        public string? StreetAddress1 { get; set; }
        [FieldOptional]
        public string? StreetAddress2 { get; set; }
        [FieldOptional]
        public string? City { get; set; }
        [FieldOptional]
        public string? State { get; set; }
        [FieldOptional]
        public string? ZipCode { get; set; }
        [FieldOptional]
        public DateTime? SwitchIssueNumber { get; set; } //10
        [FieldOptional]
        public DateTime? ReferenceNumber { get; set; }
        [FieldOptional]
        public DateTime? TransactioNID { get; set; }
        [FieldOptional]
        public List<string?> AVSResponseCode { get; set; }
        [FieldOptional]
        public List<string?> CVVResponseCode { get; set; }
    }
}
