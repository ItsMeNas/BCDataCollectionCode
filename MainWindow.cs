using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using EvaluationofNCinBC.DAL;
using EvaluationofNCinBC.Model;
using System.IO;

namespace EvaluationofNCinBC
{
    public partial class FrmMain : Form
    {
        BCPatient bcpatient = new BCPatient();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {

                this.txtMrn.Select();

                this.cmbStatus.SelectedIndex = 0;

                FillCombo();

                FillDataGrids();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DAL_BCPatient dal_Patient = new DAL_BCPatient();

                //if (ValidateControls() == false)
                //    return;

                if (this.txtMrn.Text.Trim() == string.Empty || this.txtMrn.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Patient MRN.", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMrn.Focus();

                    return;
                }


                //string  MRNPersistance = string.Empty;

                string IDPersistance = string.Empty;

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    IDPersistance = Convert.ToString(this.dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    bcpatient.BCPatientId = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["ID"].Value);
                }

                //MRNPersistance = bcpatient.BCPatientMRN = this.txtMrn.Text.Trim();

                bcpatient.BCPatientMRN = this.txtMrn.Text.Trim();

                bcpatient.Age = this.txtAge.Text.Trim();

                bcpatient.Status = this.cmbStatus.SelectedItem.ToString();

                bcpatient.DateofDiagnosis = this.dtDiagnosisDate.Value;

                bcpatient.NodalStatus = this.txtNodalStatus.Text.Trim();

                bcpatient.Grade = this.txtGrade.Text.Trim();

                bcpatient.Ki67 = this.txtKi67.Text.Trim();

                bcpatient.ERPRPositive = false;

                if (this.cbErPrPositive.Checked == true)
                {
                    bcpatient.ERPRPositive = true;

                    bcpatient.CancerStatus = "ER AND PR Positive";
                }

                bcpatient.ERPRNegative = false;

                if (this.cbErPrNegative.Checked == true)
                {
                    bcpatient.ERPRNegative = true;

                    bcpatient.CancerStatus = "ER AND PR Negative";
                }

                bcpatient.ERPositivePRNegative = false;

                if (this.cbErPositivePrNegative.Checked == true)
                {
                    bcpatient.ERPositivePRNegative = true;

                    bcpatient.CancerStatus = "ER Positive AND PR Negative";
                }

                bcpatient.ERNegativePRPositive = false;

                if (this.cbErNegativePrPositive.Checked == true)
                {
                    bcpatient.ERNegativePRPositive = true;

                    bcpatient.CancerStatus = "ER Negative AND PR Positive";

                }

                bcpatient.ERPRHER2NegativeTrippleNegative = false;

                if (this.cbErPrHer2Negative_TrippleNegative.Checked == true)
                {
                    bcpatient.ERPRHER2NegativeTrippleNegative = true;

                    bcpatient.CancerStatus = "ER PR AND HER2 Negative - Tripple Negative";
                }

                bcpatient.ERPRHER2PositiveTripplePositive = false;

                if (this.cbErPrHer2positive_TripplePositive.Checked == true)
                {
                    bcpatient.ERPRHER2PositiveTripplePositive = true;

                    bcpatient.CancerStatus = "ER PR AND HER2 Positive - Tripple Positive";

                }

                bcpatient.HarmoneNegativeHER2Positive = false;

                if (this.cbTrpiPositive.Checked == true)
                {
                    bcpatient.HarmoneNegativeHER2Positive = true;

                    bcpatient.CancerStatus = "Harmone Negative AND HER2 Positive";

                }

                if (this.cbTrpiNegative.Checked == true)
                {
                    bcpatient.HarmonePositiveHER2Negative = true;

                    bcpatient.CancerStatus = "Harmone Positive AND HER2 Negative";

                }


                if (bcpatient.CancerStatus == null)
                {
                    bcpatient.CancerStatus = "";

                    cb_complete.Checked = false;

                    bcpatient.RecordStatus = 0;
                }


