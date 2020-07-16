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
        public string? CardNumber { get; set; }
        [FieldOptional]
        public string? FirstName { get; set; }
        [FieldOptional]
        public string? LastName { get; set; }
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
        public long? SwitchIssueNumber { get; set; } //10
        [FieldOptional]
        public long? ReferenceNumber { get; set; }
        [FieldOptional]
        public string? TransactioNID { get; set; }
        [FieldOptional]
        //p21 help file says list but response should be a string like M: street address and postal codes match
        public string? AVSResponseCode { get; set; } 
        [FieldOptional]
        //p21 help file says list but response should be a string like M: Match
        public string? CVVResponseCode { get; set; }
    }
}
