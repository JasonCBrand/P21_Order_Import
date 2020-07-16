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
    public class OrderLineNotepad
    {
        [FieldOptional]
        public string? ImportSetNo { get; set; }
        [FieldOptional]
        public int? LineNo { get; set; }
        [FieldOptional]
        public string? Topic { get; set; }
        [FieldOptional]
        public string? Note { get; set; }
        [FieldOptional]
        public string? ActivationDate { get; set; }
        [FieldOptional]
        public string? ExpirationDate { get; set; }
        [FieldOptional]
        public string? EntryDate { get; set; }
        [FieldOptional]
        public string? NotepadClassID { get; set; }
        [FieldOptional]
        public string? Mandatory { get; set; }


    }
}