                bcpatient.InitialSizeMRIUSGMamo = this.txtSize.Text.Trim();

                bcpatient.PostNeoadjuvantChemoSizeMRIUSGMamo = this.txtPostNeo.Text.Trim();

                bcpatient.ChemoType = this.txtTypeOfChemo.Text.Trim();

                //bcpatient.NumberofChemoCycles = Convert.ToInt32(this.txtNumberofChemoCycles.Text.Trim());
                bcpatient.NumberofChemoCycles = this.txtNumberofChemoCycles.Text.Trim();

                bcpatient.SurgicalProcedure = txtSurgicalProcedure.Text.Trim();

                bcpatient.DateofSurgery = this.dtSurgeryDate.Value;

                if (this.txtComments.Text.Trim() == string.Empty || this.txtComments.Text.Trim() == string.Empty)
                {
                    bcpatient.AnyComments = "None";
                }
                else
                    bcpatient.AnyComments = this.txtComments.Text.Trim();

                bcpatient.PostgTreatmentStaging = txtPostTreatmentStaging.Text.Trim();

                bcpatient.PerChangeInSize = txtPerChangeInSize.Text.Trim();

                if (cb_revisit.Checked == true)
                    bcpatient.RecordStatus = 1;

                if (cb_discard.Checked == true)
                    bcpatient.RecordStatus = 3;

                if (cb_complete.Checked == true ||
                    CheckRecordCompletion() == 2)
                    bcpatient.RecordStatus = 2;



                //bool success = false;

                //Button clickedButton = sender as Button;

                //if (clickedButton != null)
                //{

                //    if (clickedButton.Text == "Add")
                //        success = dal_Patient.InsertData(bcpatient);

                //    if (clickedButton.Text == "Update")
                //        success = dal_Patient.UpdateData(bcpatient);
                //}

                //if (success == true)
                //{
                //    if (clickedButton.Text == "Update")
                //    {
                //        MessageBox.Show("Record With MRN Number " + this.txtMrn.Text.Trim() + " Successfully Updated!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    if (clickedButton.Text == "Add")
                //    {
                //        MessageBox.Show("New Record With MRN Number " + this.txtMrn.Text.Trim() + " Successfully Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //}

                this.dataGridView1.DataSource = null;

                this.dataGridView1.DataSource = dal_Patient.UpdateDataAndReturnDataset(bcpatient).Tables[0];

                this.dataGridView1.Sort(this.dataGridView1.Columns["ID"], ListSortDirection.Ascending);

                this.dataGridView1.Columns["RecordStatus"].Visible = false;

                this.dataGridView1.Columns["ID"].Visible = true;

                //GridView1ColourCode();


                //FillDataGrids();

                ClearControls();

                txtMrn.Enabled = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //if (row.Cells["BCPatientMRN"].Value.ToString() == MRNPersistance)
                    //{
                    //    dataGridView1.Rows[row.Index].Selected = true;

                    //    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    //}


                    if (row.Cells["ID"].Value.ToString() == IDPersistance)
                    {
                        dataGridView1.Rows[row.Index + 1].Selected = true;

                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    }

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
                    }

                    if (row.Cells["RecordStatus"].Value.ToString() == "2")
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;

