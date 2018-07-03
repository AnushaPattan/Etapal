namespace EtapalReq
{
    partial class CaseWorkerWO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearchCaseWorker = new System.Windows.Forms.Button();
            this.radDOLetter = new System.Windows.Forms.RadioButton();
            this.radGovtLetter = new System.Windows.Forms.RadioButton();
            this.radRightToInformationLetter = new System.Windows.Forms.RadioButton();
            this.radCourtCaseLetter = new System.Windows.Forms.RadioButton();
            this.radGeneralLetter = new System.Windows.Forms.RadioButton();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.lblSelectSection = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.ddlCaseWorker = new System.Windows.Forms.ComboBox();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.lblSelectCaseWorker = new System.Windows.Forms.Label();
            this.optLokayuktaLetter = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLetterDetails = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.SlNob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applicant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SlNoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCaseWorker
            // 
            this.btnSearchCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchCaseWorker.Location = new System.Drawing.Point(597, 89);
            this.btnSearchCaseWorker.Name = "btnSearchCaseWorker";
            this.btnSearchCaseWorker.Size = new System.Drawing.Size(86, 32);
            this.btnSearchCaseWorker.TabIndex = 1;
            this.btnSearchCaseWorker.Text = "Search";
            this.btnSearchCaseWorker.UseVisualStyleBackColor = true;
            this.btnSearchCaseWorker.Click += new System.EventHandler(this.btnSearchCaseWorker_Click);
            // 
            // radDOLetter
            // 
            this.radDOLetter.AutoSize = true;
            this.radDOLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDOLetter.ForeColor = System.Drawing.Color.Gray;
            this.radDOLetter.Location = new System.Drawing.Point(350, 11);
            this.radDOLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radDOLetter.Name = "radDOLetter";
            this.radDOLetter.Size = new System.Drawing.Size(99, 22);
            this.radDOLetter.TabIndex = 212;
            this.radDOLetter.TabStop = true;
            this.radDOLetter.Text = "DO Letter";
            this.radDOLetter.UseVisualStyleBackColor = true;
            this.radDOLetter.CheckedChanged += new System.EventHandler(this.radDOLetter_CheckedChanged);
            // 
            // radGovtLetter
            // 
            this.radGovtLetter.AutoSize = true;
            this.radGovtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGovtLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGovtLetter.Location = new System.Drawing.Point(836, 11);
            this.radGovtLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGovtLetter.Name = "radGovtLetter";
            this.radGovtLetter.Size = new System.Drawing.Size(166, 22);
            this.radGovtLetter.TabIndex = 211;
            this.radGovtLetter.TabStop = true;
            this.radGovtLetter.Text = "Government Letter";
            this.radGovtLetter.UseVisualStyleBackColor = true;
            this.radGovtLetter.CheckedChanged += new System.EventHandler(this.radGovtLetter_CheckedChanged);
            // 
            // radRightToInformationLetter
            // 
            this.radRightToInformationLetter.AutoSize = true;
            this.radRightToInformationLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRightToInformationLetter.ForeColor = System.Drawing.Color.Gray;
            this.radRightToInformationLetter.Location = new System.Drawing.Point(570, 44);
            this.radRightToInformationLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radRightToInformationLetter.Name = "radRightToInformationLetter";
            this.radRightToInformationLetter.Size = new System.Drawing.Size(228, 22);
            this.radRightToInformationLetter.TabIndex = 210;
            this.radRightToInformationLetter.TabStop = true;
            this.radRightToInformationLetter.Text = "Right To Information Letter";
            this.radRightToInformationLetter.UseVisualStyleBackColor = true;
            this.radRightToInformationLetter.CheckedChanged += new System.EventHandler(this.radRightToInformationLetter_CheckedChanged);
            // 
            // radCourtCaseLetter
            // 
            this.radCourtCaseLetter.AutoSize = true;
            this.radCourtCaseLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCourtCaseLetter.ForeColor = System.Drawing.Color.Gray;
            this.radCourtCaseLetter.Location = new System.Drawing.Point(570, 13);
            this.radCourtCaseLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radCourtCaseLetter.Name = "radCourtCaseLetter";
            this.radCourtCaseLetter.Size = new System.Drawing.Size(160, 22);
            this.radCourtCaseLetter.TabIndex = 209;
            this.radCourtCaseLetter.TabStop = true;
            this.radCourtCaseLetter.Text = "Court Case Letter";
            this.radCourtCaseLetter.UseVisualStyleBackColor = true;
            this.radCourtCaseLetter.CheckedChanged += new System.EventHandler(this.radCourtCaseLetter_CheckedChanged);
            // 
            // radGeneralLetter
            // 
            this.radGeneralLetter.AutoSize = true;
            this.radGeneralLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGeneralLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGeneralLetter.Location = new System.Drawing.Point(349, 41);
            this.radGeneralLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGeneralLetter.Name = "radGeneralLetter";
            this.radGeneralLetter.Size = new System.Drawing.Size(133, 22);
            this.radGeneralLetter.TabIndex = 208;
            this.radGeneralLetter.TabStop = true;
            this.radGeneralLetter.Text = "General Letter";
            this.radGeneralLetter.UseVisualStyleBackColor = true;
            this.radGeneralLetter.CheckedChanged += new System.EventHandler(this.radGeneralLetter_CheckedChanged);
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCategory.Location = new System.Drawing.Point(50, 9);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(250, 24);
            this.lblSelectCategory.TabIndex = 207;
            this.lblSelectCategory.Text = "SELECT CATEGORY     : ";
            // 
            // lblSelectSection
            // 
            this.lblSelectSection.AutoSize = true;
            this.lblSelectSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSection.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectSection.Location = new System.Drawing.Point(108, 89);
            this.lblSelectSection.Name = "lblSelectSection";
            this.lblSelectSection.Size = new System.Drawing.Size(117, 18);
            this.lblSelectSection.TabIndex = 198;
            this.lblSelectSection.Text = "Select Section";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Gray;
            this.btnPrint.Location = new System.Drawing.Point(597, 136);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 32);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ddlCaseWorker
            // 
            this.ddlCaseWorker.DropDownHeight = 80;
            this.ddlCaseWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCaseWorker.FormattingEnabled = true;
            this.ddlCaseWorker.IntegralHeight = false;
            this.ddlCaseWorker.Location = new System.Drawing.Point(287, 134);
            this.ddlCaseWorker.MaxDropDownItems = 5;
            this.ddlCaseWorker.Name = "ddlCaseWorker";
            this.ddlCaseWorker.Size = new System.Drawing.Size(263, 32);
            this.ddlCaseWorker.TabIndex = 201;
            // 
            // ddlSection
            // 
            this.ddlSection.DropDownHeight = 80;
            this.ddlSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.IntegralHeight = false;
            this.ddlSection.Location = new System.Drawing.Point(287, 86);
            this.ddlSection.MaxDropDownItems = 5;
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(263, 32);
            this.ddlSection.TabIndex = 200;
            // 
            // lblSelectCaseWorker
            // 
            this.lblSelectCaseWorker.AutoSize = true;
            this.lblSelectCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCaseWorker.Location = new System.Drawing.Point(108, 141);
            this.lblSelectCaseWorker.Name = "lblSelectCaseWorker";
            this.lblSelectCaseWorker.Size = new System.Drawing.Size(155, 18);
            this.lblSelectCaseWorker.TabIndex = 199;
            this.lblSelectCaseWorker.Text = "Select CaseWorker";
            // 
            // optLokayuktaLetter
            // 
            this.optLokayuktaLetter.AutoSize = true;
            this.optLokayuktaLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLokayuktaLetter.ForeColor = System.Drawing.Color.Gray;
            this.optLokayuktaLetter.Location = new System.Drawing.Point(836, 44);
            this.optLokayuktaLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optLokayuktaLetter.Name = "optLokayuktaLetter";
            this.optLokayuktaLetter.Size = new System.Drawing.Size(188, 22);
            this.optLokayuktaLetter.TabIndex = 217;
            this.optLokayuktaLetter.TabStop = true;
            this.optLokayuktaLetter.Text = "Lokayukta/ABS Letter";
            this.optLokayuktaLetter.UseVisualStyleBackColor = true;
            this.optLokayuktaLetter.CheckedChanged += new System.EventHandler(this.optLokayuktaLetter_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(712, 89);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Report";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackHome
            // 
            this.btnBackHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.Gray;
            this.btnBackHome.Location = new System.Drawing.Point(712, 136);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(135, 32);
            this.btnBackHome.TabIndex = 4;
            this.btnBackHome.Text = "Back to Home";
            this.btnBackHome.UseVisualStyleBackColor = true;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1080, 622);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 137);
            this.pictureBox1.TabIndex = 206;
            this.pictureBox1.TabStop = false;
            // 
            // lblLetterDetails
            // 
            this.lblLetterDetails.AutoSize = true;
            this.lblLetterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblLetterDetails.Location = new System.Drawing.Point(449, 186);
            this.lblLetterDetails.Name = "lblLetterDetails";
            this.lblLetterDetails.Size = new System.Drawing.Size(0, 16);
            this.lblLetterDetails.TabIndex = 263;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNob,
            this.dataGridViewLinkColumn4,
            this.Applicant_Name,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView5.Location = new System.Drawing.Point(91, 259);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 35;
            this.dataGridView5.RowTemplate.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(846, 302);
            this.dataGridView5.TabIndex = 265;
            this.dataGridView5.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView5_RowPostPaint);
            // 
            // SlNob
            // 
            this.SlNob.HeaderText = "SlNo";
            this.SlNob.Name = "SlNob";
            this.SlNob.ReadOnly = true;
            this.SlNob.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlNob.Width = 55;
            // 
            // dataGridViewLinkColumn4
            // 
            this.dataGridViewLinkColumn4.DataPropertyName = "Gl_No_Id";
            this.dataGridViewLinkColumn4.HeaderText = "GL No";
            this.dataGridViewLinkColumn4.Name = "dataGridViewLinkColumn4";
            this.dataGridViewLinkColumn4.ReadOnly = true;
            this.dataGridViewLinkColumn4.Width = 75;
            // 
            // Applicant_Name
            // 
            this.Applicant_Name.DataPropertyName = "Applicant_Name";
            this.Applicant_Name.HeaderText = "Applicant Name";
            this.Applicant_Name.MinimumWidth = 20;
            this.Applicant_Name.Name = "Applicant_Name";
            this.Applicant_Name.ReadOnly = true;
            this.Applicant_Name.Width = 120;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Letter_No";
            this.dataGridViewTextBoxColumn43.HeaderText = "Letter No";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 80;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "Subject";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn48.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn48.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Width = 140;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "ToSection";
            this.dataGridViewTextBoxColumn49.HeaderText = "Section";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Width = 80;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "ToCaseWorker";
            this.dataGridViewTextBoxColumn51.HeaderText = "CaseWorker";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 90;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Signature";
            this.dataGridViewTextBoxColumn52.HeaderText = " Signature and   Date ";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNoa,
            this.dataGridViewLinkColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(91, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 35;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(924, 346);
            this.dataGridView2.TabIndex = 264;
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint_1);
            // 
            // SlNoa
            // 
            this.SlNoa.HeaderText = "Sl No";
            this.SlNoa.Name = "SlNoa";
            this.SlNoa.Width = 50;
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.DataPropertyName = "Gl_No_Id";
            this.dataGridViewLinkColumn1.HeaderText = "GL No";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FromDept";
            this.dataGridViewTextBoxColumn7.HeaderText = "From Dept";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Letter_No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Letter No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Subject";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn9.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ToSection";
            this.dataGridViewTextBoxColumn10.HeaderText = "Section";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ToCaseWorker";
            this.dataGridViewTextBoxColumn12.HeaderText = "CaseWorker";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // CaseWorkerWO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 506);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lblLetterDetails);
            this.Controls.Add(this.btnBackHome);
            this.Controls.Add(this.optLokayuktaLetter);
            this.Controls.Add(this.btnSearchCaseWorker);
            this.Controls.Add(this.radDOLetter);
            this.Controls.Add(this.radGovtLetter);
            this.Controls.Add(this.radRightToInformationLetter);
            this.Controls.Add(this.radCourtCaseLetter);
            this.Controls.Add(this.radGeneralLetter);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.lblSelectSection);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ddlCaseWorker);
            this.Controls.Add(this.ddlSection);
            this.Controls.Add(this.lblSelectCaseWorker);
            this.Name = "CaseWorkerWO";
            this.Text = "CaseWorkerWO";
            this.Load += new System.EventHandler(this.CaseWorkerWO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCaseWorker;
        private System.Windows.Forms.RadioButton radDOLetter;
        private System.Windows.Forms.RadioButton radGovtLetter;
        private System.Windows.Forms.RadioButton radRightToInformationLetter;
        private System.Windows.Forms.RadioButton radCourtCaseLetter;
        private System.Windows.Forms.RadioButton radGeneralLetter;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.Label lblSelectSection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox ddlCaseWorker;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label lblSelectCaseWorker;
        private System.Windows.Forms.RadioButton optLokayuktaLetter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Label lblLetterDetails;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNob;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewLinkColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicant_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

    }
}