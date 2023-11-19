using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MigrationsOnWebForms
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Table1.CellPadding = 10;
            for (int rowNum = 1; rowNum < 10; rowNum++)
            {
                TableRow tempRow = new TableRow();
                
                TableCell tempCell = new TableCell();
                tempCell.Text = rowNum.ToString();
                tempRow.Cells.Add(tempCell);

                tempCell = new TableCell();
                tempCell.Text = "Bob " + rowNum.ToString();
                tempRow.Cells.Add(tempCell);

                tempCell = new TableCell();
                tempCell.Text = "Smith " + rowNum.ToString();
                tempRow.Cells.Add(tempCell);
                Table1.Rows.Add(tempRow);
            }
        }
    }
}