                    if (row.Cells["RecordStatus"].Value.ToString() == "3")
                        dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.Orange;


                }

                MessageBox.Show("New Record With MRN Number " + this.txtMrn.Text.Trim() + " Successfully Added!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private int CheckRecordCompletion()
        {
            try
            {
                int isComplete = 2;

                //if (this.txtPatientName.Text.Trim() == string.Empty || this.txtPatientName.Text.Trim() == string.Empty)
                //    return 0;

                if (this.txtMrn.Text.Trim() == string.Empty || this.txtMrn.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtAge.Text.Trim() == string.Empty || this.txtAge.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtNodalStatus.Text.Trim() == string.Empty || this.txtNodalStatus.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtGrade.Text.Trim() == string.Empty || this.txtGrade.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtKi67.Text.Trim() == string.Empty || this.txtKi67.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtSize.Text.Trim() == string.Empty || this.txtSize.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtPostNeo.Text.Trim() == string.Empty || this.txtPostNeo.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtTypeOfChemo.Text.Trim() == string.Empty || this.txtTypeOfChemo.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtNumberofChemoCycles.Text.Trim() == string.Empty || this.txtNumberofChemoCycles.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtSurgicalProcedure.Text.Trim() == string.Empty || this.txtSurgicalProcedure.Text.Trim() == string.Empty)
                    return 0;

                if (cbErPrPositive.Checked == false &&
                    cbErPrNegative.Checked == false &&
                    cbErPositivePrNegative.Checked == false &&
                    cbErNegativePrPositive.Checked == false &&
                    cbErPrHer2Negative_TrippleNegative.Checked == false &&
                    cbErPrHer2positive_TripplePositive.Checked == false &&
                    cbTrpiPositive.Checked == false &&
                    cbTrpiNegative.Checked == false)
                    return 0;

                if (this.txtPostTreatmentStaging.Text.Trim() == string.Empty || this.txtPostTreatmentStaging.Text.Trim() == string.Empty)
                    return 0;

                if (this.txtPerChangeInSize.Text.Trim() == string.Empty || this.txtPerChangeInSize.Text.Trim() == string.Empty)
                    return 0;

                return isComplete;

            }
            catch (Exception Ex)
            {
                throw Ex;

            }
        }

        private bool ValidateControls()
        {
            try
            {
                //if (this.txtPatientName.Text.Trim() == string.Empty || this.txtPatientName.Text.Trim() == string.Empty)
                //{
                //    MessageBox.Show("Please Enter Patient Name.", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //    txtPatientName.Focus();

                //    return false;
                //}

                if (this.txtMrn.Text.Trim() == string.Empty || this.txtMrn.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Patient MRN.", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtMrn.Focus();

                    return false;
                }

                if (this.txtAge.Text.Trim() == string.Empty || this.txtAge.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Patient Age. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtAge.Focus();

                    return false;
                }

                if (this.txtNodalStatus.Text.Trim() == string.Empty || this.txtNodalStatus.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Nodal Status. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNodalStatus.Focus();

                    return false;
                }

                if (this.txtGrade.Text.Trim() == string.Empty || this.txtGrade.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Tumor Grade. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtGrade.Focus();

                    return false;
                }

                if (this.txtKi67.Text.Trim() == string.Empty || this.txtKi67.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Ki67 Value. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtKi67.Focus();

                    return false;
                }

                if (this.txtSize.Text.Trim() == string.Empty || this.txtSize.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Tumor Size. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSize.Focus();

                    return false;
                }

                if (this.txtPostNeo.Text.Trim() == string.Empty || this.txtPostNeo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Post Treatment Tumor Size. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPostNeo.Focus();

                    return false;
                }

                if (this.txtTypeOfChemo.Text.Trim() == string.Empty || this.txtTypeOfChemo.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Type of Chemo. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtTypeOfChemo.Focus();

                    return false;
                }

                if (this.txtNumberofChemoCycles.Text.Trim() == string.Empty || this.txtNumberofChemoCycles.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter No. of Chemo Cycles. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNumberofChemoCycles.Focus();

                    return false;
                }

                if (this.txtSurgicalProcedure.Text.Trim() == string.Empty || this.txtSurgicalProcedure.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Enter Surgical Procidure. ", "Missin Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSurgicalProcedure.Focus();

                    return false;
                }

                return true;

            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DAL_BCPatient dal_Patient = new DAL_BCPatient();

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    if (this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString() != null || this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString() != "")
                    {

                        string ID = this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                        string MRN = this.dataGridView1.SelectedRows[0].Cells["BCPatientMRN"].Value.ToString();


                        DialogResult dialogResult = MessageBox.Show("Record With MRN Number " + this.txtMrn.Text.Trim() + " will be Deleted! Do you wish to continue?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (dialogResult == DialogResult.Yes)
                        {
                            if (dal_Patient.DeleteBCCRecord(ID) == true)
                            {
                                ClearControls();

                                FillDataGrids();

                                MessageBox.Show("Record " + ID + " With MRN Number " + MRN + " Successfully Deleted!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtKeyPress_SelectNumbersOnl(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDataGrids()
        {
            try
            {
                DAL_BCPatient dal_Patient = new DAL_BCPatient();

                this.dataGridView1.DataSource = null;

                this.dataGridView1.DataSource = dal_Patient.FillGridView().Tables[0];

                this.dataGridView1.Sort(this.dataGridView1.Columns["ID"], ListSortDirection.Ascending);

                this.dataGridView1.Columns["RecordStatus"].Visible = false;

                this.dataGridView1.Columns["ID"].Visible = true;

                //GridView1ColourCode();

                GridViewColouring();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();

                FillDataGrids();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ClearControls()
        {
            try
            {
                //this.txtPatientName.Text = string.Empty;

                this.txtMrn.Text = string.Empty;

                this.txtAge.Text = string.Empty;

                this.cmbStatus.SelectedIndex = 0;

                this.dtDiagnosisDate.Value = DateTime.Now.Date;

                this.txtNodalStatus.Text = string.Empty;

                this.txtGrade.Text = string.Empty;

                //this.txtKi67.Text = "%";

                this.txtKi67.Text = string.Empty;

                if (this.cbErPrPositive.Checked == true)
                    this.cbErPrPositive.Checked = false;

                if (this.cbErPrNegative.Checked == true)
                    this.cbErPrNegative.Checked = false;

                if (this.cbErPositivePrNegative.Checked == true)
                    this.cbErPositivePrNegative.Checked = false;

                if (this.cbErNegativePrPositive.Checked == true)
                    this.cbErNegativePrPositive.Checked = false;

                if (this.cbErPrHer2Negative_TrippleNegative.Checked == true)
                    this.cbErPrHer2Negative_TrippleNegative.Checked = false;

                if (this.cbErPrHer2positive_TripplePositive.Checked == true)
                    this.cbErPrHer2positive_TripplePositive.Checked = false;

                if (this.cbTrpiPositive.Checked == true)
                    this.cbTrpiPositive.Checked = false;

                this.txtSize.Text = string.Empty;

                this.txtPostNeo.Text = string.Empty;

                this.txtTypeOfChemo.Text = string.Empty;

                this.txtNumberofChemoCycles.Text = string.Empty;

                this.txtSurgicalProcedure.Text = string.Empty;

                this.txtComments.Text = string.Empty;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[2].Value.ToString();

                if (dataGridView1.SelectedCells.Count > 0)
                {
                    string cellValue = this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                    //this.txtPatientName.Text = this.dataGridView1.SelectedRows[0].Cells["BCPatientName"].Value.ToString();

                    this.txtMrn.Text = this.dataGridView1.SelectedRows[0].Cells["BCPatientMRN"].Value.ToString();

                    this.txtAge.Text = this.dataGridView1.SelectedRows[0].Cells["Age"].Value.ToString();

                    this.cmbStatus.SelectedItem = this.dataGridView1.SelectedRows[0].Cells["Status"].Value.ToString();

                    if (this.dataGridView1.SelectedRows[0].Cells["DateofDiagnosis"].Value == null ||
                        this.dataGridView1.SelectedRows[0].Cells["DateofDiagnosis"].Value == DBNull.Value ||
                        String.IsNullOrWhiteSpace(this.dataGridView1.SelectedRows[0].Cells["DateofDiagnosis"].Value.ToString()))
                    {

                    }
                    else
                    {
                        this.dtDiagnosisDate.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells["DateofDiagnosis"].Value.ToString()).Date;
                    }

                    this.txtNodalStatus.Text = this.dataGridView1.SelectedRows[0].Cells["NodalStatus"].Value.ToString();

                    this.txtGrade.Text = this.dataGridView1.SelectedRows[0].Cells["Grade"].Value.ToString();



                    if (this.dataGridView1.SelectedRows[0].Cells["Ki67"].Value.ToString() == string.Empty ||
                        this.dataGridView1.SelectedRows[0].Cells["Ki67"].Value.ToString() == "")
                        this.txtKi67.Text = "";
                    else
                        this.txtKi67.Text = this.dataGridView1.SelectedRows[0].Cells["Ki67"].Value.ToString();

                    this.cbErPrPositive.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERPRPositive"].Value.ToString());

                    this.cbErPrNegative.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERPRNegative"].Value.ToString());

                    this.cbErPositivePrNegative.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERPositivePRNegative"].Value.ToString());

                    this.cbErNegativePrPositive.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERNegativePRPositive"].Value.ToString());

                    this.cbErPrHer2Negative_TrippleNegative.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERPRHER2NegativeTrippleNegative"].Value.ToString());

                    this.cbErPrHer2positive_TripplePositive.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["ERPRHER2PositiveTripplePositive"].Value.ToString());

                    this.cbTrpiPositive.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["HarmoneNegativeHER2Positive"].Value.ToString());

                    this.cbTrpiNegative.Checked = Convert.ToBoolean(this.dataGridView1.SelectedRows[0].Cells["HarmonePositiveHER2Negative"].Value.ToString());

                    if (this.dataGridView1.SelectedRows[0].Cells["InitialSizeMRIUSGMamo"].Value.ToString() == string.Empty ||
                        this.dataGridView1.SelectedRows[0].Cells["InitialSizeMRIUSGMamo"].Value.ToString() == "")
                        this.txtSize.Text = "";

                    else
                        this.txtSize.Text = this.dataGridView1.SelectedRows[0].Cells["InitialSizeMRIUSGMamo"].Value.ToString();

                    if (this.dataGridView1.SelectedRows[0].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString() == string.Empty ||
                        this.dataGridView1.SelectedRows[0].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString() == "")
                        this.txtPostNeo.Text = "";
                    else
                        this.txtPostNeo.Text = this.dataGridView1.SelectedRows[0].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString();

                    this.txtTypeOfChemo.Text = this.dataGridView1.SelectedRows[0].Cells["ChemoType"].Value.ToString();

                    this.txtNumberofChemoCycles.Text = this.dataGridView1.SelectedRows[0].Cells["NumberofChemoCycles"].Value.ToString();

                    this.txtSurgicalProcedure.Text = this.dataGridView1.SelectedRows[0].Cells["SurgicalProcedure"].Value.ToString();

                    this.txtComments.Text = this.dataGridView1.SelectedRows[0].Cells["AnyComments"].Value.ToString();

                    this.txtPostTreatmentStaging.Text = this.dataGridView1.SelectedRows[0].Cells["PostgTreatmentStaging"].Value.ToString();

                    this.txtPerChangeInSize.Text = this.dataGridView1.SelectedRows[0].Cells["PerChangeInSize"].Value.ToString();

                    if (this.dataGridView1.SelectedRows[0].Cells["DateofSurgery"].Value == null ||
                       this.dataGridView1.SelectedRows[0].Cells["DateofSurgery"].Value == DBNull.Value ||
                       String.IsNullOrWhiteSpace(this.dataGridView1.SelectedRows[0].Cells["DateofSurgery"].Value.ToString()))
                    {
                        this.dtSurgeryDate.Value = DateTime.Today;
                    }
                    else
                    {
                        this.dtSurgeryDate.Value = Convert.ToDateTime(this.dataGridView1.SelectedRows[0].Cells["DateofSurgery"].Value.ToString()).Date;
                    }

                    if (this.dataGridView1.SelectedRows[0].Cells["RecordStatus"].Value.ToString() == "0")
                    {
                        this.cb_revisit.Checked = false;

                        this.cb_discard.Checked = false;

                        this.cb_complete.Checked = false;
                    }

                    if (this.dataGridView1.SelectedRows[0].Cells["RecordStatus"].Value.ToString() == "1")
                    {
                        this.cb_revisit.Checked = true;

                        this.cb_discard.Checked = false;

                        this.cb_complete.Checked = false;
                    }

                    if (this.dataGridView1.SelectedRows[0].Cells["RecordStatus"].Value.ToString() == "2")
                    {
                        this.cb_revisit.Checked = false;

                        this.cb_discard.Checked = false;

                        this.cb_complete.Checked = true;
                    }


                    if (this.dataGridView1.SelectedRows[0].Cells["RecordStatus"].Value.ToString() == "3")
                    {
                        this.cb_discard.Checked = true;

                        this.cb_revisit.Checked = false;

                        this.cb_complete.Checked = false;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();

                bs.DataSource = dataGridView1.DataSource;

                bs.Filter = "BCPatientMRN like '%" + txtSearch.Text + "%'";

                dataGridView1.DataSource = bs;

                //GridView1ColourCode();

                GridViewColouring();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {
            try
            {
                //GridView1ColourCode();

                GridViewColouring();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        //private void GridView1ColourCode()
        //{
        //    try
        //    {
        //        for (int i = 0, loopTo = this.dataGridView1.Rows.Count - 1; i <= loopTo; i++)
        //        {
        //            if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "" ||
        //                this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == string.Empty ||
        //                this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "0")
        //            {
        //                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
        //            }                   

        //            if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "1")
        //            {
        //                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSkyBlue;

        //                if (dataGridView1.Rows[i].Cells["Age"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["Age"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["Status"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["Status"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["DateofDiagnosis"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["DateofDiagnosis"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["NodalStatus"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["NodalStatus"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["Grade"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["Grade"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["Ki67"].Value.ToString() == "" ||
        //                    dataGridView1.Rows[i].Cells["Ki67"].Value.ToString().Trim() == "%")
        //                    dataGridView1.Rows[i].Cells["Ki67"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["InitialSizeMRIUSGMamo"].Value.ToString() == "" ||
        //                    dataGridView1.Rows[i].Cells["InitialSizeMRIUSGMamo"].Value.ToString().Trim() == "CMS")
        //                    dataGridView1.Rows[i].Cells["InitialSizeMRIUSGMamo"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString() == "" ||
        //                    dataGridView1.Rows[i].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Value.ToString().Trim() == "CMS")
        //                    dataGridView1.Rows[i].Cells["PostNeoadjuvantChemoSizeMRIUSGMamo"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["ChemoType"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["ChemoType"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["NumberofChemoCycles"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["NumberofChemoCycles"].Style.BackColor = Color.Tomato;

        //                if (dataGridView1.Rows[i].Cells["SurgicalProcedure"].Value.ToString() == "")
        //                    dataGridView1.Rows[i].Cells["SurgicalProcedure"].Style.BackColor = Color.Tomato;

        //                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERPRPositive"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERPRNegative"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERPositivePRNegative"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERNegativePRPositive"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERPRHER2NegativeTrippleNegative"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["ERPRHER2PositiveTripplePositive"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["HarmoneNegativeHER2Positive"].Value) == false &&
        //                    Convert.ToBoolean(dataGridView1.Rows[i].Cells["HarmonePositiveHER2Negative"].Value) == false)
        //                {
        //                    dataGridView1.Rows[i].Cells["ERPRPositive"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["ERPRNegative"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["ERPositivePRNegative"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["ERNegativePRPositive"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["ERPRHER2NegativeTrippleNegative"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["ERPRHER2PositiveTripplePositive"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["HarmoneNegativeHER2Positive"].Style.BackColor = Color.Tomato;
        //                    dataGridView1.Rows[i].Cells["HarmonePositiveHER2Negative"].Style.BackColor = Color.Tomato;
        //                }

        //            }

        //            if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "2")
        //                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;

        //            if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "3")
        //                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
        //        }
        //    }
        //    catch (Exception Ex)
        //    {
        //        throw Ex;
        //    }
        //}

        private void TbPatientInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //GridView1ColourCode();

                GridViewColouring();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            try
            {
                txtMrn.SelectAll();

                Clipboard.Clear();

                Clipboard.SetText(txtMrn.Text.Trim());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_PatientType.SelectedItem.ToString() == "Upfront Surgery" ||
                this.cmb_PatientType.SelectedItem.ToString() == "Outside KFMC" ||
                 this.cmb_PatientType.SelectedItem.ToString() == "Palliative Treatment" ||
                 this.cmb_PatientType.SelectedItem.ToString() == "No file details")
            {
                cb_revisit.Checked = false;

                cb_discard.Checked = true;

            }

            if (this.cmb_PatientType.SelectedItem.ToString() == "NAC Followed by MRM ADJ Chemo, RT")
            {
                cb_revisit.Checked = true;

                cb_discard.Checked = false;
            }

            this.txtComments.Text = this.cmb_PatientType.SelectedItem.ToString();
        }

        private void cb_discard_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_discard.Checked == true)
            {
                cb_revisit.Checked = false;

                cb_complete.Checked = false;

            }
        }

        private void cb_revisit_CheckStateChanged(object sender, EventArgs e)
        {
            if (cb_revisit.Checked == true)
            {
                cb_discard.Checked = false;

                cb_complete.Checked = false;

            }
        }

        private void cb_complete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_complete.Checked == true)
            {
                cb_revisit.Checked = false;

                cb_discard.Checked = false;

            }
        }

        private void cbErPrPositive_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErPrPositive.Checked == true)
            {
                cbErPrNegative.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErNegativePrPositive.Checked = false;
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbErPrNegative_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErPrNegative.Checked == true)
            {
                cbErPrPositive.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErNegativePrPositive.Checked = false;
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbErPositivePrNegative_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErPositivePrNegative.Checked == true)
            {
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErNegativePrPositive.Checked = false;
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbErNegativePrPositive_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErNegativePrPositive.Checked == true)
            {
                cbErPositivePrNegative.Checked = false;
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }

        }

        private void cbErPrHer2Negative_TrippleNegative_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErPrHer2Negative_TrippleNegative.Checked == true)
            {
                cbErNegativePrPositive.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbErPrHer2positive_TripplePositive_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbErPrHer2positive_TripplePositive.Checked == true)
            {
                cbErNegativePrPositive.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbTrpiPositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbTrpiPositive_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrpiPositive.Checked == true)
            {
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErNegativePrPositive.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiNegative.Checked = false;
            }
        }

        private void cbTrpiNegative_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrpiNegative.Checked == true)
            {
                cbErPrHer2Negative_TrippleNegative.Checked = false;
                cbErNegativePrPositive.Checked = false;
                cbErPositivePrNegative.Checked = false;
                cbErPrPositive.Checked = false;
                cbErPrNegative.Checked = false;
                cbErPrHer2positive_TripplePositive.Checked = false;
                cbTrpiPositive.Checked = false;
            }
        }

        private void cb_allrecords_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_allrecords.Checked == true)
            {
                cb_RevisitedRecords.Checked = false;

                cb_completedRecords.Checked = false;

                cb_discardedrecords.Checked = false;

                cb_new.Checked = false;


                foreach (DataGridViewRow dr in this.dataGridView1.Rows)
                {
                    if (dr.Cells["RecordStatus"].Value.ToString() == "0")
                    {
                        dr.Visible = true;
                    }

                    if (dr.Cells["RecordStatus"].Value.ToString() == "1")
                    {
                        dr.Visible = true;
                    }

                    if (dr.Cells["RecordStatus"].Value.ToString() == "2")
                    {
                        dr.Visible = true;
                    }

                    if (dr.Cells["RecordStatus"].Value.ToString() == "3")
                    {
                        dr.Visible = true;
                    }
                }
            }
        }

        private void cb_new_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_new.Checked == true)
            {
                cb_RevisitedRecords.Checked = false;

                cb_completedRecords.Checked = false;

                cb_discardedrecords.Checked = false;

                cb_allrecords.Checked = false;

            }

            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr.Cells["RecordStatus"].Value.ToString() == "0")
                {
                    dr.Visible = true;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "1")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "2")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "3")
                {
                    dr.Visible = false;
                }
            }



        }

        private void cb_RevisitedRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_RevisitedRecords.Checked == true)
            {

                cb_completedRecords.Checked = false;

                cb_discardedrecords.Checked = false;

                cb_allrecords.Checked = false;

                cb_new.Checked = false;

            }

            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr.Cells["RecordStatus"].Value.ToString() == "0")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "1")
                {
                    dr.Visible = true;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "2")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "3")
                {
                    dr.Visible = false;
                }
            }
        }

        private void cb_completedRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_completedRecords.Checked == true)
            {
                cb_RevisitedRecords.Checked = false;

                cb_discardedrecords.Checked = false;

                cb_allrecords.Checked = false;

                cb_new.Checked = false;

            }

            foreach (DataGridViewRow dr in this.dataGridView1.Rows)
            {
                if (dr.Cells["RecordStatus"].Value.ToString() == "0")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "1")
                {
                    dr.Visible = false;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "2")
                {
                    dr.Visible = true;
                }

                if (dr.Cells["RecordStatus"].Value.ToString() == "3")
                {
                    dr.Visible = false;
                }
            }
        }

        private void cb_discardedrecords_CheckedChanged(object sender, EventArgs e)
        {
            cb_RevisitedRecords.Checked = false;

            cb_allrecords.Checked = false;

            cb_new.Checked = false;

            cb_completedRecords.Checked = false;

            for (int i = 0, loopTo = this.dataGridView1.Rows.Count - 1; i <= loopTo; i++)
            {
                if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "" ||
                    this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == string.Empty ||
                    this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "0")
                {
                    dataGridView1.Rows[i].Visible = false;
                }

                if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "1")
                    dataGridView1.Rows[i].Visible = false;

                if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "2")
                    dataGridView1.Rows[i].Visible = false;

                if (this.dataGridView1.Rows[i].Cells["RecordStatus"].Value.ToString() == "3")
                    dataGridView1.Rows[i].Visible = true;
            }

        }

        public void FillCombo()
        {
            try
            {
                //string[] files = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.accdb");


                DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

                FileInfo[] files = di.GetFiles("*.accdb");

                foreach (FileInfo file in files)
                {
                    this.cmbDataFiles.Items.Add(file.Name);
                }

                if (cmbDataFiles.Items.Count > 0)
                {
                    cmbDataFiles.SelectedItem = Convert.ToString(System.IO.File.ReadAllText("FileName.txt").Trim());
                }

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "FileName.txt", String.Empty);

                TextWriter tw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "FileName.txt", true);

                tw.WriteLine(cmbDataFiles.SelectedItem);

                tw.Close();

            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFullList_Click(object sender, EventArgs e)
        {
            try
            {

                frmFullList flList = new frmFullList();

                flList.ShowDialog();

            }
            catch (Exception Ex)
            {
                throw Ex;

            }
        }
    }
}
