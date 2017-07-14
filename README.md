Final To-Do-List for BabyList Entry/Edit/Delete
    1. Allows for User Image file to be removed when a baby is removed and removed when edited. 
    2. Export feature for just BabyList
          -Two types of export (Excel and PDF)
          -From export File Menu:
                BabyList Export ->PDF Version
                                ->Excel Version
          -Can select either one baby to export or all baby to export
          -Should display all the information found in the BabyList table 
    3. Refactor completed BabyList Section.



Used for Excel Export

    private void excelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Connection();
        sqlconnection.Open();

        using (sqlcmd = new SqlCommand("SELECT * FROM inventory_table WHERE category= 0"))
        {
            using (SqlDataAdapter sqlda = new SqlDataAdapter())
            {
                sqlcmd.Connection = sqlconnection;
                sqlda.SelectCommand = sqlcmd;

                using (DataTable dt = new DataTable())
                {
                    sqlda.Fill(dt);

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        string fname = "Inventory Report.xlsx";
                        wb.Worksheets.Add(dt, "inventory_table");
                        wb.SaveAs(fname);

                    }
                }
            }
        }
    }

