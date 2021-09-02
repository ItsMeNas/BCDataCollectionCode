using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EvaluationofNCinBC.DAL;
using EvaluationofNCinBC.Model;
using Microsoft.Office;
using Microsoft.Office.Interop.Excel;
using System.Collections;
using Microsoft.Office.Interop;

namespace EvaluationofNCinBC
{
    public partial class frmFullList : Form
    {
        public frmFullList()
        {
            InitializeComponent();
        }

        private void frmFullList_Load(object sender, EventArgs e)
        {
            DAL_BCPatient dal_Patient = new DAL_BCPatient();

            this.dataGridView1.DataSource = null;

            this.dataGridView1.DataSource = dal_Patient.FillGridView().Tables[0];

            this.dataGridView1.Sort(this.dataGridView1.Columns["ID"], ListSortDirection.Ascending);

            this.dataGridView1.Columns["RecordStatus"].Visible = false;

            this.dataGridView1.Columns["ID"].Visible = true;

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
                c.Selected = false;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dataGridView1.Columns[0].Selected = true;

            GridViewColouring();
        }



        private void GridViewColouring()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["RecordStatus"].Value.ToString() == "" ||
                        row.Cells["RecordStatus"].Value.ToString() == string.Empty ||
                        row.Cells["RecordStatus"].Value.ToString() == "0")
                    {
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Pink;
                    }

                    if (row.Cells["RecordStatus"].Value.ToString() == "1")
                    {
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightSkyBlue;

                        if (dataGridView1.Rows[row.Index].Cells["Age"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["Age"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["Status"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["Status"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["DateofDiagnosis"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["DateofDiagnosis"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["NodalStatus"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["NodalStatus"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["Grade"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["Grade"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["Ki67"].Value.ToString() == "" ||
                            dataGridView1.Rows[row.Index].Cells["Ki67"].Value.ToString().Trim() == "%")
                            dataGridView1.Rows[row.Index].Cells["Ki67"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["InitialSizeMRIUSGMamo"].Value.ToString() == "" ||
                            dataGridView1.Rows[row.Index].Cells["InitialSizeMRIUSGMamo"].Value.ToString().Trim() == "CMS")
                            dataGridView1.Rows[row.Index].Cells["InitialSizeMRIUSGMamo"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString() == "" ||
                            dataGridView1.Rows[row.Index].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString().Trim() == "CMS")
                            dataGridView1.Rows[row.Index].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["ChemoType"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["ChemoType"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["NumberofChemoCycles"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["NumberofChemoCycles"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["SurgicalProcedure"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["SurgicalProcedure"].Style.BackColor = Color.Tomato;

                        if (Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERPRPositive"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERPRNegative"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERPositivePRNegative"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERNegativePRPositive"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERPRHER2NegativeTrippleNegative"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["ERPRHER2PositiveTripplePositive"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["HarmoneNegativeHER2Positive"].Value) == false &&
                            Convert.ToBoolean(dataGridView1.Rows[row.Index].Cells["HarmonePositiveHER2Negative"].Value) == false)
                        {
                            dataGridView1.Rows[row.Index].Cells["ERPRPositive"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["ERPRNegative"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["ERPositivePRNegative"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["ERNegativePRPositive"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["ERPRHER2NegativeTrippleNegative"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["ERPRHER2PositiveTripplePositive"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["HarmoneNegativeHER2Positive"].Style.BackColor = Color.Tomato;
                            dataGridView1.Rows[row.Index].Cells["HarmonePositiveHER2Negative"].Style.BackColor = Color.Tomato;
                        }

                        if (dataGridView1.Rows[row.Index].Cells["PostgTreatmentStaging"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["PostgTreatmentStaging"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["PerChangeInSize"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["PerChangeInSize"].Style.BackColor = Color.Tomato;

                        if (dataGridView1.Rows[row.Index].Cells["DateofSurgery"].Value.ToString() == "")
                            dataGridView1.Rows[row.Index].Cells["DateofSurgery"].Style.BackColor = Color.Tomato;
                    }

                    if (row.Cells["RecordStatus"].Value.ToString() == "2")
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;

                    if (row.Cells["RecordStatus"].Value.ToString() == "3")
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Orange;


                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }      
        private int copyAlltoClipboard()
        {
            int isNotNull = 0;

            //dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);

                isNotNull =  1;
            }

            return isNotNull;




        }

        private void BtnExporttoExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exporting to Excel", "Export Esxcel!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (copyAlltoClipboard() == 0)
            {
                MessageBox.Show("No Columns Selected", "Export Esxcel!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            Microsoft.Office.Interop.Excel.Application xlexcel;

            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;

            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            xlexcel = new Microsoft.Office.Interop.Excel.Application();

            xlexcel.Visible = true;

            xlWorkBook = xlexcel.Workbooks.Add(misValue);

            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];

            CR.Select();

            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);



        }
    }
}
