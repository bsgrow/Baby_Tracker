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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Baby_Tracker
{
    class ReportExports
    {

        /*
         * Creates the PDF file of the selected baby from the main application. Here the 
         * PDF is then saved to the users download file.
         */
        public void createPDF(DataTable weightDataTable, DataTable measurementsDataTable, DataTable immunizationsDataTable, DataTable medicationsDataTable, string destinationPath)
        {
            //gets user Download location in system
            //string destinationPath = @"\\Mac\Home\Desktop\test.pdf";

            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));
            document.Open();

            var titleFont = FontFactory.GetFont("Helvetica", 18, BaseColor.BLACK);

            PdfPTable weightTable = new PdfPTable(weightDataTable.Columns.Count);
            PdfPTable measurementsTable = new PdfPTable(measurementsDataTable.Columns.Count);
            PdfPTable immunizationsTable = new PdfPTable(immunizationsDataTable.Columns.Count);
            PdfPTable medicationsTable = new PdfPTable(medicationsDataTable.Columns.Count);
            Paragraph title = new Paragraph(new Chunk("Baby Tracker Report", titleFont));
            weightTable.WidthPercentage = 100;
            measurementsTable.WidthPercentage = 100;
            immunizationsTable.WidthPercentage = 100;
            medicationsTable.WidthPercentage = 100;
            title.Alignment = Element.ALIGN_CENTER;

            //Used to create weight table
            //Columns
            for (int k = 0; k < weightDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(weightDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(220, 220, 220);

                weightTable.AddCell(cell);
            }

            //Values
            for (int i = 0; i < weightDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < weightDataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(weightDataTable.Rows[i][j].ToString()));

                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    weightTable.AddCell(cell);
                }
            }


            //Used to create Measurements Table
            //Columns
            for (int k = 0; k < measurementsDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(measurementsDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(220, 220, 220);

                measurementsTable.AddCell(cell);
            }

            //Values
            for (int i = 0; i < measurementsDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < measurementsDataTable.Columns.Count; j++)
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
            for (int k = 0; k < immunizationsDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(immunizationsDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(220, 220, 220);

                immunizationsTable.AddCell(cell);
            }

            //Values
            for (int i = 0; i < immunizationsDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < immunizationsDataTable.Columns.Count; j++)
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
            for (int k = 0; k < medicationsDataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(medicationsDataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(220, 220, 220);

                medicationsTable.AddCell(cell);
            }

            //Values
            for (int i = 0; i < medicationsDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < medicationsDataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(medicationsDataTable.Rows[i][j].ToString()));

                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    medicationsTable.AddCell(cell);
                }
            }


            document.Add(title);
            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Weight"));
            document.Add(new Paragraph("\n"));
            document.Add(weightTable);

            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Measurements"));
            document.Add(new Paragraph("\n"));
            document.Add(measurementsTable);

            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Immunizations"));
            document.Add(new Paragraph("\n"));
            document.Add(immunizationsTable);

            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Medications"));
            document.Add(new Paragraph("\n"));
            document.Add(medicationsTable);

            document.Close();
        }
    }
}
