using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

namespace Baby_Tracker
{
    class ReportExports
    {
        public void createPDF(DataTable dataTable, string destinationPath)
{
    Document document = new Document();
    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));
    document.Open();

    PdfPTable table = new PdfPTable(dataTable.Columns.Count);
    table.WidthPercentage = 100;

    //Set columns names in the pdf file
    for(int k = 0; k < dataTable.Columns.Count; k++)
    {
        PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
        cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

        table.AddCell(cell);
    }

    //Add values of DataTable in pdf file
    for(int i = 0; i < dataTable.Rows.Count; i++)
    {
        for(int j = 0; j < dataTable.Columns.Count; j++)
        {
            PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));

            //Align the cell in the center
            cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
            cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

            table.AddCell(cell);
        }
    }

    document.Add(table);
    document.Close();
}
    }
}
