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
import com.itextpdf.text.Chunk;
import com.itextpdf.text.Document;
import com.itextpdf.text.DocumentException;
import com.itextpdf.text.Element;
import com.itextpdf.text.Font;
import com.itextpdf.text.Image;
import com.itextpdf.text.Paragraph;
import com.itextpdf.text.Phrase;
import com.itextpdf.text.Rectangle;
import com.itextpdf.text.pdf.PdfContentByte;
import com.itextpdf.text.pdf.PdfPCell;
import com.itextpdf.text.pdf.PdfPTable;
import com.itextpdf.text.pdf.PdfWriter;
namespace Baby_Tracker
{
    class ReportExports
    {
        // ,DataTable measurementsDataTable, DataTable immunizationsTable, DataTable medicatonsTable
        public void createPDF(DataTable weightDataTable)
        {
            //gets user Download location in system
            string userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");
            string destinationPath = Path.Combine(userRoot, "Downloads");
            
            
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));
            document.Open();

            
            PdfPTable weightTable = new PdfPTable(weightDataTable.Columns.Count);
            //PdfPTable measurementsTable = new PdfPTable(measurementsDataTable.Columns.Count);
            //PdfPTable immunizationsTable = new PdfPTable(immunizationsDataTable.Columns.Count);
            //PdfPTable medicatonsTable = new PdfPTable(medicationsDataTable.Columns.Count);
            weightTable.WidthPercentage = 100;

            
            //Used to create weight table
            //Columns
            for(int k = 0; k < weightDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(weightDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                weightTable.AddCell(cell);
            }

            //Values
            for(int i = 0; i < weightDataTable.Rows.Count; i++)
            {
                for(int j = 0; j < weightDataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(weightDataTable.Rows[i][j].ToString()));

                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    weightTable.AddCell(cell);
                }
            }
            /*
            //Used to create Measurements Table
            //Columns
            for(int k = 0; k < measurementsDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(measurementsDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                measurementsTable.AddCell(cell);
            }

            //Values
            for(int i = 0; i < measurementsDataTable.Rows.Count; i++)
            {
                for(int j = 0; j < measurementsDataTable.Columns.Count; j++)
                {
                     PdfPCell cell = new PdfPCell(new Phrase(measurementsDataTable.Rows[i][j].ToString()));

                     //Align the cell in the center
                     cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                     cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                     measurementsTable.AddCell(cell);
                 }
             }
            
            
              //Used to create Immunization Table
            //Columns
            for(int k = 0; k < immunizationsDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(immunizationsDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                immunizationsTable.AddCell(cell);
            }

            //Values
            for(int i = 0; i < immunizationsDataTable.Rows.Count; i++)
            {
                for(int j = 0; j < immunizationsDataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(immunizationsDataTable.Rows[i][j].ToString()));

                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    immunizationsTable.AddCell(cell);
                }
            }
            
            

            //Used to create Medication Table
            //Columns
            for(int k = 0; k < medicatonsTable .Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(medicatonsTable .Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);

                medicatonsTable.AddCell(cell);
            }

            //Values
            for(int i = 0; i < medicatonsTable .Rows.Count; i++)
            {
                for(int j = 0; j < medicatonsTable .Columns.Count; j++)
                {
                        PdfPCell cell = new PdfPCell(new Phrase(medicatonsTable .Rows[i][j].ToString()));

                        //Align the cell in the center
                        cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                        cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                        medicatonsTable.AddCell(cell);
                 }
             } 
            
            */

            document.Add(weightTable);
            document.add(Chunk.NEWLINE);
            //document.Add(measurementsTable);
            //document.add( Chunk.NEWLINE );
            //document.Add(immunizationsTable);
            //document.add( Chunk.NEWLINE );
            //document.Add(medicatonsTable);
            document.Close();
            
            //document.add(new Paragraph("\n\n"));
}
    }
}
