using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace IIHT
{
    public partial class frmReport : IIHT.BaseForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        DataTable dt;
        DataSet ds;
        private void btnOk_Click(object sender, EventArgs e)
        {
            Excel.Application oXL = new Excel.Application();
            Excel.Workbook theWorkbook;
            Excel.Worksheet worksheet;

            string strSql;

            if (File.Exists(Application.StartupPath + @"\Commonreport.xls"))
            {
                File.Delete(Application.StartupPath + @"\Commonreport.xls");
            }

            theWorkbook = oXL.Workbooks.Open(Application.StartupPath + @"\Commonreport.xlt", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, Type.Missing, Type.Missing);

            worksheet = (Excel.Worksheet)theWorkbook.Sheets[1];

            strSql = @"select convert(date,v.visitDate) as visitDate ,v.name,v.address,v.city,v.contact,v.email,v.whatsapp,v.referencedBy, 
                    v.education,v.gender,e.empName,c.courseName
                    from Visitor v inner join EmpMaster e on e.empId=v.empId
                    inner join course c on c.courseId=v.courseId Where 1=1";

            if (txtFDate.Text != "")
            {
                strSql = strSql + " And visitDate>='" +  txtFDate.Text +"'";
            }
            if (txtTDate.Text != "")
            {
                strSql = strSql + " And visitDate<='" + txtTDate.Text + "'";
            }


            dt=DatabaseHelper.GetQueryResultTable(strSql);
            ds = new DataSet();
            ds.Tables.Add(dt);
            
            ds.Tables[0].TableName = "visitor";

            Excel.Range RngCompName = worksheet.get_Range("CompName", "CompName"); 
            Excel.Range RngColumnHeader = worksheet.get_Range("ColumnHeader", "ColumnHeader");
            Excel.Range RngColumnValue = worksheet.get_Range("ColumnValue", "ColumnValue");

            

            RngCompName.Value2 = "Datewise Visitor List";

            RngColumnValue.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

            ///Column Header
            for (int Intcol = 0; Intcol <= ds.Tables["visitor"].Columns.Count-1;Intcol++)
            {
                RngColumnHeader.set_Item(1, Intcol+1, ds.Tables["visitor"].Columns[Intcol].ColumnName);

                
                switch (ds.Tables["visitor"].Columns[Intcol].ColumnName.ToUpper())
                {
                    case "VISITDATE":

                        Excel.Range RngColVal = worksheet.get_Range("A4", RngColumnValue);
                        
                        RngColVal.EntireColumn.NumberFormat = "dd/mm/yyyy";
                        break;
                }
            }


            ////Column Value
            string StrVisitDate="";
            for (int IntRow = 0;IntRow<=ds.Tables["visitor"].Rows.Count - 1; IntRow++)
            {

                if(StrVisitDate!=ds.Tables["visitor"].Rows[IntRow]["visitDate"].ToString())
                {
                    StrVisitDate = ds.Tables["visitor"].Rows[IntRow]["visitDate"].ToString();
                    RngColumnValue.set_Item(IntRow + 1, 1, StrVisitDate);
                }
                                

                for (int Intcol = 0; Intcol <= ds.Tables["visitor"].Columns.Count - 1; Intcol++)
                {
                    if (ds.Tables["visitor"].Columns[Intcol].ColumnName.ToString().ToUpper()!="VISITDATE")
                    {
                        RngColumnValue.set_Item(IntRow + 1, Intcol + 1, ds.Tables["visitor"].Rows[IntRow][Intcol].ToString());
                    }
                }
            }


            oXL.ActiveWorkbook.SaveAs(Application.StartupPath + @"\Commonreport", Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);


            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(worksheet);
            oXL.Workbooks.Close();
            Marshal.FinalReleaseComObject(theWorkbook);
            oXL.Application.Quit();
            Marshal.FinalReleaseComObject(oXL);
            oXL = null;

            Excel.Application xlApp = new Excel.Application();  // create new Excel application
            xlApp.Visible = true;                               // application becomes visible
            xlApp.Workbooks.Open(Application.StartupPath + @"\Commonreport.xls", 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, Type.Missing, Type.Missing);

            MessageBox.Show("Press Enter To Continue.......", "", MessageBoxButtons.OK);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            xlApp.Workbooks.Close();
            xlApp.Application.Quit();
            Marshal.FinalReleaseComObject(xlApp);
            xlApp = null;
        }

        
                
    }
} 
