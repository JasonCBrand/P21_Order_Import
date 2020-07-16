using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileHelpers;

namespace P21_Order_Import
{
    public partial class ImportForm : Form
    {
        public string fname;
        public int fileEnd;
        //public OrderHeader[] orderArr = new OrderHeader[63];
        public int orderCount;
        public OpenFileDialog openFileDialog1;
        public string fileType;

        public Array result;
        private FileHelperEngine<OrderHeader> OHengine;
        private FileHelperEngine<OrderLine> OLengine;
        private FileHelperEngine<Remittance> REMengine;
        private FileHelperEngine<CreditCardHolderAddress> CCengine;
        private FileHelperEngine<OrderHeaderNotepad> OHNengine;
        private FileHelperEngine<OrderLineNotepad> OLNengine;

        public ImportForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(Object sender, EventArgs e)
        {
           
            // Attach the DataError event to the corresponding event handler
            this.OEHdrGridView.DataError += new DataGridViewDataErrorEventHandler(OEHdrGridView_DataError);

        }
        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                openFileDialog1 = new OpenFileDialog { Title = "Browse Files"  };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                }
                fname = openFileDialog1.FileName;//"F:\\Jason\\Documents\\TestLoadFile.txt";
               
                if (fname.Contains("OrderHeader") && !fname.Contains("Notepad"))
                {
                    OHengine = new FileHelperEngine<OrderHeader>();
                    result = OHengine.ReadFile(fname);
                    OEHdrGridView.DataSource = result;
                    tabControl1.SelectTab("OEHdrTab");
                }
                else if (fname.Contains("OrderLine") && !fname.Contains("Notepad"))
                {
                    OLengine = new FileHelperEngine<OrderLine>();
                    result = OLengine.ReadFile(fname);
                    LineGridView.DataSource = result;
                }
                else if (fname.Contains("Remmittance"))
                {
                    REMengine = new FileHelperEngine<Remittance>();
                    result = REMengine.ReadFile(fname);
                    tabControl1.SelectTab("RemittanceTab");
                    RemitGridView.DataSource = result;
                }
                else if (fname.Contains("CreditCard"))
                {
                    CCengine = new FileHelperEngine<CreditCardHolderAddress>();
                    result = CCengine.ReadFile(fname);
                    tabControl1.SelectTab("CreditCardTab");
                    CreditCardGridView.DataSource = result;
                }
                else if (fname.Contains("OrderHeaderNotepad"))
                {
                    OHNengine = new FileHelperEngine<OrderHeaderNotepad>();
                    result = OHNengine.ReadFile(fname);
                    tabControl1.SelectTab("OEHdrNoteTab");
                    HdrNoteGridView.DataSource = result;
                }
                else if (fname.Contains("OrderLineNotepad"))
                {
                     OLNengine = new FileHelperEngine<OrderLineNotepad>();
                     result = OLNengine.ReadFile(fname);
                    tabControl1.SelectTab("OELineNoteTab");
                    LineGridNoteView.DataSource = result;
                }
                orderCount = result.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveHelpers.SaveHeaderFile(orderCount, OEHdrGridView, fname);
            //SaveHelpers.SaveLineFile(orderCount, LineGridView, fname);
            //SaveHelpers.SaveRemittanceFile(orderCount, RemitGridView, fname);
            //SaveHelpers.SaveCreditCardFile(orderCount, CreditCardGridView, fname);
            //SaveHelpers.SaveHeaderNotepadFile(orderCount, HdrNoteGridView, fname);
            //SaveHelpers.SaveLineNotepadFile(orderCount, LineGridNoteView, fname);

            //var engine = new FileHelperEngine<OrderHeader>();
            //var orders = new List<OrderHeader>();

