using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FileHelpers;

namespace P21_Order_Import
{
    class SaveHelpers
    {
        public static void SaveHeaderFile(int rowCount, DataGridView grid, string fname)
        { 
            var engine = new FileHelperEngine<OrderHeader>();
            var list = new List<OrderHeader>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new OrderHeader()
                {
                    ImportSetNo = grid.Rows[x].Cells[0].Value.ToString() ?? "",
                    CustID = (decimal?)grid.Rows[x].Cells[1].Value,
                    CustName = grid.Rows[x].Cells[2].Value.ToString() ?? "",
                    CompanyID = grid.Rows[x].Cells[3].Value.ToString() ?? "",
                    SalesLocID = (decimal?)grid.Rows[x].Cells[4].Value,
                    CustPONum = grid.Rows[x].Cells[5].Value.ToString() ?? "",
                    ContactID = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    ContactName = grid.Rows[x].Cells[7].Value.ToString() ?? "",
                    Taker = grid.Rows[x].Cells[8].Value.ToString() ?? "",
                    JobName = grid.Rows[x].Cells[9].Value.ToString() ?? "",
                    OrderDate = (DateTime?)grid.Rows[x].Cells[10].Value,
                    ReqDate = (DateTime?)grid.Rows[x].Cells[11].Value,
                    Quote = grid.Rows[x].Cells[12].Value.ToString() ?? "",
                    Approved = grid.Rows[x].Cells[13].Value.ToString() ?? "",
                    ShipToID = (int?)grid.Rows[x].Cells[14].Value ?? 0,
                    ShipToName = grid.Rows[x].Cells[15].Value.ToString() ?? "",
                    ShipToAddress1 = grid.Rows[x].Cells[16].Value.ToString() ?? "",
                    ShipToAddress2 = grid.Rows[x].Cells[17].Value.ToString() ?? "",
                    ShipToCity = grid.Rows[x].Cells[18].Value.ToString() ?? "",
                    ShipToState = grid.Rows[x].Cells[19].Value.ToString() ?? "",
                    ShipToZip = grid.Rows[x].Cells[20].Value.ToString() ?? "",
                    ShipToCountry = grid.Rows[x].Cells[21].Value.ToString() ?? "",
                    SourceLocID = (int?)grid.Rows[x].Cells[22].Value ?? 0,
                    CarrierID = (int?)grid.Rows[x].Cells[23].Value ?? 0,
                    CarrierName = grid.Rows[x].Cells[24].Value.ToString() ?? "",
                    Route = grid.Rows[x].Cells[25].Value.ToString() ?? "",
                    PackingBasis = grid.Rows[x].Cells[26].Value.ToString() ?? "",
                    DeliveryInstructions = grid.Rows[x].Cells[27].Value.ToString() ?? "",
                    Terms = grid.Rows[x].Cells[28].Value.ToString() ?? "",
                    TermsDesc = grid.Rows[x].Cells[29].Value.ToString() ?? "",
                    WillCall = grid.Rows[x].Cells[30].Value.ToString() ?? "",
                    Class1 = grid.Rows[x].Cells[31].Value.ToString() ?? "",
                    Class2 = grid.Rows[x].Cells[32].Value.ToString() ?? "",
                    Class3 = grid.Rows[x].Cells[33].Value.ToString() ?? "",
                    Class4 = grid.Rows[x].Cells[34].Value.ToString() ?? "",
                    Class5 = grid.Rows[x].Cells[35].Value.ToString() ?? "",
                    RmaFlag = grid.Rows[x].Cells[36].Value.ToString() ?? "",
                    Freightcode = grid.Rows[x].Cells[37].Value.ToString() ?? "",
                    ThirdPartyBillingFlagDesc = grid.Rows[x].Cells[38].Value.ToString() ?? "",
                    CaptureusageDefault = grid.Rows[x].Cells[39].Value.ToString() ?? "",
                    Allocate = grid.Rows[x].Cells[40].Value.ToString() ?? "",
                    ContractNum = grid.Rows[x].Cells[41].Value.ToString() ?? "",
                    InvoiceBatchNum = (long?)grid.Rows[x].Cells[42].Value ?? 0,
                    ShipToEmail = grid.Rows[x].Cells[43].Value.ToString() ?? "",
                    SetInvoiceExchangerateSourceDesc = grid.Rows[x].Cells[44].Value.ToString() ?? "",
                    ShipToPhone = grid.Rows[x].Cells[45].Value.ToString() ?? "",
                    CurrencyID = (long?)grid.Rows[x].Cells[46].Value,
                    ApplyBuilderAllowanceFlag = grid.Rows[x].Cells[47].Value.ToString() ?? "",
                    QuoteExpirationDate = (DateTime?)grid.Rows[x].Cells[48].Value,
                    PromiseDate = (DateTime?)grid.Rows[x].Cells[49].Value,
                    ImportAsQuote = grid.Rows[x].Cells[50].Value.ToString() ?? "",
                    QuoteNum = grid.Rows[x].Cells[51].Value.ToString() ?? "",
                    WebRefNum = grid.Rows[x].Cells[52].Value.ToString() ?? "",
                    CreateInvoice = grid.Rows[x].Cells[53].Value.ToString() ?? "",
                    StrategicPricingLibraryID = grid.Rows[x].Cells[54].Value.ToString() ?? "",
                    MerchandiseCredit = grid.Rows[x].Cells[55].Value.ToString() ?? "",
                    OrderTypePriority = grid.Rows[x].Cells[56].Value.ToString() ?? "",
                    UpsCode = grid.Rows[x].Cells[57].Value.ToString() ?? "",
                    SupplierOrderNum = grid.Rows[x].Cells[58].Value.ToString() ?? "",
                    SupplierReleaseNum = grid.Rows[x].Cells[59].Value.ToString() ?? "",
                    PlacedByName = grid.Rows[x].Cells[60].Value.ToString() ?? "",
                    OrderType830 = (long?)grid.Rows[x].Cells[61].Value ?? 0,
                    ShipToAddress3 = grid.Rows[x].Cells[62].Value.ToString() ?? ""
                });

            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }
        public static void SaveLineFile(int rowCount, DataGridView grid, string fname)
        {
            var engine = new FileHelperEngine<OrderLine>();
            var list = new List<OrderLine>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new OrderLine()
                {
                    ImportSetNo = grid.Rows[x].Cells[0].Value.ToString() ?? "",
                    LineNo = (int?)grid.Rows[x].Cells[1].Value,
                    ItemID = grid.Rows[x].Cells[2].Value.ToString() ?? "",
                    UnitQty = (decimal?)grid.Rows[x].Cells[3].Value,
                    UOM = grid.Rows[x].Cells[4].ToString() ?? "",
                    UnitPrice = (decimal?)grid.Rows[x].Cells[5].Value,
                    ExtDesc = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    SourceLocID = (int?)grid.Rows[x].Cells[7].Value,
                    ShipLocID = (int?)grid.Rows[x].Cells[8].Value,
                    ProdGroupID = grid.Rows[x].Cells[9].Value.ToString() ?? "",
                    SupplierID = (long?)grid.Rows[x].Cells[10].Value,
                    SupplierName = grid.Rows[x].Cells[11].Value.ToString() ?? "",
                    RequiredDate = (DateTime?)grid.Rows[x].Cells[12].Value,
                    ExpediteDate = (DateTime?)grid.Rows[x].Cells[13].Value,
                    WillCall = grid.Rows[x].Cells[14].Value.ToString() ?? "",
                    TaxItem = grid.Rows[x].Cells[15].Value.ToString() ?? "",
                    OKtoInterchange = grid.Rows[x].Cells[16].Value.ToString() ?? "",
                    PricingUnit = grid.Rows[x].Cells[17].Value.ToString() ?? "",
                    CommissionCost = (decimal?)grid.Rows[x].Cells[18].Value,
                    OtherCost = (decimal?)grid.Rows[x].Cells[19].Value,
                    POCost = (decimal?)grid.Rows[x].Cells[20].Value,
                    Disposition = grid.Rows[x].Cells[21].Value.ToString() ?? "",
                    Scheduled = grid.Rows[x].Cells[22].Value.ToString() ?? "",
                    ManualPriceOverride = grid.Rows[x].Cells[23].ToString() ?? "",
                    CommissionCostEdited = grid.Rows[x].Cells[24].Value.ToString() ?? "",
                    OtherCostEdited = grid.Rows[x].Cells[25].Value.ToString() ?? "",
                    CaptureUsage = grid.Rows[x].Cells[26].Value.ToString() ?? "",
                    TagAndHoldClassID = grid.Rows[x].Cells[27].Value.ToString() ?? "",
                    ContractBinID = grid.Rows[x].Cells[28].Value.ToString() ?? "",
                    ContractNo = grid.Rows[x].Cells[29].Value.ToString() ?? "",
                    AllocationQty = (int?)grid.Rows[x].Cells[30].Value,
                    PromiseDate = grid.Rows[x].Cells[31].Value.ToString() ?? "",
                    RevisionLevel = grid.Rows[x].Cells[32].Value.ToString() ?? "",
                    ResolveItemContract = grid.Rows[x].Cells[33].Value.ToString() ?? "",
                    Sample = grid.Rows[x].Cells[34].Value.ToString() ?? "",
                    QuoteLineNo = grid.Rows[x].Cells[35].Value.ToString() ?? "",
                    QuoteComplete = grid.Rows[x].Cells[36].Value.ToString() ?? "",

                });

            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }
        public static void SaveRemittanceFile(int rowCount, DataGridView grid, string fname)
        {
            var engine = new FileHelperEngine<Remittance>();
            var list = new List<Remittance>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new Remittance()
                {
                    ImportSetNo = (int?)grid.Rows[x].Cells[0].Value,
                    PaymentTypeID = (int?)grid.Rows[x].Cells[1].Value,
                    PaymentAmount = (int?)grid.Rows[x].Cells[2].Value,
                    PaymentDate = (DateTime?)grid.Rows[x].Cells[3].Value,
                    PaymentDesc = grid.Rows[x].Cells[4].Value.ToString() ?? "",
                    CheckNumber = (string?)grid.Rows[x].Cells[5].Value,
                    CCName = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    CCNumber = grid.Rows[x].Cells[7].Value.ToString() ?? "",
                    CustomerVerificationValue = grid.Rows[x].Cells[8].Value.ToString() ?? "",
                    CCExpirationDate = (DateTime?)grid.Rows[x].Cells[9].Value,
                    CCAuthorizedDate = (DateTime?)grid.Rows[x].Cells[10].Value,
                    CCAuthorizedNumber = (long?)grid.Rows[x].Cells[11].Value,
                    Period = (int?)grid.Rows[x].Cells[12].Value,
                    Year = (long?)grid.Rows[x].Cells[13].Value,
                    CreditNumber = (long?)grid.Rows[x].Cells[14].Value,
                    WebProcessingCenterID = (long?)grid.Rows[x].Cells[15].Value
                });

            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }
        public static void SaveCreditCardFile(int rowCount, DataGridView grid, string fname)
        {
            var engine = new FileHelperEngine<CreditCardHolderAddress>();
            var list = new List<CreditCardHolderAddress>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new CreditCardHolderAddress()
                {
                    ImportSetNo = (int?)grid.Rows[x].Cells[0].Value,
                    CardNumber = grid.Rows[x].Cells[1].Value.ToString() ?? "",
                    FirstName = grid.Rows[x].Cells[2].Value.ToString() ?? "",
                    LastName = grid.Rows[x].Cells[3].Value.ToString() ?? "",
                    StreetAddress1 = grid.Rows[x].Cells[4].Value.ToString() ?? "",
                    StreetAddress2 = grid.Rows[x].Cells[5].Value.ToString() ?? "",
                    City = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    State = grid.Rows[x].Cells[7].Value.ToString() ?? "",
                    ZipCode = grid.Rows[x].Cells[8].Value.ToString() ?? "",
                    SwitchIssueNumber = (long?)grid.Rows[x].Cells[9].Value,
                    ReferenceNumber = (long?)grid.Rows[x].Cells[10].Value,
                    TransactioNID = grid.Rows[x].Cells[11].Value.ToString() ?? "",
                    AVSResponseCode = grid.Rows[x].Cells[12].Value.ToString() ?? "",
                    CVVResponseCode = grid.Rows[x].Cells[13].Value.ToString() ?? "",
                });
            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }
        public static void SaveHeaderNotepadFile(int rowCount, DataGridView grid, string fname)
        {
            var engine = new FileHelperEngine<OrderHeaderNotepad>();
            var list = new List<OrderHeaderNotepad>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new OrderHeaderNotepad()
                {
                    ImportSetNo = grid.Rows[x].Cells[0].Value.ToString() ?? "",
                    Topic = grid.Rows[x].Cells[1].Value.ToString() ?? "",
                    Note = grid.Rows[x].Cells[2].Value.ToString() ?? "",
                    ActivationDate = grid.Rows[x].Cells[3].Value.ToString() ?? "",
                    ExpirationDate = grid.Rows[x].Cells[4].Value.ToString() ?? "",
                    EntryDate = grid.Rows[x].Cells[5].Value.ToString() ?? "",
                    NotepadClassID = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    Mandatory = grid.Rows[x].Cells[7].Value.ToString() ?? "",
                });
            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }
        public static void SaveLineNotepadFile(int rowCount, DataGridView grid, string fname)
        {
            var engine = new FileHelperEngine<OrderLineNotepad>();
            var list = new List<OrderLineNotepad>();

            for (int x = 0; x < rowCount; x++)
            {
                list.Add(new OrderLineNotepad()
                {
                    ImportSetNo = grid.Rows[x].Cells[0].Value.ToString() ?? "",
                    LineNo = (int?)grid.Rows[x].Cells[1].Value,
                    Topic = grid.Rows[x].Cells[2].Value.ToString() ?? "",
                    Note = grid.Rows[x].Cells[3].Value.ToString() ?? "",
                    ActivationDate = grid.Rows[x].Cells[4].Value.ToString() ?? "",
                    ExpirationDate = grid.Rows[x].Cells[5].Value.ToString() ?? "",
                    EntryDate = grid.Rows[x].Cells[6].Value.ToString() ?? "",
                    NotepadClassID = grid.Rows[x].Cells[7].Value.ToString() ?? "",
                    Mandatory = grid.Rows[x].Cells[8].Value.ToString() ?? "",
                });
            }
            engine.WriteFile(fname, list);
            MessageBox.Show(@$"File saved to {fname}");
        }

    }
}
