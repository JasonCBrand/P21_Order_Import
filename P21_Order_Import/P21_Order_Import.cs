using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P21_Order_Import
{
    public class P21_Order_Import
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ImportForm());
        }
       public static void HighlightMissingCells(DataGridView grid, int rowCount)
        {
            
            //button to run this that highlights the cells without a value
            for(int x = 0; x < rowCount; x++)
            {
                 for (int i = 0; i < grid.Rows[x].Cells.Count; i++)
                 {
                    bool isNull = grid.Rows[x].Cells[i].Value == null;
                    if (isNull || grid.Rows[x].Cells[i].Value.ToString() == "")
                    {
                        //var val = row.Cells[i].Value.ToString();
                        grid.Rows[x].Cells[i].Style.BackColor = Color.Red;
                    }
                 }
             
            }
            
        }
    }

 }