            //for (int x = 0; x < orderCount; x++)
            //{
            //    orders.Add(new OrderHeader()
            //    {
            //        ImportSetNo = OEHdrGridView.Rows[x].Cells[0].Value.ToString() ?? "",
            //        CustID = (decimal?)OEHdrGridView.Rows[x].Cells[1].Value,
            //        CustName = OEHdrGridView.Rows[x].Cells[2].Value.ToString() ?? "",
            //        CompanyID = OEHdrGridView.Rows[x].Cells[3].Value.ToString() ?? "",
            //        SalesLocID = (decimal?)OEHdrGridView.Rows[x].Cells[4].Value,
            //        CustPONum = OEHdrGridView.Rows[x].Cells[5].Value.ToString() ?? "",
            //        ContactID = OEHdrGridView.Rows[x].Cells[6].Value.ToString() ?? "",
            //        ContactName = OEHdrGridView.Rows[x].Cells[7].Value.ToString() ?? "",
            //        Taker = OEHdrGridView.Rows[x].Cells[8].Value.ToString() ?? "",
            //        JobName = OEHdrGridView.Rows[x].Cells[9].Value.ToString() ?? "",
            //        OrderDate = (DateTime?)OEHdrGridView.Rows[x].Cells[10].Value,
            //        ReqDate = (DateTime?)OEHdrGridView.Rows[x].Cells[11].Value,
            //        Quote = OEHdrGridView.Rows[x].Cells[12].Value.ToString() ?? "",
            //        Approved = OEHdrGridView.Rows[x].Cells[13].Value.ToString() ?? "",
            //        ShipToID = (int?)OEHdrGridView.Rows[x].Cells[14].Value ?? 0,
            //        ShipToName = OEHdrGridView.Rows[x].Cells[15].Value.ToString() ?? "",
            //        ShipToAddress1 = OEHdrGridView.Rows[x].Cells[16].Value.ToString() ?? "",
            //        ShipToAddress2 = OEHdrGridView.Rows[x].Cells[17].Value.ToString() ?? "",
            //        ShipToCity = OEHdrGridView.Rows[x].Cells[18].Value.ToString() ?? "",
            //        ShipToState = OEHdrGridView.Rows[x].Cells[19].Value.ToString() ?? "",
            //        ShipToZip = OEHdrGridView.Rows[x].Cells[20].Value.ToString() ?? "",
            //        ShipToCountry = OEHdrGridView.Rows[x].Cells[21].Value.ToString() ?? "",
            //        SourceLocID = (int?)OEHdrGridView.Rows[x].Cells[22].Value ?? 0,
            //        CarrierID = (int?)OEHdrGridView.Rows[x].Cells[23].Value ?? 0,
            //        CarrierName = OEHdrGridView.Rows[x].Cells[24].Value.ToString() ?? "",
            //        Route = OEHdrGridView.Rows[x].Cells[25].Value.ToString() ?? "",
            //        PackingBasis = OEHdrGridView.Rows[x].Cells[26].Value.ToString() ?? "",
            //        DeliveryInstructions = OEHdrGridView.Rows[x].Cells[27].Value.ToString() ?? "",
            //        Terms = OEHdrGridView.Rows[x].Cells[28].Value.ToString() ?? "",
            //        TermsDesc = OEHdrGridView.Rows[x].Cells[29].Value.ToString() ?? "",
            //        WillCall = OEHdrGridView.Rows[x].Cells[30].Value.ToString() ?? "",
            //        Class1 = OEHdrGridView.Rows[x].Cells[31].Value.ToString() ?? "",
            //        Class2 = OEHdrGridView.Rows[x].Cells[32].Value.ToString() ?? "",
            //        Class3 = OEHdrGridView.Rows[x].Cells[33].Value.ToString() ?? "",
            //        Class4 = OEHdrGridView.Rows[x].Cells[34].Value.ToString() ?? "",
            //        Class5 = OEHdrGridView.Rows[x].Cells[35].Value.ToString() ?? "",
            //        RmaFlag = OEHdrGridView.Rows[x].Cells[36].Value.ToString() ?? "",
            //        Freightcode = OEHdrGridView.Rows[x].Cells[37].Value.ToString() ?? "",
            //        ThirdPartyBillingFlagDesc = OEHdrGridView.Rows[x].Cells[38].Value.ToString() ?? "",
            //        CaptureusageDefault = OEHdrGridView.Rows[x].Cells[39].Value.ToString() ?? "",
            //        Allocate = OEHdrGridView.Rows[x].Cells[40].Value.ToString() ?? "",
            //        ContractNum = OEHdrGridView.Rows[x].Cells[41].Value.ToString() ?? "",
            //        InvoiceBatchNum = (long?)OEHdrGridView.Rows[x].Cells[42].Value ?? 0,
            //        ShipToEmail = OEHdrGridView.Rows[x].Cells[43].Value.ToString() ?? "",
            //        SetInvoiceExchangerateSourceDesc = OEHdrGridView.Rows[x].Cells[44].Value.ToString() ?? "",
            //        ShipToPhone = OEHdrGridView.Rows[x].Cells[45].Value.ToString() ?? "",
            //        CurrencyID = (long?)OEHdrGridView.Rows[x].Cells[46].Value,
            //        ApplyBuilderAllowanceFlag = OEHdrGridView.Rows[x].Cells[47].Value.ToString() ?? "",
            //        QuoteExpirationDate = (DateTime?)OEHdrGridView.Rows[x].Cells[48].Value,
            //        PromiseDate = (DateTime?)OEHdrGridView.Rows[x].Cells[49].Value,
            //        ImportAsQuote = OEHdrGridView.Rows[x].Cells[50].Value.ToString() ?? "",
            //        QuoteNum = OEHdrGridView.Rows[x].Cells[51].Value.ToString() ?? "",
            //        WebRefNum = OEHdrGridView.Rows[x].Cells[52].Value.ToString() ?? "",
            //        CreateInvoice = OEHdrGridView.Rows[x].Cells[53].Value.ToString() ?? "",
            //        StrategicPricingLibraryID = OEHdrGridView.Rows[x].Cells[54].Value.ToString() ?? "",
            //        MerchandiseCredit = OEHdrGridView.Rows[x].Cells[55].Value.ToString() ?? "",
            //        OrderTypePriority = OEHdrGridView.Rows[x].Cells[56].Value.ToString() ?? "",
            //        UpsCode = OEHdrGridView.Rows[x].Cells[57].Value.ToString() ?? "",
            //        SupplierOrderNum = OEHdrGridView.Rows[x].Cells[58].Value.ToString() ?? "",
            //        SupplierReleaseNum = OEHdrGridView.Rows[x].Cells[59].Value.ToString() ?? "",
            //        PlacedByName = OEHdrGridView.Rows[x].Cells[60].Value.ToString() ?? "",
            //        OrderType830 = (long?)OEHdrGridView.Rows[x].Cells[61].Value ?? 0,
            //        ShipToAddress3 = OEHdrGridView.Rows[x].Cells[62].Value.ToString() ?? ""
            //    });

