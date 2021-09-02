using System.Windows.Forms;

namespace EvaluationofNCinBC
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            System.Windows.Forms.PictureBox pictureBox2;
            this.gb_patientInfo = new System.Windows.Forms.GroupBox();
            this.cb_complete = new System.Windows.Forms.CheckBox();
            this.cb_discard = new System.Windows.Forms.CheckBox();
            this.cb_revisit = new System.Windows.Forms.CheckBox();
            this.dtDiagnosisDate = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblDateofDia = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.txtMrn = new System.Windows.Forms.TextBox();
            this.lblMrn = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.TbPatientInfo = new System.Windows.Forms.TabControl();
            this.tbpgPatientInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.cmbDataFiles = new System.Windows.Forms.ComboBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cb_allrecords = new System.Windows.Forms.CheckBox();
            this.lbl_MRNnumber = new System.Windows.Forms.Label();
            this.cb_discardedrecords = new System.Windows.Forms.CheckBox();
            this.cb_completedRecords = new System.Windows.Forms.CheckBox();
            this.cb_RevisitedRecords = new System.Windows.Forms.CheckBox();
            this.cb_new = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.gbTreatmentDetails = new System.Windows.Forms.GroupBox();
            this.txtPerChangeInSize = new System.Windows.Forms.TextBox();
            this.lblPercentageChangeInSize = new System.Windows.Forms.Label();
            this.txtPostTreatmentStaging = new System.Windows.Forms.TextBox();
            this.lblPostTreatmentStaging = new System.Windows.Forms.Label();
            this.lblPatientType = new System.Windows.Forms.Label();
            this.cmb_PatientType = new System.Windows.Forms.ComboBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtNumberofChemoCycles = new System.Windows.Forms.TextBox();
            this.lblNoofChemoCycles = new System.Windows.Forms.Label();
            this.txtPostNeo = new System.Windows.Forms.TextBox();
            this.lblPostNeo = new System.Windows.Forms.Label();
            this.txtTypeOfChemo = new System.Windows.Forms.TextBox();
            this.txtSurgicalProcedure = new System.Windows.Forms.TextBox();
            this.lblTypeofChemo = new System.Windows.Forms.Label();
            this.lblSurgicalProcedure = new System.Windows.Forms.Label();
            this.gb_Data = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbChemoData = new System.Windows.Forms.GroupBox();
            this.cbTrpiNegative = new System.Windows.Forms.CheckBox();
            this.lblHarmonePositiveHER2Negative = new System.Windows.Forms.Label();
            this.lblHarNegativeHer2Positive = new System.Windows.Forms.Label();
            this.cbTrpiPositive = new System.Windows.Forms.CheckBox();
            this.lblErPrHer2Popsitive_TripplePositive = new System.Windows.Forms.Label();
            this.cbErPrHer2positive_TripplePositive = new System.Windows.Forms.CheckBox();
            this.lblErPrHer2Negative_TrippleNegative = new System.Windows.Forms.Label();
            this.cbErPrHer2Negative_TrippleNegative = new System.Windows.Forms.CheckBox();
            this.lblErNPrP = new System.Windows.Forms.Label();
            this.cbErNegativePrPositive = new System.Windows.Forms.CheckBox();
            this.cbErPositivePrNegative = new System.Windows.Forms.CheckBox();
            this.lblErPPrN = new System.Windows.Forms.Label();
            this.lblErandPrN = new System.Windows.Forms.Label();
            this.cbErPrNegative = new System.Windows.Forms.CheckBox();
            this.cbErPrPositive = new System.Windows.Forms.CheckBox();
            this.lblErandPrP = new System.Windows.Forms.Label();
            this.lblKi67 = new System.Windows.Forms.Label();
            this.txtKi67 = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblNodalStatus = new System.Windows.Forms.Label();
            this.txtNodalStatus = new System.Windows.Forms.TextBox();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btnFullList = new System.Windows.Forms.Button();
            this.dtSurgeryDate = new System.Windows.Forms.DateTimePicker();
            this.lbldtSurgery = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gb_patientInfo.SuspendLayout();
            this.TbPatientInfo.SuspendLayout();
            this.tbpgPatientInfo.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbTreatmentDetails.SuspendLayout();
            this.gb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbChemoData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_patientInfo
            // 
            this.gb_patientInfo.Controls.Add(this.cb_complete);
            this.gb_patientInfo.Controls.Add(this.cb_discard);
            this.gb_patientInfo.Controls.Add(this.cb_revisit);
            this.gb_patientInfo.Controls.Add(this.btn_copy);
            this.gb_patientInfo.Controls.Add(this.dtDiagnosisDate);
            this.gb_patientInfo.Controls.Add(pictureBox2);
            this.gb_patientInfo.Controls.Add(this.cmbStatus);
            this.gb_patientInfo.Controls.Add(this.lblDateofDia);
            this.gb_patientInfo.Controls.Add(this.Status);
            this.gb_patientInfo.Controls.Add(this.txtMrn);
            this.gb_patientInfo.Controls.Add(this.lblMrn);
            this.gb_patientInfo.Controls.Add(this.txtAge);
            this.gb_patientInfo.Controls.Add(this.lblAge);
            this.gb_patientInfo.Location = new System.Drawing.Point(7, 36);
            this.gb_patientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gb_patientInfo.Name = "gb_patientInfo";
            this.gb_patientInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gb_patientInfo.Size = new System.Drawing.Size(938, 76);
            this.gb_patientInfo.TabIndex = 0;
            this.gb_patientInfo.TabStop = false;
            this.gb_patientInfo.Text = "Patient Info";
            // 
            // cb_complete
            // 
            this.cb_complete.AutoSize = true;
            this.cb_complete.Location = new System.Drawing.Point(344, 46);
            this.cb_complete.Margin = new System.Windows.Forms.Padding(2);
            this.cb_complete.Name = "cb_complete";
            this.cb_complete.Size = new System.Drawing.Size(70, 17);
            this.cb_complete.TabIndex = 25;
            this.cb_complete.Text = "Complete";
            this.cb_complete.UseVisualStyleBackColor = true;
            this.cb_complete.CheckedChanged += new System.EventHandler(this.cb_complete_CheckedChanged);
            // 
            // cb_discard
            // 
            this.cb_discard.AutoSize = true;
            this.cb_discard.Location = new System.Drawing.Point(162, 46);
            this.cb_discard.Margin = new System.Windows.Forms.Padding(2);
            this.cb_discard.Name = "cb_discard";
            this.cb_discard.Size = new System.Drawing.Size(100, 17);
            this.cb_discard.TabIndex = 24;
            this.cb_discard.Text = "Discard Record";
            this.cb_discard.UseVisualStyleBackColor = true;
            this.cb_discard.CheckStateChanged += new System.EventHandler(this.cb_discard_CheckStateChanged);
            // 
            // cb_revisit
            // 
            this.cb_revisit.AutoSize = true;
            this.cb_revisit.Location = new System.Drawing.Point(274, 46);
            this.cb_revisit.Margin = new System.Windows.Forms.Padding(2);
            this.cb_revisit.Name = "cb_revisit";
            this.cb_revisit.Size = new System.Drawing.Size(58, 17);
            this.cb_revisit.TabIndex = 23;
            this.cb_revisit.Text = "Revisit";
            this.cb_revisit.UseVisualStyleBackColor = true;
            this.cb_revisit.CheckStateChanged += new System.EventHandler(this.cb_revisit_CheckStateChanged);
            // 
            // dtDiagnosisDate
            // 
            this.dtDiagnosisDate.CustomFormat = "dd/MM/yyyy";
            this.dtDiagnosisDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDiagnosisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDiagnosisDate.Location = new System.Drawing.Point(419, 15);
            this.dtDiagnosisDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtDiagnosisDate.Name = "dtDiagnosisDate";
            this.dtDiagnosisDate.Size = new System.Drawing.Size(93, 19);
            this.dtDiagnosisDate.TabIndex = 6;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Alive",
            "Dead"});
            this.cmbStatus.Location = new System.Drawing.Point(783, 15);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(95, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // lblDateofDia
            // 
            this.lblDateofDia.AutoSize = true;
            this.lblDateofDia.Location = new System.Drawing.Point(320, 17);
            this.lblDateofDia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateofDia.Name = "lblDateofDia";
            this.lblDateofDia.Size = new System.Drawing.Size(91, 13);
            this.lblDateofDia.TabIndex = 10;
            this.lblDateofDia.Text = "Date of Diagnosis";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(739, 18);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status";
            // 
            // txtMrn
            // 
            this.txtMrn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMrn.Location = new System.Drawing.Point(128, 14);
            this.txtMrn.Margin = new System.Windows.Forms.Padding(2);
            this.txtMrn.Multiline = true;
            this.txtMrn.Name = "txtMrn";
            this.txtMrn.Size = new System.Drawing.Size(166, 21);
            this.txtMrn.TabIndex = 1;
            // 
            // lblMrn
            // 
            this.lblMrn.AutoSize = true;
            this.lblMrn.Location = new System.Drawing.Point(84, 17);
            this.lblMrn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMrn.Name = "lblMrn";
            this.lblMrn.Size = new System.Drawing.Size(32, 13);
            this.lblMrn.TabIndex = 7;
            this.lblMrn.Text = "MRN";
            // 
            // txtAge
            // 
            this.txtAge.AcceptsReturn = true;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(611, 14);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(107, 21);
            this.txtAge.TabIndex = 2;
            this.txtAge.Text = "0";
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress_SelectNumbersOnl);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(543, 17);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(62, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age (Years)";
            // 
            // TbPatientInfo
            // 
            this.TbPatientInfo.Controls.Add(this.tbpgPatientInfo);
            this.TbPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.TbPatientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.TbPatientInfo.Name = "TbPatientInfo";
            this.TbPatientInfo.SelectedIndex = 0;
            this.TbPatientInfo.Size = new System.Drawing.Size(962, 866);
            this.TbPatientInfo.TabIndex = 1;
            this.TbPatientInfo.SelectedIndexChanged += new System.EventHandler(this.TbPatientInfo_SelectedIndexChanged);
            // 
            // tbpgPatientInfo
            // 
            this.tbpgPatientInfo.Controls.Add(this.btnFullList);
            this.tbpgPatientInfo.Controls.Add(this.btnSave);
            this.tbpgPatientInfo.Controls.Add(this.lblSelectFile);
            this.tbpgPatientInfo.Controls.Add(this.cmbDataFiles);
            this.tbpgPatientInfo.Controls.Add(this.gbSearch);
            this.tbpgPatientInfo.Controls.Add(this.btnRefresh);
            this.tbpgPatientInfo.Controls.Add(this.txtUpdate);
            this.tbpgPatientInfo.Controls.Add(this.gbTreatmentDetails);
            this.tbpgPatientInfo.Controls.Add(this.gb_Data);
            this.tbpgPatientInfo.Controls.Add(this.gbChemoData);
            this.tbpgPatientInfo.Controls.Add(this.gb_patientInfo);
            this.tbpgPatientInfo.Location = new System.Drawing.Point(4, 22);
            this.tbpgPatientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbpgPatientInfo.Name = "tbpgPatientInfo";
            this.tbpgPatientInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tbpgPatientInfo.Size = new System.Drawing.Size(954, 840);
            this.tbpgPatientInfo.TabIndex = 0;
            this.tbpgPatientInfo.Text = "Patient Info";
            this.tbpgPatientInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.Location = new System.Drawing.Point(316, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(14, 15);
            this.lblSelectFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(56, 13);
            this.lblSelectFile.TabIndex = 29;
            this.lblSelectFile.Text = "Select File";
            // 
            // cmbDataFiles
            // 
            this.cmbDataFiles.BackColor = System.Drawing.Color.LightPink;
            this.cmbDataFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataFiles.FormattingEnabled = true;
            this.cmbDataFiles.Location = new System.Drawing.Point(76, 11);
            this.cmbDataFiles.Name = "cmbDataFiles";
            this.cmbDataFiles.Size = new System.Drawing.Size(225, 21);
            this.cmbDataFiles.TabIndex = 28;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cb_allrecords);
            this.gbSearch.Controls.Add(this.lbl_MRNnumber);
            this.gbSearch.Controls.Add(this.cb_discardedrecords);
            this.gbSearch.Controls.Add(this.cb_completedRecords);
            this.gbSearch.Controls.Add(this.cb_RevisitedRecords);
            this.gbSearch.Controls.Add(this.cb_new);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Location = new System.Drawing.Point(9, 393);
            this.gbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(2);
            this.gbSearch.Size = new System.Drawing.Size(938, 37);
            this.gbSearch.TabIndex = 27;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            // 
            // cb_allrecords
            // 
            this.cb_allrecords.AutoSize = true;
            this.cb_allrecords.Location = new System.Drawing.Point(763, 11);
            this.cb_allrecords.Margin = new System.Windows.Forms.Padding(2);
            this.cb_allrecords.Name = "cb_allrecords";
            this.cb_allrecords.Size = new System.Drawing.Size(80, 17);
            this.cb_allrecords.TabIndex = 14;
            this.cb_allrecords.Text = "All Records";
            this.cb_allrecords.UseVisualStyleBackColor = true;
            this.cb_allrecords.Visible = false;
            this.cb_allrecords.CheckedChanged += new System.EventHandler(this.cb_allrecords_CheckedChanged);
            // 
            // lbl_MRNnumber
            // 
            this.lbl_MRNnumber.AutoSize = true;
            this.lbl_MRNnumber.Location = new System.Drawing.Point(58, 12);
            this.lbl_MRNnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MRNnumber.Name = "lbl_MRNnumber";
            this.lbl_MRNnumber.Size = new System.Drawing.Size(42, 13);
            this.lbl_MRNnumber.TabIndex = 13;
            this.lbl_MRNnumber.Text = "MRN #";
            // 
            // cb_discardedrecords
            // 
            this.cb_discardedrecords.AutoSize = true;
            this.cb_discardedrecords.Location = new System.Drawing.Point(805, 11);
            this.cb_discardedrecords.Margin = new System.Windows.Forms.Padding(2);
            this.cb_discardedrecords.Name = "cb_discardedrecords";
            this.cb_discardedrecords.Size = new System.Drawing.Size(117, 17);
            this.cb_discardedrecords.TabIndex = 12;
            this.cb_discardedrecords.Text = "Discarded Records";
            this.cb_discardedrecords.UseVisualStyleBackColor = true;
            this.cb_discardedrecords.Visible = false;
            this.cb_discardedrecords.CheckedChanged += new System.EventHandler(this.cb_discardedrecords_CheckedChanged);
            // 
            // cb_completedRecords
            // 
            this.cb_completedRecords.AutoSize = true;
            this.cb_completedRecords.Location = new System.Drawing.Point(805, 11);
            this.cb_completedRecords.Margin = new System.Windows.Forms.Padding(2);
            this.cb_completedRecords.Name = "cb_completedRecords";
            this.cb_completedRecords.Size = new System.Drawing.Size(119, 17);
            this.cb_completedRecords.TabIndex = 11;
            this.cb_completedRecords.Text = "Completed Records";
            this.cb_completedRecords.UseVisualStyleBackColor = true;
            this.cb_completedRecords.Visible = false;
            this.cb_completedRecords.CheckedChanged += new System.EventHandler(this.cb_completedRecords_CheckedChanged);
            // 
            // cb_RevisitedRecords
            // 
            this.cb_RevisitedRecords.AutoSize = true;
            this.cb_RevisitedRecords.Location = new System.Drawing.Point(790, 12);
            this.cb_RevisitedRecords.Margin = new System.Windows.Forms.Padding(2);
            this.cb_RevisitedRecords.Name = "cb_RevisitedRecords";
            this.cb_RevisitedRecords.Size = new System.Drawing.Size(101, 17);
            this.cb_RevisitedRecords.TabIndex = 10;
            this.cb_RevisitedRecords.Text = "Revisit Records";
            this.cb_RevisitedRecords.UseVisualStyleBackColor = true;
            this.cb_RevisitedRecords.Visible = false;
            this.cb_RevisitedRecords.CheckedChanged += new System.EventHandler(this.cb_RevisitedRecords_CheckedChanged);
            // 
            // cb_new
            // 
            this.cb_new.AutoSize = true;
            this.cb_new.Location = new System.Drawing.Point(817, 8);
            this.cb_new.Margin = new System.Windows.Forms.Padding(2);
            this.cb_new.Name = "cb_new";
            this.cb_new.Size = new System.Drawing.Size(91, 17);
            this.cb_new.TabIndex = 9;
            this.cb_new.Text = "New Records";
            this.cb_new.UseVisualStyleBackColor = true;
            this.cb_new.Visible = false;
            this.cb_new.CheckedChanged += new System.EventHandler(this.cb_new_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.BackColor = System.Drawing.Color.LightPink;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(109, 9);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 21);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightPink;
            this.btnRefresh.Location = new System.Drawing.Point(405, 10);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.BackColor = System.Drawing.Color.LightPink;
            this.txtUpdate.Location = new System.Drawing.Point(871, 246);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(71, 66);
            this.txtUpdate.TabIndex = 24;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = false;
            this.txtUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbTreatmentDetails
            // 
            this.gbTreatmentDetails.Controls.Add(this.dtSurgeryDate);
            this.gbTreatmentDetails.Controls.Add(this.lbldtSurgery);
            this.gbTreatmentDetails.Controls.Add(this.txtPerChangeInSize);
            this.gbTreatmentDetails.Controls.Add(this.lblPercentageChangeInSize);
            this.gbTreatmentDetails.Controls.Add(this.txtPostTreatmentStaging);
            this.gbTreatmentDetails.Controls.Add(this.lblPostTreatmentStaging);
            this.gbTreatmentDetails.Controls.Add(this.lblPatientType);
            this.gbTreatmentDetails.Controls.Add(this.cmb_PatientType);
            this.gbTreatmentDetails.Controls.Add(this.txtComments);
            this.gbTreatmentDetails.Controls.Add(this.lblComments);
            this.gbTreatmentDetails.Controls.Add(this.txtNumberofChemoCycles);
            this.gbTreatmentDetails.Controls.Add(this.lblNoofChemoCycles);
            this.gbTreatmentDetails.Controls.Add(this.txtPostNeo);
            this.gbTreatmentDetails.Controls.Add(this.lblPostNeo);
            this.gbTreatmentDetails.Controls.Add(this.txtTypeOfChemo);
            this.gbTreatmentDetails.Controls.Add(this.txtSurgicalProcedure);
            this.gbTreatmentDetails.Controls.Add(this.lblTypeofChemo);
            this.gbTreatmentDetails.Controls.Add(this.lblSurgicalProcedure);
            this.gbTreatmentDetails.Location = new System.Drawing.Point(7, 229);
            this.gbTreatmentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.gbTreatmentDetails.Name = "gbTreatmentDetails";
            this.gbTreatmentDetails.Padding = new System.Windows.Forms.Padding(2);
            this.gbTreatmentDetails.Size = new System.Drawing.Size(854, 160);
            this.gbTreatmentDetails.TabIndex = 18;
            this.gbTreatmentDetails.TabStop = false;
            this.gbTreatmentDetails.Text = "Treatment Details";
            // 
            // txtPerChangeInSize
            // 
            this.txtPerChangeInSize.AcceptsReturn = true;
            this.txtPerChangeInSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerChangeInSize.Location = new System.Drawing.Point(672, 19);
            this.txtPerChangeInSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerChangeInSize.Multiline = true;
            this.txtPerChangeInSize.Name = "txtPerChangeInSize";
            this.txtPerChangeInSize.Size = new System.Drawing.Size(173, 21);
            this.txtPerChangeInSize.TabIndex = 28;
            // 
            // lblPercentageChangeInSize
            // 
            this.lblPercentageChangeInSize.AutoSize = true;
            this.lblPercentageChangeInSize.Location = new System.Drawing.Point(578, 22);
            this.lblPercentageChangeInSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPercentageChangeInSize.Name = "lblPercentageChangeInSize";
            this.lblPercentageChangeInSize.Size = new System.Drawing.Size(90, 13);
            this.lblPercentageChangeInSize.TabIndex = 27;
            this.lblPercentageChangeInSize.Text = "Change In Size %";
            // 
            // txtPostTreatmentStaging
            // 
            this.txtPostTreatmentStaging.AcceptsReturn = true;
            this.txtPostTreatmentStaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostTreatmentStaging.Location = new System.Drawing.Point(375, 19);
            this.txtPostTreatmentStaging.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostTreatmentStaging.Multiline = true;
            this.txtPostTreatmentStaging.Name = "txtPostTreatmentStaging";
            this.txtPostTreatmentStaging.Size = new System.Drawing.Size(173, 21);
            this.txtPostTreatmentStaging.TabIndex = 26;
            // 
            // lblPostTreatmentStaging
            // 
            this.lblPostTreatmentStaging.AutoSize = true;
            this.lblPostTreatmentStaging.Location = new System.Drawing.Point(251, 22);
            this.lblPostTreatmentStaging.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostTreatmentStaging.Name = "lblPostTreatmentStaging";
            this.lblPostTreatmentStaging.Size = new System.Drawing.Size(118, 13);
            this.lblPostTreatmentStaging.TabIndex = 25;
            this.lblPostTreatmentStaging.Text = "Post Treatment Staging";
            // 
            // lblPatientType
            // 
            this.lblPatientType.AutoSize = true;
            this.lblPatientType.Location = new System.Drawing.Point(306, 102);
            this.lblPatientType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientType.Name = "lblPatientType";
            this.lblPatientType.Size = new System.Drawing.Size(64, 13);
            this.lblPatientType.TabIndex = 24;
            this.lblPatientType.Text = "PatientType";
            // 
            // cmb_PatientType
            // 
            this.cmb_PatientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PatientType.DropDownWidth = 200;
            this.cmb_PatientType.FormattingEnabled = true;
            this.cmb_PatientType.Items.AddRange(new object[] {
            "NAC Followed by MRM ADJ Chemo, RT",
            "Upfront Surgery",
            "Palliative Treatment",
            "Outside KFMC",
            "No file details"});
            this.cmb_PatientType.Location = new System.Drawing.Point(375, 99);
            this.cmb_PatientType.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_PatientType.Name = "cmb_PatientType";
            this.cmb_PatientType.Size = new System.Drawing.Size(173, 21);
            this.cmb_PatientType.TabIndex = 23;
            this.cmb_PatientType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtComments
            // 
            this.txtComments.AcceptsReturn = true;
            this.txtComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(375, 125);
            this.txtComments.Margin = new System.Windows.Forms.Padding(2);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(389, 21);
            this.txtComments.TabIndex = 22;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(314, 128);
            this.lblComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 4;
            this.lblComments.Text = "Comments";
            // 
            // txtNumberofChemoCycles
            // 
            this.txtNumberofChemoCycles.AcceptsReturn = true;
            this.txtNumberofChemoCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofChemoCycles.Location = new System.Drawing.Point(375, 72);
            this.txtNumberofChemoCycles.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumberofChemoCycles.Multiline = true;
            this.txtNumberofChemoCycles.Name = "txtNumberofChemoCycles";
            this.txtNumberofChemoCycles.Size = new System.Drawing.Size(173, 21);
            this.txtNumberofChemoCycles.TabIndex = 20;
            this.txtNumberofChemoCycles.Text = "0";
            this.txtNumberofChemoCycles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress_SelectNumbersOnl);
            // 
            // lblNoofChemoCycles
            // 
            this.lblNoofChemoCycles.AutoSize = true;
            this.lblNoofChemoCycles.Location = new System.Drawing.Point(244, 76);
            this.lblNoofChemoCycles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoofChemoCycles.Name = "lblNoofChemoCycles";
            this.lblNoofChemoCycles.Size = new System.Drawing.Size(126, 13);
            this.lblNoofChemoCycles.TabIndex = 2;
            this.lblNoofChemoCycles.Text = "Number of Chemo Cycles";
            // 
            // txtPostNeo
            // 
            this.txtPostNeo.AcceptsReturn = true;
            this.txtPostNeo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostNeo.Location = new System.Drawing.Point(375, 46);
            this.txtPostNeo.Margin = new System.Windows.Forms.Padding(2);
            this.txtPostNeo.Multiline = true;
            this.txtPostNeo.Name = "txtPostNeo";
            this.txtPostNeo.Size = new System.Drawing.Size(173, 21);
            this.txtPostNeo.TabIndex = 18;
            // 
            // lblPostNeo
            // 
            this.lblPostNeo.AutoSize = true;
            this.lblPostNeo.Location = new System.Drawing.Point(8, 49);
            this.lblPostNeo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostNeo.Name = "lblPostNeo";
            this.lblPostNeo.Size = new System.Drawing.Size(369, 13);
            this.lblPostNeo.TabIndex = 0;
            this.lblPostNeo.Text = "Post Neoadjuvant Chemo / Pre Surgery Size on MRI / Mammography / USG";
            // 
            // txtTypeOfChemo
            // 
            this.txtTypeOfChemo.AcceptsReturn = true;
            this.txtTypeOfChemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeOfChemo.Location = new System.Drawing.Point(672, 46);
            this.txtTypeOfChemo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTypeOfChemo.Multiline = true;
            this.txtTypeOfChemo.Name = "txtTypeOfChemo";
            this.txtTypeOfChemo.Size = new System.Drawing.Size(173, 21);
            this.txtTypeOfChemo.TabIndex = 19;
            // 
            // txtSurgicalProcedure
            // 
            this.txtSurgicalProcedure.AcceptsReturn = true;
            this.txtSurgicalProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurgicalProcedure.Location = new System.Drawing.Point(672, 72);
            this.txtSurgicalProcedure.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurgicalProcedure.Multiline = true;
            this.txtSurgicalProcedure.Name = "txtSurgicalProcedure";
            this.txtSurgicalProcedure.Size = new System.Drawing.Size(173, 21);
            this.txtSurgicalProcedure.TabIndex = 21;
            // 
            // lblTypeofChemo
            // 
            this.lblTypeofChemo.AutoSize = true;
            this.lblTypeofChemo.Location = new System.Drawing.Point(553, 49);
            this.lblTypeofChemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeofChemo.Name = "lblTypeofChemo";
            this.lblTypeofChemo.Size = new System.Drawing.Size(114, 13);
            this.lblTypeofChemo.TabIndex = 0;
            this.lblTypeofChemo.Text = "Type of Chemotherapy";
            // 
            // lblSurgicalProcedure
            // 
            this.lblSurgicalProcedure.AutoSize = true;
            this.lblSurgicalProcedure.Location = new System.Drawing.Point(570, 76);
            this.lblSurgicalProcedure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurgicalProcedure.Name = "lblSurgicalProcedure";
            this.lblSurgicalProcedure.Size = new System.Drawing.Size(97, 13);
            this.lblSurgicalProcedure.TabIndex = 0;
            this.lblSurgicalProcedure.Text = "Surgical Procedure";
            // 
            // gb_Data
            // 
            this.gb_Data.Controls.Add(this.dataGridView1);
            this.gb_Data.Location = new System.Drawing.Point(7, 434);
            this.gb_Data.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Data.Name = "gb_Data";
            this.gb_Data.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Data.Size = new System.Drawing.Size(938, 399);
            this.gb_Data.TabIndex = 0;
            this.gb_Data.TabStop = false;
            this.gb_Data.Text = "Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(934, 382);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // gbChemoData
            // 
            this.gbChemoData.Controls.Add(this.cbTrpiNegative);
            this.gbChemoData.Controls.Add(this.lblHarmonePositiveHER2Negative);
            this.gbChemoData.Controls.Add(this.lblHarNegativeHer2Positive);
            this.gbChemoData.Controls.Add(this.cbTrpiPositive);
            this.gbChemoData.Controls.Add(this.lblErPrHer2Popsitive_TripplePositive);
            this.gbChemoData.Controls.Add(this.cbErPrHer2positive_TripplePositive);
            this.gbChemoData.Controls.Add(this.lblErPrHer2Negative_TrippleNegative);
            this.gbChemoData.Controls.Add(this.cbErPrHer2Negative_TrippleNegative);
            this.gbChemoData.Controls.Add(this.lblErNPrP);
            this.gbChemoData.Controls.Add(this.cbErNegativePrPositive);
            this.gbChemoData.Controls.Add(this.cbErPositivePrNegative);
            this.gbChemoData.Controls.Add(this.lblErPPrN);
            this.gbChemoData.Controls.Add(this.lblErandPrN);
            this.gbChemoData.Controls.Add(this.cbErPrNegative);
            this.gbChemoData.Controls.Add(this.cbErPrPositive);
            this.gbChemoData.Controls.Add(this.lblErandPrP);
            this.gbChemoData.Controls.Add(this.lblKi67);
            this.gbChemoData.Controls.Add(this.txtKi67);
            this.gbChemoData.Controls.Add(this.lblGrade);
            this.gbChemoData.Controls.Add(this.txtGrade);
            this.gbChemoData.Controls.Add(this.lblSize);
            this.gbChemoData.Controls.Add(this.txtSize);
            this.gbChemoData.Controls.Add(this.lblNodalStatus);
            this.gbChemoData.Controls.Add(this.txtNodalStatus);
            this.gbChemoData.Location = new System.Drawing.Point(7, 116);
            this.gbChemoData.Margin = new System.Windows.Forms.Padding(2);
            this.gbChemoData.Name = "gbChemoData";
            this.gbChemoData.Padding = new System.Windows.Forms.Padding(2);
            this.gbChemoData.Size = new System.Drawing.Size(938, 109);
            this.gbChemoData.TabIndex = 7;
            this.gbChemoData.TabStop = false;
            this.gbChemoData.Text = "Cancer Details";
            // 
            // cbTrpiNegative
            // 
            this.cbTrpiNegative.AutoSize = true;
            this.cbTrpiNegative.Location = new System.Drawing.Point(878, 80);
            this.cbTrpiNegative.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrpiNegative.Name = "cbTrpiNegative";
            this.cbTrpiNegative.Size = new System.Drawing.Size(15, 14);
            this.cbTrpiNegative.TabIndex = 19;
            this.cbTrpiNegative.UseVisualStyleBackColor = true;
            this.cbTrpiNegative.CheckedChanged += new System.EventHandler(this.cbTrpiNegative_CheckedChanged);
            // 
            // lblHarmonePositiveHER2Negative
            // 
            this.lblHarmonePositiveHER2Negative.AutoSize = true;
            this.lblHarmonePositiveHER2Negative.Location = new System.Drawing.Point(700, 80);
            this.lblHarmonePositiveHER2Negative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHarmonePositiveHER2Negative.Name = "lblHarmonePositiveHER2Negative";
            this.lblHarmonePositiveHER2Negative.Size = new System.Drawing.Size(171, 13);
            this.lblHarmonePositiveHER2Negative.TabIndex = 18;
            this.lblHarmonePositiveHER2Negative.Text = "Harmone Positive HER 2 Negative";
            // 
            // lblHarNegativeHer2Positive
            // 
            this.lblHarNegativeHer2Positive.AutoSize = true;
            this.lblHarNegativeHer2Positive.Location = new System.Drawing.Point(488, 79);
            this.lblHarNegativeHer2Positive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHarNegativeHer2Positive.Name = "lblHarNegativeHer2Positive";
            this.lblHarNegativeHer2Positive.Size = new System.Drawing.Size(171, 13);
            this.lblHarNegativeHer2Positive.TabIndex = 12;
            this.lblHarNegativeHer2Positive.Text = "Harmone Negative HER 2 Positive";
            // 
            // cbTrpiPositive
            // 
            this.cbTrpiPositive.AutoSize = true;
            this.cbTrpiPositive.Location = new System.Drawing.Point(661, 80);
            this.cbTrpiPositive.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrpiPositive.Name = "cbTrpiPositive";
            this.cbTrpiPositive.Size = new System.Drawing.Size(15, 14);
            this.cbTrpiPositive.TabIndex = 16;
            this.cbTrpiPositive.UseVisualStyleBackColor = true;
            this.cbTrpiPositive.CheckedChanged += new System.EventHandler(this.cbTrpiPositive_CheckedChanged);
            // 
            // lblErPrHer2Popsitive_TripplePositive
            // 
            this.lblErPrHer2Popsitive_TripplePositive.AutoSize = true;
            this.lblErPrHer2Popsitive_TripplePositive.Location = new System.Drawing.Point(248, 80);
            this.lblErPrHer2Popsitive_TripplePositive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErPrHer2Popsitive_TripplePositive.Name = "lblErPrHer2Popsitive_TripplePositive";
            this.lblErPrHer2Popsitive_TripplePositive.Size = new System.Drawing.Size(201, 13);
            this.lblErPrHer2Popsitive_TripplePositive.TabIndex = 0;
            this.lblErPrHer2Popsitive_TripplePositive.Text = "ER PR HER 2  Positive / Tripple Positive";
            // 
            // cbErPrHer2positive_TripplePositive
            // 
            this.cbErPrHer2positive_TripplePositive.AutoSize = true;
            this.cbErPrHer2positive_TripplePositive.Location = new System.Drawing.Point(454, 80);
            this.cbErPrHer2positive_TripplePositive.Margin = new System.Windows.Forms.Padding(2);
            this.cbErPrHer2positive_TripplePositive.Name = "cbErPrHer2positive_TripplePositive";
            this.cbErPrHer2positive_TripplePositive.Size = new System.Drawing.Size(15, 14);
            this.cbErPrHer2positive_TripplePositive.TabIndex = 15;
            this.cbErPrHer2positive_TripplePositive.UseVisualStyleBackColor = true;
            this.cbErPrHer2positive_TripplePositive.CheckStateChanged += new System.EventHandler(this.cbErPrHer2positive_TripplePositive_CheckStateChanged);
            // 
            // lblErPrHer2Negative_TrippleNegative
            // 
            this.lblErPrHer2Negative_TrippleNegative.AutoSize = true;
            this.lblErPrHer2Negative_TrippleNegative.Location = new System.Drawing.Point(5, 79);
            this.lblErPrHer2Negative_TrippleNegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErPrHer2Negative_TrippleNegative.Name = "lblErPrHer2Negative_TrippleNegative";
            this.lblErPrHer2Negative_TrippleNegative.Size = new System.Drawing.Size(213, 13);
            this.lblErPrHer2Negative_TrippleNegative.TabIndex = 0;
            this.lblErPrHer2Negative_TrippleNegative.Text = "ER PR HER 2  Negative / Tripple Negative";
            // 
            // cbErPrHer2Negative_TrippleNegative
            // 
            this.cbErPrHer2Negative_TrippleNegative.AutoSize = true;
            this.cbErPrHer2Negative_TrippleNegative.Location = new System.Drawing.Point(221, 80);
            this.cbErPrHer2Negative_TrippleNegative.Margin = new System.Windows.Forms.Padding(2);
            this.cbErPrHer2Negative_TrippleNegative.Name = "cbErPrHer2Negative_TrippleNegative";
            this.cbErPrHer2Negative_TrippleNegative.Size = new System.Drawing.Size(15, 14);
            this.cbErPrHer2Negative_TrippleNegative.TabIndex = 14;
            this.cbErPrHer2Negative_TrippleNegative.UseVisualStyleBackColor = true;
            this.cbErPrHer2Negative_TrippleNegative.CheckStateChanged += new System.EventHandler(this.cbErPrHer2Negative_TrippleNegative_CheckStateChanged);
            // 
            // lblErNPrP
            // 
            this.lblErNPrP.AutoSize = true;
            this.lblErNPrP.Location = new System.Drawing.Point(725, 53);
            this.lblErNPrP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErNPrP.Name = "lblErNPrP";
            this.lblErNPrP.Size = new System.Drawing.Size(147, 13);
            this.lblErNPrP.TabIndex = 0;
            this.lblErNPrP.Text = "ER Negative and PR Positive";
            // 
            // cbErNegativePrPositive
            // 
            this.cbErNegativePrPositive.AutoSize = true;
            this.cbErNegativePrPositive.Location = new System.Drawing.Point(878, 53);
            this.cbErNegativePrPositive.Margin = new System.Windows.Forms.Padding(2);
            this.cbErNegativePrPositive.Name = "cbErNegativePrPositive";
            this.cbErNegativePrPositive.Size = new System.Drawing.Size(15, 14);
            this.cbErNegativePrPositive.TabIndex = 13;
            this.cbErNegativePrPositive.UseVisualStyleBackColor = true;
            this.cbErNegativePrPositive.CheckStateChanged += new System.EventHandler(this.cbErNegativePrPositive_CheckStateChanged);
            // 
            // cbErPositivePrNegative
            // 
            this.cbErPositivePrNegative.AutoSize = true;
            this.cbErPositivePrNegative.Location = new System.Drawing.Point(661, 53);
            this.cbErPositivePrNegative.Margin = new System.Windows.Forms.Padding(2);
            this.cbErPositivePrNegative.Name = "cbErPositivePrNegative";
            this.cbErPositivePrNegative.Size = new System.Drawing.Size(15, 14);
            this.cbErPositivePrNegative.TabIndex = 12;
            this.cbErPositivePrNegative.UseVisualStyleBackColor = true;
            this.cbErPositivePrNegative.CheckStateChanged += new System.EventHandler(this.cbErPositivePrNegative_CheckStateChanged);
            // 
            // lblErPPrN
            // 
            this.lblErPPrN.AutoSize = true;
            this.lblErPPrN.Location = new System.Drawing.Point(512, 53);
            this.lblErPPrN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErPPrN.Name = "lblErPPrN";
            this.lblErPPrN.Size = new System.Drawing.Size(147, 13);
            this.lblErPPrN.TabIndex = 0;
            this.lblErPPrN.Text = "ER Positive and PR Negative";
            // 
            // lblErandPrN
            // 
            this.lblErandPrN.AutoSize = true;
            this.lblErandPrN.Location = new System.Drawing.Point(362, 53);
            this.lblErandPrN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErandPrN.Name = "lblErandPrN";
            this.lblErandPrN.Size = new System.Drawing.Size(86, 13);
            this.lblErandPrN.TabIndex = 0;
            this.lblErandPrN.Text = "ER PR Negative";
            // 
            // cbErPrNegative
            // 
            this.cbErPrNegative.AutoSize = true;
            this.cbErPrNegative.Location = new System.Drawing.Point(454, 53);
            this.cbErPrNegative.Margin = new System.Windows.Forms.Padding(2);
            this.cbErPrNegative.Name = "cbErPrNegative";
            this.cbErPrNegative.Size = new System.Drawing.Size(15, 14);
            this.cbErPrNegative.TabIndex = 11;
            this.cbErPrNegative.UseVisualStyleBackColor = true;
            this.cbErPrNegative.CheckStateChanged += new System.EventHandler(this.cbErPrNegative_CheckStateChanged);
            // 
            // cbErPrPositive
            // 
            this.cbErPrPositive.AutoSize = true;
            this.cbErPrPositive.Location = new System.Drawing.Point(221, 53);
            this.cbErPrPositive.Margin = new System.Windows.Forms.Padding(2);
            this.cbErPrPositive.Name = "cbErPrPositive";
            this.cbErPrPositive.Size = new System.Drawing.Size(15, 14);
            this.cbErPrPositive.TabIndex = 10;
            this.cbErPrPositive.UseVisualStyleBackColor = true;
            this.cbErPrPositive.CheckStateChanged += new System.EventHandler(this.cbErPrPositive_CheckStateChanged);
            // 
            // lblErandPrP
            // 
            this.lblErandPrP.AutoSize = true;
            this.lblErandPrP.Location = new System.Drawing.Point(134, 53);
            this.lblErandPrP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErandPrP.Name = "lblErandPrP";
            this.lblErandPrP.Size = new System.Drawing.Size(80, 13);
            this.lblErandPrP.TabIndex = 0;
            this.lblErandPrP.Text = "ER PR Positive";
            // 
            // lblKi67
            // 
            this.lblKi67.AutoSize = true;
            this.lblKi67.Location = new System.Drawing.Point(482, 24);
            this.lblKi67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKi67.Name = "lblKi67";
            this.lblKi67.Size = new System.Drawing.Size(45, 13);
            this.lblKi67.TabIndex = 0;
            this.lblKi67.Text = "Ki67 (%)";
            // 
            // txtKi67
            // 
            this.txtKi67.AcceptsReturn = true;
            this.txtKi67.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKi67.Location = new System.Drawing.Point(542, 21);
            this.txtKi67.Margin = new System.Windows.Forms.Padding(2);
            this.txtKi67.Multiline = true;
            this.txtKi67.Name = "txtKi67";
            this.txtKi67.Size = new System.Drawing.Size(133, 21);
            this.txtKi67.TabIndex = 9;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(280, 24);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.AcceptsReturn = true;
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(327, 21);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrade.Multiline = true;
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(142, 21);
            this.txtGrade.TabIndex = 8;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(678, 24);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(197, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Initial Size on MRI / USG / Mammogram";
            // 
            // txtSize
            // 
            this.txtSize.AcceptsReturn = true;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(878, 21);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(56, 21);
            this.txtSize.TabIndex = 17;
            // 
            // lblNodalStatus
            // 
            this.lblNodalStatus.AutoSize = true;
            this.lblNodalStatus.Location = new System.Drawing.Point(8, 24);
            this.lblNodalStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNodalStatus.Name = "lblNodalStatus";
            this.lblNodalStatus.Size = new System.Drawing.Size(68, 13);
            this.lblNodalStatus.TabIndex = 0;
            this.lblNodalStatus.Text = "Nodal Status";
            // 
            // txtNodalStatus
            // 
            this.txtNodalStatus.AcceptsReturn = true;
            this.txtNodalStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodalStatus.Location = new System.Drawing.Point(86, 21);
            this.txtNodalStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodalStatus.Multiline = true;
            this.txtNodalStatus.Name = "txtNodalStatus";
            this.txtNodalStatus.Size = new System.Drawing.Size(150, 21);
            this.txtNodalStatus.TabIndex = 7;
            // 
            // btn_copy
            // 
            this.btn_copy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_copy.BackgroundImage")));
            this.btn_copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_copy.ImageKey = "(none)";
            this.btn_copy.Location = new System.Drawing.Point(128, 42);
            this.btn_copy.Margin = new System.Windows.Forms.Padding(2);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(22, 24);
            this.btn_copy.TabIndex = 14;
            this.btn_copy.Tag = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = global::EvaluationofNCinBC.Properties.Resources.cancer_png_22442;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new System.Drawing.Point(4, 15);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(47, 54);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnFullList
            // 
            this.btnFullList.BackColor = System.Drawing.Color.LightPink;
            this.btnFullList.Location = new System.Drawing.Point(869, 315);
            this.btnFullList.Margin = new System.Windows.Forms.Padding(2);
            this.btnFullList.Name = "btnFullList";
            this.btnFullList.Size = new System.Drawing.Size(71, 66);
            this.btnFullList.TabIndex = 31;
            this.btnFullList.Text = "Export to Excel";
            this.btnFullList.UseVisualStyleBackColor = false;
            this.btnFullList.Click += new System.EventHandler(this.btnFullList_Click);
            // 
            // dtSurgeryDate
            // 
            this.dtSurgeryDate.CustomFormat = "dd/MM/yyyy";
            this.dtSurgeryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSurgeryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSurgeryDate.Location = new System.Drawing.Point(672, 100);
            this.dtSurgeryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtSurgeryDate.Name = "dtSurgeryDate";
            this.dtSurgeryDate.Size = new System.Drawing.Size(93, 19);
            this.dtSurgeryDate.TabIndex = 26;
            // 
            // lbldtSurgery
            // 
            this.lbldtSurgery.AutoSize = true;
            this.lbldtSurgery.Location = new System.Drawing.Point(586, 103);
            this.lbldtSurgery.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldtSurgery.Name = "lbldtSurgery";
            this.lbldtSurgery.Size = new System.Drawing.Size(81, 13);
            this.lbldtSurgery.TabIndex = 27;
            this.lbldtSurgery.Text = "Date of Surgery";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(962, 866);
            this.Controls.Add(this.TbPatientInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gb_patientInfo.ResumeLayout(false);
            this.gb_patientInfo.PerformLayout();
            this.TbPatientInfo.ResumeLayout(false);
            this.tbpgPatientInfo.ResumeLayout(false);
            this.tbpgPatientInfo.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbTreatmentDetails.ResumeLayout(false);
            this.gbTreatmentDetails.PerformLayout();
            this.gb_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbChemoData.ResumeLayout(false);
            this.gbChemoData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_patientInfo;
        private System.Windows.Forms.TextBox txtMrn;
        private System.Windows.Forms.Label lblMrn;
        private System.Windows.Forms.Label lblDateofDia;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TabControl TbPatientInfo;
        private System.Windows.Forms.TabPage tbpgPatientInfo;
        private System.Windows.Forms.GroupBox gbChemoData;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblNodalStatus;
        private System.Windows.Forms.TextBox txtNodalStatus;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.CheckBox cbErPrPositive;
        private System.Windows.Forms.Label lblErandPrP;
        private System.Windows.Forms.Label lblKi67;
        private System.Windows.Forms.TextBox txtKi67;
        private System.Windows.Forms.Label lblErandPrN;
        private System.Windows.Forms.CheckBox cbErPrNegative;
        private System.Windows.Forms.Label lblErNPrP;
        private System.Windows.Forms.CheckBox cbErNegativePrPositive;
        private System.Windows.Forms.CheckBox cbErPositivePrNegative;
        private System.Windows.Forms.Label lblErPPrN;
        private System.Windows.Forms.Label lblErPrHer2Popsitive_TripplePositive;
        private System.Windows.Forms.CheckBox cbErPrHer2positive_TripplePositive;
        private System.Windows.Forms.Label lblErPrHer2Negative_TrippleNegative;
        private System.Windows.Forms.CheckBox cbErPrHer2Negative_TrippleNegative;
        private System.Windows.Forms.Label lblHarNegativeHer2Positive;
        private System.Windows.Forms.CheckBox cbTrpiPositive;
        private System.Windows.Forms.Label lblTypeofChemo;
        private System.Windows.Forms.TextBox txtTypeOfChemo;
        private System.Windows.Forms.TextBox txtSurgicalProcedure;
        private System.Windows.Forms.Label lblSurgicalProcedure;
        private System.Windows.Forms.TextBox txtPostNeo;
        private System.Windows.Forms.Label lblPostNeo;
        private GroupBox gb_Data;
        private DataGridView dataGridView1;
        private GroupBox gbTreatmentDetails;
        private TextBox txtNumberofChemoCycles;
        private Label lblNoofChemoCycles;
        private TextBox txtComments;
        private Label lblComments;
        private Button txtUpdate;
        private Button btnRefresh;
        private GroupBox gbSearch;
        private Button btn_copy;
        public DateTimePicker dtDiagnosisDate;
        private CheckBox cb_revisit;
        private CheckBox cb_discard;
        private CheckBox cbTrpiNegative;
        private Label lblHarmonePositiveHER2Negative;
        private Label lblPatientType;
        private ComboBox cmb_PatientType;
        private CheckBox cb_complete;
        private CheckBox cb_discardedrecords;
        private CheckBox cb_completedRecords;
        private CheckBox cb_RevisitedRecords;
        private CheckBox cb_new;
        private TextBox txtSearch;
        private Label lbl_MRNnumber;
        private CheckBox cb_allrecords;
        private TextBox txtPerChangeInSize;
        private Label lblPercentageChangeInSize;
        private TextBox txtPostTreatmentStaging;
        private Label lblPostTreatmentStaging;
        private ComboBox cmbDataFiles;
        private Label lblSelectFile;
        private Button btnSave;
        private Button btnFullList;
        public DateTimePicker dtSurgeryDate;
        private Label lbldtSurgery;
    }
}