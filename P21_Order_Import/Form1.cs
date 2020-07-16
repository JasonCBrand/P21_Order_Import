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
        public int lineCount;
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
           
            //Attach the DataError events to the corresponding event handlers
            this.OEHdrGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            this.LineGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            this.RemitGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            this.CreditCardGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            this.HdrNoteGridView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);
            this.LineGridNoteView.DataError += new DataGridViewDataErrorEventHandler(DataGridView_DataError);

            this.OEHdrGridView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
            this.LineGridView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
            this.RemitGridView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
            this.CreditCardGridView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
            this.HdrNoteGridView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
            this.LineGridNoteView.CellLeave += new DataGridViewCellEventHandler(generic_CellLeave);
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
                fname = openFileDialog1.FileName; //"F:\\Jason\\Documents\\TestLoadFile.txt";
               
                if (fname.Contains("OrderHeader") && !fname.Contains("Notepad"))
                {
                    OHengine = new FileHelperEngine<OrderHeader>();
                    result = OHengine.ReadFile(fname);
                    OEHdrGridView.DataSource = result;
                    tabControl1.SelectTab("OEHdrTab");
                    orderCount = result.Length;
                    P21_Order_Import.HighlightMissingCells(OEHdrGridView, orderCount);
                }
                else if (fname.Contains("OrderLine") && !fname.Contains("Notepad"))
                {
                    OLengine = new FileHelperEngine<OrderLine>();
                    result = OLengine.ReadFile(fname);
                    LineGridView.DataSource = result;
                    lineCount = result.Length;
                    P21_Order_Import.HighlightMissingCells(LineGridView, lineCount);
                }
                else if (fname.Contains("Remit"))
                {
                    REMengine = new FileHelperEngine<Remittance>();
                    result = REMengine.ReadFile(fname);
                    tabControl1.SelectTab("RemittanceTab");
                    RemitGridView.DataSource = result;
                    orderCount = result.Length;
                    P21_Order_Import.HighlightMissingCells(RemitGridView, orderCount);
                }
                else if (fname.Contains("CreditCard"))
                {
                    CCengine = new FileHelperEngine<CreditCardHolderAddress>();
                    result = CCengine.ReadFile(fname);
                    tabControl1.SelectTab("CreditCardTab");
                    orderCount = result.Length;
                    CreditCardGridView.DataSource = result;
                    P21_Order_Import.HighlightMissingCells(CreditCardGridView, orderCount);
                }
                else if (fname.Contains("OrderHeaderNotepad"))
                {
                    OHNengine = new FileHelperEngine<OrderHeaderNotepad>();
                    result = OHNengine.ReadFile(fname);
                    tabControl1.SelectTab("OEHdrNoteTab");
                    HdrNoteGridView.DataSource = result;
                    orderCount = result.Length;
                    P21_Order_Import.HighlightMissingCells(HdrNoteGridView, orderCount);
                }
                else if (fname.Contains("OrderLineNotepad"))
                {
                     OLNengine = new FileHelperEngine<OrderLineNotepad>();
                     result = OLNengine.ReadFile(fname);
                    tabControl1.SelectTab("OELineNoteTab");
                    LineGridNoteView.DataSource = result;
                    orderCount = result.Length;
                    P21_Order_Import.HighlightMissingCells(LineGridNoteView, orderCount);
                }
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
            try
            {
                switch (tabControl1.SelectedTab.Name)
                {
                    case "OEHdrTab":
                        SaveHelpers.SaveHeaderFile(orderCount, OEHdrGridView, fname);
                        break;
                    case "RemittanceTab":
                        SaveHelpers.SaveRemittanceFile(orderCount, RemitGridView, fname);
                        break;
                    case "CreditCardTab":
                        SaveHelpers.SaveCreditCardFile(orderCount, CreditCardGridView, fname);
                        break;
                    case "OEHdrNoteTab":
                        SaveHelpers.SaveHeaderNotepadFile(orderCount, HdrNoteGridView, fname);
                        break;
                    case "OELineNoteTab":
                        SaveHelpers.SaveLineNotepadFile(orderCount, LineGridNoteView, fname);
                        break;
                    default:
                        break;
                }
                //always save line since it isnt on a tab unless we add 2nd button
                SaveHelpers.SaveLineNotepadFile(lineCount, LineGridNoteView, fname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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
            P21_Order_Import.HighlightMissingCells(LineGridView, lineCount);
        }
        //error event handlers
        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            //MessageBox.Show("Error at row: " + anError.RowIndex + " column: " + anError.ColumnIndex);
            //MessageBox.Show("Error happened " + anError.Context.ToString());
            DataGridView view = (DataGridView)sender;
            string s = view.Columns[anError.ColumnIndex].HeaderText;
            if (anError.Context.ToString().Contains(DataGridViewDataErrorContexts.Commit.ToString()))
            {
                MessageBox.Show(@$"Commit error at Column: " + s + " Row: " + anError.RowIndex + "\nplease fix before continuing");
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
               
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }
        }
        //cell leave event handler
        private void generic_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = (DataGridView)sender;
            bool isNull = view[e.ColumnIndex, e.RowIndex].Value == null;
            if (isNull || view[e.ColumnIndex, e.RowIndex].Value.ToString() == "")
            {
                view[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Empty;
            }
        }
    }
}