            //}
            //engine.WriteFile("F:\\Jason\\Documents\\Output.Txt", orders);
        }
        private void OEHdrGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error at row: " + anError.RowIndex + " column: " + anError.ColumnIndex);
            //MessageBox.Show("Error happened " + anError.Context.ToString());
            string s = OEHdrGridView.Columns[anError.ColumnIndex].HeaderText;
            if (anError.Context.ToString().Contains(DataGridViewDataErrorContexts.Commit.ToString()))
            {
                MessageBox.Show(@$"Commit error at Column: " + s + " Row: " + anError.RowIndex +  "\nplease fix before continuing");
                return;
            }
            if (anError.Context.ToString().Contains(DataGridViewDataErrorContexts.CurrentCellChange.ToString()))
            {
                MessageBox.Show(@$"Cell change error at Column: " + s + " Row: " + anError.RowIndex + "\nplease fix before continuing");
                return;
            }
            if (anError.Context.ToString().Contains(DataGridViewDataErrorContexts.Parsing.ToString()))
            {
                MessageBox.Show(@$"Parsing error at Column: " + s + " Row: " + anError.RowIndex + "\nplease fix before continuing");
                return;
            }
            if (anError.Context.ToString().Contains(DataGridViewDataErrorContexts.LeaveControl.ToString()))
            {
                MessageBox.Show(@$"Leave control error at Column: " + s + " Row: " + anError.RowIndex + "\nplease fix before continuing");
                return;
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;

            }
        }

        private void MissingButton_Click(object sender, EventArgs e)
        {
            //just run this based on active grid view
            switch(tabControl1.SelectedTab.Name)
            {
                case "OEHdrTab":
                    P21_Order_Import.HighlightMissingCells(OEHdrGridView, orderCount);
                    break;
                case "RemittanceTab":
                    P21_Order_Import.HighlightMissingCells(RemitGridView, orderCount);
                    break;
                case "CreditCardTab":
                    P21_Order_Import.HighlightMissingCells(CreditCardGridView, orderCount);
                    break;
                case "OEHdrNoteTab":
                    P21_Order_Import.HighlightMissingCells(HdrNoteGridView, orderCount);
                    break;
                case "OELineNoteTab":
                    P21_Order_Import.HighlightMissingCells(LineGridNoteView, orderCount);
                    break;
                default:
                    break;
            }
            //need to add a 2nd variable for the lineccount OR add a 2nd button
            //P21_Order_Import.HighlightMissingCells(LineGridView, orderCount);
        }


    }
}

