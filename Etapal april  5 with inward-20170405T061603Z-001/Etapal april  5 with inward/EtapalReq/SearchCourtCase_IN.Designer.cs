namespace EtapalReq
{
    partial class SearchCourtCase_IN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLetterDetails = new System.Windows.Forms.Label();
            this.dataGridViewSearchCourt = new System.Windows.Forms.DataGridView();
            this.SlNoCourtSearchIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gl_No_Id_Court = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optInwardNo = new System.Windows.Forms.RadioButton();
            this.cbFinYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.optSubject = new System.Windows.Forms.RadioButton();
            this.radLetterNo = new System.Windows.Forms.RadioButton();
            this.optCourtCaseLetter = new System.Windows.Forms.RadioButton();
            this.optGLNo = new System.Windows.Forms.RadioButton();
            this.lblFinYearValue = new System.Windows.Forms.Label();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.grpNumber = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.lblDateBetween = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTodayDateValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGotoGovtLetterPagee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchCourt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpNumber.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(869, 121);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to home ";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(869, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblLetterDetails
            // 
            this.lblLetterDetails.AutoSize = true;
            this.lblLetterDetails.BackColor = System.Drawing.Color.Yellow;
            this.lblLetterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterDetails.ForeColor = System.Drawing.Color.Red;
            this.lblLetterDetails.Location = new System.Drawing.Point(270, 185);
            this.lblLetterDetails.Name = "lblLetterDetails";
            this.lblLetterDetails.Size = new System.Drawing.Size(0, 16);
            this.lblLetterDetails.TabIndex = 239;
            // 
            // dataGridViewSearchCourt
            // 
            this.dataGridViewSearchCourt.AllowUserToAddRows = false;
            this.dataGridViewSearchCourt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSearchCourt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchCourt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNoCourtSearchIN,
            this.Gl_No_Id_Court,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchCourt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSearchCourt.Location = new System.Drawing.Point(12, 211);
            this.dataGridViewSearchCourt.Name = "dataGridViewSearchCourt";
            this.dataGridViewSearchCourt.ReadOnly = true;
            this.dataGridViewSearchCourt.RowHeadersVisible = false;
            this.dataGridViewSearchCourt.RowTemplate.Height = 85;
            this.dataGridViewSearchCourt.Size = new System.Drawing.Size(1113, 365);
            this.dataGridViewSearchCourt.TabIndex = 245;
            this.dataGridViewSearchCourt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchCourt_CellContentClick);
            this.dataGridViewSearchCourt.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchCourt_CellEndEdit);
            // 
            // SlNoCourtSearchIN
            // 
            this.SlNoCourtSearchIN.HeaderText = "SlNo";
            this.SlNoCourtSearchIN.Name = "SlNoCourtSearchIN";
            this.SlNoCourtSearchIN.ReadOnly = true;
            this.SlNoCourtSearchIN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlNoCourtSearchIN.Width = 55;
            // 
            // Gl_No_Id_Court
            // 
            this.Gl_No_Id_Court.DataPropertyName = "GL_No_Id";
            this.Gl_No_Id_Court.HeaderText = "Gl No";
            this.Gl_No_Id_Court.Name = "Gl_No_Id_Court";
            this.Gl_No_Id_Court.ReadOnly = true;
            this.Gl_No_Id_Court.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gl_No_Id_Court.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Gl_No_Id_Court.Width = 55;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Letter_No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Letter No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Inward_No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inward No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FromDept";
            this.dataGridViewTextBoxColumn4.HeaderText = "From Dept";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "FromOffice";
            this.dataGridViewTextBoxColumn12.HeaderText = "FromOffice";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 83;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn6.HeaderText = " Subject";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 71;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ToSection";
            this.dataGridViewTextBoxColumn7.HeaderText = "To Section";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ToSubsection";
            this.dataGridViewTextBoxColumn8.HeaderText = "To Subsection";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 93;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ToCaseWorker";
            this.dataGridViewTextBoxColumn9.HeaderText = "To CaseWorker";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 98;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1006, 582);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 111);
            this.pictureBox1.TabIndex = 243;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSelectCategory.Location = new System.Drawing.Point(432, 6);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(266, 20);
            this.lblSelectCategory.TabIndex = 341;
            this.lblSelectCategory.Text = "SEARCH GENERAL LETTER\'S ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optInwardNo);
            this.groupBox1.Controls.Add(this.cbFinYear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.optSubject);
            this.groupBox1.Controls.Add(this.radLetterNo);
            this.groupBox1.Controls.Add(this.optCourtCaseLetter);
            this.groupBox1.Controls.Add(this.optGLNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(43, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 135);
            this.groupBox1.TabIndex = 339;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CourtCase";
            // 
            // optInwardNo
            // 
            this.optInwardNo.AutoSize = true;
            this.optInwardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInwardNo.ForeColor = System.Drawing.Color.Gray;
            this.optInwardNo.Location = new System.Drawing.Point(17, 107);
            this.optInwardNo.Name = "optInwardNo";
            this.optInwardNo.Size = new System.Drawing.Size(129, 20);
            this.optInwardNo.TabIndex = 290;
            this.optInwardNo.TabStop = true;
            this.optInwardNo.Text = "Inward Number";
            this.optInwardNo.UseVisualStyleBackColor = true;
            this.optInwardNo.CheckedChanged += new System.EventHandler(this.optInwardNo_CheckedChanged);
            // 
            // cbFinYear
            // 
            this.cbFinYear.BackColor = System.Drawing.Color.PowderBlue;
            this.cbFinYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinYear.FormattingEnabled = true;
            this.cbFinYear.Items.AddRange(new object[] {
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025"});
            this.cbFinYear.Location = new System.Drawing.Point(159, 26);
            this.cbFinYear.Name = "cbFinYear";
            this.cbFinYear.Size = new System.Drawing.Size(121, 26);
            this.cbFinYear.TabIndex = 289;
            this.cbFinYear.SelectedIndexChanged += new System.EventHandler(this.cbFinYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(-3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 288;
            this.label3.Text = "Select Financial Year";
            // 
            // optSubject
            // 
            this.optSubject.AutoSize = true;
            this.optSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSubject.ForeColor = System.Drawing.Color.Gray;
            this.optSubject.Location = new System.Drawing.Point(169, 62);
            this.optSubject.Name = "optSubject";
            this.optSubject.Size = new System.Drawing.Size(78, 20);
            this.optSubject.TabIndex = 97;
            this.optSubject.TabStop = true;
            this.optSubject.Text = "Subject";
            this.optSubject.UseVisualStyleBackColor = true;
            this.optSubject.CheckedChanged += new System.EventHandler(this.optSubject_CheckedChanged);
            // 
            // radLetterNo
            // 
            this.radLetterNo.AutoSize = true;
            this.radLetterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLetterNo.ForeColor = System.Drawing.Color.Gray;
            this.radLetterNo.Location = new System.Drawing.Point(18, 82);
            this.radLetterNo.Name = "radLetterNo";
            this.radLetterNo.Size = new System.Drawing.Size(123, 20);
            this.radLetterNo.TabIndex = 101;
            this.radLetterNo.TabStop = true;
            this.radLetterNo.Text = "Letter Number";
            this.radLetterNo.UseVisualStyleBackColor = true;
            this.radLetterNo.CheckedChanged += new System.EventHandler(this.radLetterNo_CheckedChanged);
            // 
            // optCourtCaseLetter
            // 
            this.optCourtCaseLetter.AutoSize = true;
            this.optCourtCaseLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCourtCaseLetter.ForeColor = System.Drawing.Color.Gray;
            this.optCourtCaseLetter.Location = new System.Drawing.Point(168, 87);
            this.optCourtCaseLetter.Name = "optCourtCaseLetter";
            this.optCourtCaseLetter.Size = new System.Drawing.Size(171, 20);
            this.optCourtCaseLetter.TabIndex = 90;
            this.optCourtCaseLetter.TabStop = true;
            this.optCourtCaseLetter.Text = "All CourtCase Letters";
            this.optCourtCaseLetter.UseVisualStyleBackColor = true;
            this.optCourtCaseLetter.CheckedChanged += new System.EventHandler(this.optCourtCaseLetter_CheckedChanged);
            // 
            // optGLNo
            // 
            this.optGLNo.AutoSize = true;
            this.optGLNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGLNo.ForeColor = System.Drawing.Color.Gray;
            this.optGLNo.Location = new System.Drawing.Point(18, 56);
            this.optGLNo.Name = "optGLNo";
            this.optGLNo.Size = new System.Drawing.Size(103, 20);
            this.optGLNo.TabIndex = 96;
            this.optGLNo.TabStop = true;
            this.optGLNo.Text = "GL Number";
            this.optGLNo.UseVisualStyleBackColor = true;
            this.optGLNo.CheckedChanged += new System.EventHandler(this.optGLNo_CheckedChanged);
            // 
            // lblFinYearValue
            // 
            this.lblFinYearValue.AutoSize = true;
            this.lblFinYearValue.BackColor = System.Drawing.Color.White;
            this.lblFinYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinYearValue.ForeColor = System.Drawing.Color.Gray;
            this.lblFinYearValue.Location = new System.Drawing.Point(171, 9);
            this.lblFinYearValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinYearValue.Name = "lblFinYearValue";
            this.lblFinYearValue.Size = new System.Drawing.Size(0, 16);
            this.lblFinYearValue.TabIndex = 338;
            // 
            // lblFinancialYear
            // 
            this.lblFinancialYear.AutoSize = true;
            this.lblFinancialYear.BackColor = System.Drawing.Color.White;
            this.lblFinancialYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialYear.ForeColor = System.Drawing.Color.Gray;
            this.lblFinancialYear.Location = new System.Drawing.Point(32, 6);
            this.lblFinancialYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancialYear.Name = "lblFinancialYear";
            this.lblFinancialYear.Size = new System.Drawing.Size(120, 16);
            this.lblFinancialYear.TabIndex = 337;
            this.lblFinancialYear.Text = "Financial Year : ";
            // 
            // grpNumber
            // 
            this.grpNumber.Controls.Add(this.lblNumber);
            this.grpNumber.Controls.Add(this.txtSearch);
            this.grpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpNumber.Location = new System.Drawing.Point(504, 46);
            this.grpNumber.Name = "grpNumber";
            this.grpNumber.Size = new System.Drawing.Size(345, 125);
            this.grpNumber.TabIndex = 336;
            this.grpNumber.TabStop = false;
            this.grpNumber.Text = "Enter Value";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNumber.Location = new System.Drawing.Point(30, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 16);
            this.lblNumber.TabIndex = 100;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.PowderBlue;
            this.txtSearch.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(34, 53);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearch.Size = new System.Drawing.Size(246, 56);
            this.txtSearch.TabIndex = 1;
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.lblDateBetween);
            this.grpDate.Controls.Add(this.label2);
            this.grpDate.Controls.Add(this.dateTimePickerFromDate);
            this.grpDate.Controls.Add(this.lblFromDate);
            this.grpDate.Controls.Add(this.lblToDate);
            this.grpDate.Controls.Add(this.dateTimePickerToDate);
            this.grpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.grpDate.Location = new System.Drawing.Point(446, 44);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(417, 127);
            this.grpDate.TabIndex = 335;
            this.grpDate.TabStop = false;
            this.grpDate.Text = "CourtCase";
            // 
            // lblDateBetween
            // 
            this.lblDateBetween.AutoSize = true;
            this.lblDateBetween.BackColor = System.Drawing.Color.Red;
            this.lblDateBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBetween.ForeColor = System.Drawing.Color.White;
            this.lblDateBetween.Location = new System.Drawing.Point(172, 29);
            this.lblDateBetween.Name = "lblDateBetween";
            this.lblDateBetween.Size = new System.Drawing.Size(0, 16);
            this.lblDateBetween.TabIndex = 288;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 287;
            this.label2.Text = "Select Date Between :";
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(125, 62);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(265, 24);
            this.dateTimePickerFromDate.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.Gray;
            this.lblFromDate.Location = new System.Drawing.Point(12, 61);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(80, 16);
            this.lblFromDate.TabIndex = 285;
            this.lblFromDate.Text = "From Date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.Gray;
            this.lblToDate.Location = new System.Drawing.Point(12, 97);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(64, 16);
            this.lblToDate.TabIndex = 286;
            this.lblToDate.Text = "To Date";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToDate.Location = new System.Drawing.Point(125, 97);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(265, 24);
            this.dateTimePickerToDate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(479, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 334;
            // 
            // lblTodayDateValue
            // 
            this.lblTodayDateValue.AutoSize = true;
            this.lblTodayDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDateValue.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDateValue.Location = new System.Drawing.Point(1092, 13);
            this.lblTodayDateValue.Name = "lblTodayDateValue";
            this.lblTodayDateValue.Size = new System.Drawing.Size(0, 16);
            this.lblTodayDateValue.TabIndex = 343;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(915, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 16);
            this.label4.TabIndex = 342;
            this.label4.Text = "Today Date and Time : ";
            // 
            // btnGotoGovtLetterPagee
            // 
            this.btnGotoGovtLetterPagee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGotoGovtLetterPagee.ForeColor = System.Drawing.Color.Gray;
            this.btnGotoGovtLetterPagee.Location = new System.Drawing.Point(1049, 65);
            this.btnGotoGovtLetterPagee.Name = "btnGotoGovtLetterPagee";
            this.btnGotoGovtLetterPagee.Size = new System.Drawing.Size(136, 76);
            this.btnGotoGovtLetterPagee.TabIndex = 485;
            this.btnGotoGovtLetterPagee.Text = "Go to Search Govt Letter\'s Page";
            this.btnGotoGovtLetterPagee.UseVisualStyleBackColor = true;
            this.btnGotoGovtLetterPagee.Click += new System.EventHandler(this.btnGotoGovtLetterPagee_Click);
            // 
            // SearchCourtCase_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 510);
            this.Controls.Add(this.btnGotoGovtLetterPagee);
            this.Controls.Add(this.lblTodayDateValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFinYearValue);
            this.Controls.Add(this.lblFinancialYear);
            this.Controls.Add(this.grpNumber);
            this.Controls.Add(this.grpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSearchCourt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLetterDetails);
            this.Controls.Add(this.btnSearch);
            this.Name = "SearchCourtCase_IN";
            this.Text = "SearchCourtCase_IN";
            this.Load += new System.EventHandler(this.SearchCourtCase_IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchCourt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpNumber.ResumeLayout(false);
            this.grpNumber.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLetterDetails;
        private System.Windows.Forms.DataGridView dataGridViewSearchCourt;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFinYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton optSubject;
        private System.Windows.Forms.RadioButton radLetterNo;
        private System.Windows.Forms.RadioButton optCourtCaseLetter;
        private System.Windows.Forms.RadioButton optGLNo;
        private System.Windows.Forms.Label lblFinYearValue;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.GroupBox grpNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpDate;
        private System.Windows.Forms.Label lblDateBetween;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTodayDateValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optInwardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNoCourtSearchIN;
        private System.Windows.Forms.DataGridViewLinkColumn Gl_No_Id_Court;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnGotoGovtLetterPagee;
    }
}