namespace EtapalReq
{
    partial class SearchNew
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
            this.optDOLetter = new System.Windows.Forms.RadioButton();
            this.optGeneralLetter = new System.Windows.Forms.RadioButton();
            this.optCourtCaseLetter = new System.Windows.Forms.RadioButton();
            this.optRightToInformationLetter = new System.Windows.Forms.RadioButton();
            this.optGLNo = new System.Windows.Forms.RadioButton();
            this.optInwardNo = new System.Windows.Forms.RadioButton();
            this.optSubject = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblLetterDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radSurveyNumber = new System.Windows.Forms.RadioButton();
            this.radLetterNo = new System.Windows.Forms.RadioButton();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GlNo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Inward_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DO_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.General_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Court_Case_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Right_To_Info_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSubSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCaseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applicant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Survey_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Government_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hobli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Village = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // optDOLetter
            // 
            this.optDOLetter.AutoSize = true;
            this.optDOLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDOLetter.ForeColor = System.Drawing.Color.Gray;
            this.optDOLetter.Location = new System.Drawing.Point(112, 53);
            this.optDOLetter.Name = "optDOLetter";
            this.optDOLetter.Size = new System.Drawing.Size(91, 20);
            this.optDOLetter.TabIndex = 4;
            this.optDOLetter.TabStop = true;
            this.optDOLetter.Text = "DO Letter";
            this.optDOLetter.UseVisualStyleBackColor = true;
            this.optDOLetter.CheckedChanged += new System.EventHandler(this.optDOLetter_CheckedChanged);
            // 
            // optGeneralLetter
            // 
            this.optGeneralLetter.AutoSize = true;
            this.optGeneralLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGeneralLetter.ForeColor = System.Drawing.Color.Gray;
            this.optGeneralLetter.Location = new System.Drawing.Point(264, 53);
            this.optGeneralLetter.Name = "optGeneralLetter";
            this.optGeneralLetter.Size = new System.Drawing.Size(124, 20);
            this.optGeneralLetter.TabIndex = 2;
            this.optGeneralLetter.TabStop = true;
            this.optGeneralLetter.Text = "General Letter";
            this.optGeneralLetter.UseVisualStyleBackColor = true;
            this.optGeneralLetter.CheckedChanged += new System.EventHandler(this.optGeneralLetter_CheckedChanged);
            // 
            // optCourtCaseLetter
            // 
            this.optCourtCaseLetter.AutoSize = true;
            this.optCourtCaseLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCourtCaseLetter.ForeColor = System.Drawing.Color.Gray;
            this.optCourtCaseLetter.Location = new System.Drawing.Point(455, 53);
            this.optCourtCaseLetter.Name = "optCourtCaseLetter";
            this.optCourtCaseLetter.Size = new System.Drawing.Size(145, 20);
            this.optCourtCaseLetter.TabIndex = 6;
            this.optCourtCaseLetter.TabStop = true;
            this.optCourtCaseLetter.Text = "Court Case Letter";
            this.optCourtCaseLetter.UseVisualStyleBackColor = true;
            this.optCourtCaseLetter.CheckedChanged += new System.EventHandler(this.optCourtCaseLetter_CheckedChanged);
            // 
            // optRightToInformationLetter
            // 
            this.optRightToInformationLetter.AutoSize = true;
            this.optRightToInformationLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optRightToInformationLetter.ForeColor = System.Drawing.Color.Gray;
            this.optRightToInformationLetter.Location = new System.Drawing.Point(633, 53);
            this.optRightToInformationLetter.Name = "optRightToInformationLetter";
            this.optRightToInformationLetter.Size = new System.Drawing.Size(208, 20);
            this.optRightToInformationLetter.TabIndex = 7;
            this.optRightToInformationLetter.TabStop = true;
            this.optRightToInformationLetter.Text = "Right To Information Letter";
            this.optRightToInformationLetter.UseVisualStyleBackColor = true;
            this.optRightToInformationLetter.CheckedChanged += new System.EventHandler(this.optRightToInformationLetter_CheckedChanged);
            // 
            // optGLNo
            // 
            this.optGLNo.AutoSize = true;
            this.optGLNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGLNo.ForeColor = System.Drawing.Color.Gray;
            this.optGLNo.Location = new System.Drawing.Point(112, 112);
            this.optGLNo.Name = "optGLNo";
            this.optGLNo.Size = new System.Drawing.Size(103, 20);
            this.optGLNo.TabIndex = 8;
            this.optGLNo.TabStop = true;
            this.optGLNo.Text = "GL Number";
            this.optGLNo.UseVisualStyleBackColor = true;
            this.optGLNo.CheckedChanged += new System.EventHandler(this.optGLNo_CheckedChanged);
            // 
            // optInwardNo
            // 
            this.optInwardNo.AutoSize = true;
            this.optInwardNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInwardNo.ForeColor = System.Drawing.Color.Gray;
            this.optInwardNo.Location = new System.Drawing.Point(264, 112);
            this.optInwardNo.Name = "optInwardNo";
            this.optInwardNo.Size = new System.Drawing.Size(129, 20);
            this.optInwardNo.TabIndex = 9;
            this.optInwardNo.TabStop = true;
            this.optInwardNo.Text = "Inward Number";
            this.optInwardNo.UseVisualStyleBackColor = true;
            this.optInwardNo.CheckedChanged += new System.EventHandler(this.optInwardNo_CheckedChanged);
            // 
            // optSubject
            // 
            this.optSubject.AutoSize = true;
            this.optSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSubject.ForeColor = System.Drawing.Color.Gray;
            this.optSubject.Location = new System.Drawing.Point(775, 112);
            this.optSubject.Name = "optSubject";
            this.optSubject.Size = new System.Drawing.Size(78, 20);
            this.optSubject.TabIndex = 10;
            this.optSubject.TabStop = true;
            this.optSubject.Text = "Subject";
            this.optSubject.UseVisualStyleBackColor = true;
            this.optSubject.CheckedChanged += new System.EventHandler(this.optSubject_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(112, 172);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(455, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(596, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.GlNo,
            this.Inward_No,
            this.Letter_No,
            this.FromDept,
            this.Other_Dept,
            this.Subject,
            this.DO_Letter,
            this.General_Letter,
            this.Court_Case_Letter,
            this.Right_To_Info_Letter,
            this.Received_Date,
            this.Letter_Date,
            this.FromOffice,
            this.ToSection,
            this.ToSubSection,
            this.ToCaseWorker,
            this.Applicant_Name,
            this.Survey_No,
            this.Signature,
            this.Government_Letter,
            this.Hobli,
            this.Village});
            this.dataGridView1.Location = new System.Drawing.Point(26, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 265);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // lblLetterDetails
            // 
            this.lblLetterDetails.AutoSize = true;
            this.lblLetterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterDetails.ForeColor = System.Drawing.Color.Gray;
            this.lblLetterDetails.Location = new System.Drawing.Point(290, 221);
            this.lblLetterDetails.Name = "lblLetterDetails";
            this.lblLetterDetails.Size = new System.Drawing.Size(0, 16);
            this.lblLetterDetails.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1080, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 137);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // radSurveyNumber
            // 
            this.radSurveyNumber.AutoSize = true;
            this.radSurveyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSurveyNumber.ForeColor = System.Drawing.Color.Gray;
            this.radSurveyNumber.Location = new System.Drawing.Point(455, 112);
            this.radSurveyNumber.Name = "radSurveyNumber";
            this.radSurveyNumber.Size = new System.Drawing.Size(132, 20);
            this.radSurveyNumber.TabIndex = 51;
            this.radSurveyNumber.TabStop = true;
            this.radSurveyNumber.Text = "Survey Number";
            this.radSurveyNumber.UseVisualStyleBackColor = true;
            // 
            // radLetterNo
            // 
            this.radLetterNo.AutoSize = true;
            this.radLetterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLetterNo.ForeColor = System.Drawing.Color.Gray;
            this.radLetterNo.Location = new System.Drawing.Point(633, 112);
            this.radLetterNo.Name = "radLetterNo";
            this.radLetterNo.Size = new System.Drawing.Size(123, 20);
            this.radLetterNo.TabIndex = 52;
            this.radLetterNo.TabStop = true;
            this.radLetterNo.Text = "Letter Number";
            this.radLetterNo.UseVisualStyleBackColor = true;
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlNo.Width = 40;
            // 
            // GlNo
            // 
            this.GlNo.DataPropertyName = "Gl_No";
            this.GlNo.HeaderText = "Gl No";
            this.GlNo.Name = "GlNo";
            this.GlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Inward_No
            // 
            this.Inward_No.DataPropertyName = "Inward_No";
            this.Inward_No.HeaderText = "Inward No";
            this.Inward_No.Name = "Inward_No";
            // 
            // Letter_No
            // 
            this.Letter_No.DataPropertyName = "Letter_No";
            this.Letter_No.HeaderText = "Letter No";
            this.Letter_No.Name = "Letter_No";
            // 
            // FromDept
            // 
            this.FromDept.DataPropertyName = "FromDept";
            this.FromDept.HeaderText = "From Dept";
            this.FromDept.Name = "FromDept";
            this.FromDept.Width = 150;
            // 
            // Other_Dept
            // 
            this.Other_Dept.DataPropertyName = "Other_Dept";
            this.Other_Dept.HeaderText = "Other Dept";
            this.Other_Dept.Name = "Other_Dept";
            this.Other_Dept.Width = 150;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 300;
            // 
            // DO_Letter
            // 
            this.DO_Letter.DataPropertyName = "DO_Letter";
            this.DO_Letter.HeaderText = "DO_Letter";
            this.DO_Letter.Name = "DO_Letter";
            this.DO_Letter.Visible = false;
            // 
            // General_Letter
            // 
            this.General_Letter.DataPropertyName = "General_Letter";
            this.General_Letter.HeaderText = "General_Letter";
            this.General_Letter.Name = "General_Letter";
            this.General_Letter.Visible = false;
            // 
            // Court_Case_Letter
            // 
            this.Court_Case_Letter.DataPropertyName = "Court_Case_Letter";
            this.Court_Case_Letter.HeaderText = "Court_Case_Letter";
            this.Court_Case_Letter.Name = "Court_Case_Letter";
            this.Court_Case_Letter.Visible = false;
            // 
            // Right_To_Info_Letter
            // 
            this.Right_To_Info_Letter.DataPropertyName = "Right_To_Info_Letter";
            this.Right_To_Info_Letter.HeaderText = "Right_To_Info_Letter";
            this.Right_To_Info_Letter.Name = "Right_To_Info_Letter";
            this.Right_To_Info_Letter.Visible = false;
            // 
            // Received_Date
            // 
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received_Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.Visible = false;
            // 
            // Letter_Date
            // 
            this.Letter_Date.DataPropertyName = "Letter_Date";
            this.Letter_Date.HeaderText = "Letter_Date";
            this.Letter_Date.Name = "Letter_Date";
            this.Letter_Date.Visible = false;
            // 
            // FromOffice
            // 
            this.FromOffice.DataPropertyName = "FromOffice";
            this.FromOffice.HeaderText = "FromOffice";
            this.FromOffice.Name = "FromOffice";
            this.FromOffice.Visible = false;
            // 
            // ToSection
            // 
            this.ToSection.DataPropertyName = "ToSection";
            this.ToSection.HeaderText = "ToSection";
            this.ToSection.Name = "ToSection";
            this.ToSection.Visible = false;
            // 
            // ToSubSection
            // 
            this.ToSubSection.DataPropertyName = "ToSubSection";
            this.ToSubSection.HeaderText = "ToSubSection";
            this.ToSubSection.Name = "ToSubSection";
            this.ToSubSection.Visible = false;
            // 
            // ToCaseWorker
            // 
            this.ToCaseWorker.DataPropertyName = "ToCaseWorker";
            this.ToCaseWorker.HeaderText = "ToCaseWorker";
            this.ToCaseWorker.Name = "ToCaseWorker";
            this.ToCaseWorker.Visible = false;
            // 
            // Applicant_Name
            // 
            this.Applicant_Name.DataPropertyName = "Applicant_Name";
            this.Applicant_Name.HeaderText = "Applicant Name";
            this.Applicant_Name.Name = "Applicant_Name";
            // 
            // Survey_No
            // 
            this.Survey_No.DataPropertyName = "Survey_No";
            this.Survey_No.HeaderText = "Survey No";
            this.Survey_No.Name = "Survey_No";
            // 
            // Signature
            // 
            this.Signature.DataPropertyName = "Signature";
            this.Signature.HeaderText = "Signature";
            this.Signature.Name = "Signature";
            this.Signature.Visible = false;
            // 
            // Government_Letter
            // 
            this.Government_Letter.DataPropertyName = "Government_Letter";
            this.Government_Letter.HeaderText = "Government Letter";
            this.Government_Letter.Name = "Government_Letter";
            this.Government_Letter.Visible = false;
            // 
            // Hobli
            // 
            this.Hobli.DataPropertyName = "Hobli";
            this.Hobli.HeaderText = "Hobli";
            this.Hobli.Name = "Hobli";
            this.Hobli.Visible = false;
            // 
            // Village
            // 
            this.Village.DataPropertyName = "Village";
            this.Village.HeaderText = "Village";
            this.Village.Name = "Village";
            this.Village.Visible = false;
            // 
            // SearchNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1256, 529);
            this.Controls.Add(this.radLetterNo);
            this.Controls.Add(this.radSurveyNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLetterDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.optSubject);
            this.Controls.Add(this.optInwardNo);
            this.Controls.Add(this.optGLNo);
            this.Controls.Add(this.optRightToInformationLetter);
            this.Controls.Add(this.optCourtCaseLetter);
            this.Controls.Add(this.optGeneralLetter);
            this.Controls.Add(this.optDOLetter);
            this.Name = "SearchNew";
            this.Text = "SearchNew";
            this.Load += new System.EventHandler(this.SearchNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optDOLetter;
        private System.Windows.Forms.RadioButton optGeneralLetter;
        private System.Windows.Forms.RadioButton optCourtCaseLetter;
        private System.Windows.Forms.RadioButton optRightToInformationLetter;
        private System.Windows.Forms.RadioButton optGLNo;
        private System.Windows.Forms.RadioButton optInwardNo;
        private System.Windows.Forms.RadioButton optSubject;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblLetterDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radSurveyNumber;
        private System.Windows.Forms.RadioButton radLetterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewLinkColumn GlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inward_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DO_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn General_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Court_Case_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Right_To_Info_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSubSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCaseWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicant_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Survey_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Government_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hobli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Village;
    }
}