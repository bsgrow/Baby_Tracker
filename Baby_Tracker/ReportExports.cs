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
        private void GeneratePDF(DataTable dataTable, string Name)  
      {  
          try  
          {  
              string[] columnNames = (from dc in dataTable.Columns.Cast<DataColumn>() select dc.ColumnName).ToArray();  
              int Cell = 0;  
              int count = columnNames.Length;  
              object[] array = new object[count];  
  
              dataTable.Rows.Add(array);  
  
              Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);  
              System.IO.MemoryStream mStream = new System.IO.MemoryStream();  
              PdfWriter writer = PdfWriter.GetInstance(pdfDoc, mStream);  
              int cols = dataTable.Columns.Count;  
              int rows = dataTable.Rows.Count;  
               
  
              HeaderFooter header = new HeaderFooter(new Phrase(Name), false);  
  
              // Remove the border that is set by default  
              header.Border = iTextSharp.text.Rectangle.TITLE;  
              // Align the text: 0 is left, 1 center and 2 right.  
              header.Alignment = Element.ALIGN_CENTER;  
              pdfDoc.Header = header;  
              // Header.  
              pdfDoc.Open();  
              iTextSharp.text.Table pdfTable = new iTextSharp.text.Table(cols, rows);  
              pdfTable.BorderWidth = 1; pdfTable.Width = 100;  
              pdfTable.Padding = 1; pdfTable.Spacing = 4;  
  
              //creating table headers  
              for (int i = 0; i < cols; i++)  
              {  
                  Cell cellCols = new Cell();  
                  Chunk chunkCols = new Chunk();  
                  cellCols.BackgroundColor = new iTextSharp.text.Color(System.Drawing.ColorTranslator.FromHtml("#548B54"));  
                  iTextSharp.text.Font ColFont = FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD, iTextSharp.text.Color.WHITE);  
                   
                  chunkCols = new Chunk(dataTable.Columns[i].ColumnName, ColFont);  
                 
                  cellCols.Add(chunkCols);  
                  pdfTable.AddCell(cellCols);  
              }  
              
              //creating table data (actual result)   
              for (int k = 0; k < rows; k++)  
              {  
                  for (int j = 0; j < cols; j++)  
                  {  
                      Cell cellRows = new Cell();  
                      if (k % 2 == 0)  
                      {  
                          cellRows.BackgroundColor = new iTextSharp.text.Color(System.Drawing.ColorTranslator.FromHtml("#cccccc")); ;  
                      }  
                      else { cellRows.BackgroundColor = new iTextSharp.text.Color(System.Drawing.ColorTranslator.FromHtml("#ffffff")); }  
                      iTextSharp.text.Font RowFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);  
                      Chunk chunkRows = new Chunk(dataTable.Rows[k][j].ToString(), RowFont);  
                      cellRows.Add(chunkRows);  
  
                      pdfTable.AddCell(cellRows);  
                  }  
              }  
  
              pdfDoc.Add(pdfTable);  
              pdfDoc.Close();  
              Response.ContentType = "application/octet-stream";  
              Response.AddHeader("Content-Disposition", "attachment; filename=" + Name + "_" + DateTime.Now.ToString() + ".pdf");  
              Response.Clear();  
              Response.BinaryWrite(mStream.ToArray());  
              Response.End();  
  
          }  
          catch (Exception ex)  
          {  
               
          }  
      } 
    }
}
