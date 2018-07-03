namespace EtapalUpdatedNew
{
    partial class Datewise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datewise));
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gl_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Applicant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCaseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Government_Letter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hobli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Village = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Survey_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inward_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSubSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radDOLetter = new System.Windows.Forms.RadioButton();
            this.radGovtLetter = new System.Windows.Forms.RadioButton();
            this.radRightToInformationLetter = new System.Windows.Forms.RadioButton();
            this.radCourtCaseLetter = new System.Windows.Forms.RadioButton();
            this.radGeneralLetter = new System.Windows.Forms.RadioButton();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDate.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchDate.Location = new System.Drawing.Point(561, 67);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(86, 32);
            this.btnSearchDate.TabIndex = 33;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.Gray;
            this.lblToDate.Location = new System.Drawing.Point(127, 124);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(68, 18);
            this.lblToDate.TabIndex = 32;
            this.lblToDate.Text = "To Date";
            this.lblToDate.Click += new System.EventHandler(this.lblToDate_Click);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.Gray;
            this.lblFromDate.Location = new System.Drawing.Point(127, 68);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(88, 18);
            this.lblFromDate.TabIndex = 31;
            this.lblFromDate.Text = "From Date";
            this.lblFromDate.Click += new System.EventHandler(this.lblFromDate_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerToDate.Location = new System.Drawing.Point(240, 121);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(265, 24);
            this.dateTimePickerToDate.TabIndex = 30;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(240, 69);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(265, 24);
            this.dateTimePickerFromDate.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(880, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 32);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Gray;
            this.btnPrint.Location = new System.Drawing.Point(725, 67);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 32);
            this.btnPrint.TabIndex = 48;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.Gl_No,
            this.Applicant_Name,
            this.Letter_No,
            this.Letter_Date,
            this.Subject,
            this.ToSection,
            this.ToCaseWorker,
            this.Signature,
            this.Government_Letter,
            this.Hobli,
            this.Village,
            this.Survey_No,
            this.Inward_No,
            this.FromOffice,
            this.FromDept,
            this.Other_Dept,
            this.Received_Date,
            this.ToSubSection});
            this.dataGridView1.Location = new System.Drawing.Point(75, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(821, 303);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlNo.Width = 40;
            // 
            // Gl_No
            // 
            this.Gl_No.DataPropertyName = "Gl_No";
            this.Gl_No.HeaderText = "Gl No";
            this.Gl_No.Name = "Gl_No";
            this.Gl_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gl_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Gl_No.Width = 80;
            // 
            // Applicant_Name
            // 
            this.Applicant_Name.DataPropertyName = "Applicant_Name";
            this.Applicant_Name.HeaderText = "Applicant Name";
            this.Applicant_Name.Name = "Applicant_Name";
            // 
            // Letter_No
            // 
            this.Letter_No.DataPropertyName = "Letter_No";
            this.Letter_No.HeaderText = "Letter No";
            this.Letter_No.Name = "Letter_No";
            // 
            // Letter_Date
            // 
            this.Letter_Date.DataPropertyName = "Letter_Date";
            this.Letter_Date.HeaderText = "Letter Date";
            this.Letter_Date.Name = "Letter_Date";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // ToSection
            // 
            this.ToSection.DataPropertyName = "ToSection";
            this.ToSection.HeaderText = "Section";
            this.ToSection.Name = "ToSection";
            // 
            // ToCaseWorker
            // 
            this.ToCaseWorker.DataPropertyName = "ToCaseWorker";
            this.ToCaseWorker.HeaderText = "CaseWorker";
            this.ToCaseWorker.Name = "ToCaseWorker";
            // 
            // Signature
            // 
            this.Signature.DataPropertyName = "Signature";
            this.Signature.HeaderText = "Signature";
            this.Signature.Name = "Signature";
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
            // Survey_No
            // 
            this.Survey_No.DataPropertyName = "Survey_No";
            this.Survey_No.HeaderText = "Survey_No";
            this.Survey_No.Name = "Survey_No";
            this.Survey_No.Visible = false;
            // 
            // Inward_No
            // 
            this.Inward_No.DataPropertyName = "Inward_No";
            this.Inward_No.HeaderText = "Inward No";
            this.Inward_No.Name = "Inward_No";
            this.Inward_No.Visible = false;
            // 
            // FromOffice
            // 
            this.FromOffice.DataPropertyName = "FromOffice";
            this.FromOffice.HeaderText = "FromOffice";
            this.FromOffice.Name = "FromOffice";
            this.FromOffice.Visible = false;
            // 
            // FromDept
            // 
            this.FromDept.DataPropertyName = "FromDept";
            this.FromDept.HeaderText = "From Dept";
            this.FromDept.Name = "FromDept";
            this.FromDept.Visible = false;
            // 
            // Other_Dept
            // 
            this.Other_Dept.DataPropertyName = "Other_Dept";
            this.Other_Dept.HeaderText = "Other Dept";
            this.Other_Dept.Name = "Other_Dept";
            this.Other_Dept.Visible = false;
            // 
            // Received_Date
            // 
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.Visible = false;
            // 
            // ToSubSection
            // 
            this.ToSubSection.DataPropertyName = "ToSubSection";
            this.ToSubSection.HeaderText = "ToSubSection";
            this.ToSubSection.Name = "ToSubSection";
            this.ToSubSection.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(949, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 137);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // radDOLetter
            // 
            this.radDOLetter.AutoSize = true;
            this.radDOLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDOLetter.ForeColor = System.Drawing.Color.Gray;
            this.radDOLetter.Location = new System.Drawing.Point(234, 30);
            this.radDOLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radDOLetter.Name = "radDOLetter";
            this.radDOLetter.Size = new System.Drawing.Size(99, 22);
            this.radDOLetter.TabIndex = 199;
            this.radDOLetter.TabStop = true;
            this.radDOLetter.Text = "DO Letter";
            this.radDOLetter.UseVisualStyleBackColor = true;
            // 
            // radGovtLetter
            // 
            this.radGovtLetter.AutoSize = true;
            this.radGovtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGovtLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGovtLetter.Location = new System.Drawing.Point(971, 28);
            this.radGovtLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGovtLetter.Name = "radGovtLetter";
            this.radGovtLetter.Size = new System.Drawing.Size(166, 22);
            this.radGovtLetter.TabIndex = 198;
            this.radGovtLetter.TabStop = true;
            this.radGovtLetter.Text = "Government Letter";
            this.radGovtLetter.UseVisualStyleBackColor = true;
            // 
            // radRightToInformationLetter
            // 
            this.radRightToInformationLetter.AutoSize = true;
            this.radRightToInformationLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRightToInformationLetter.ForeColor = System.Drawing.Color.Gray;
            this.radRightToInformationLetter.Location = new System.Drawing.Point(706, 28);
            this.radRightToInformationLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radRightToInformationLetter.Name = "radRightToInformationLetter";
            this.radRightToInformationLetter.Size = new System.Drawing.Size(228, 22);
            this.radRightToInformationLetter.TabIndex = 197;
            this.radRightToInformationLetter.TabStop = true;
            this.radRightToInformationLetter.Text = "Right To Information Letter";
            this.radRightToInformationLetter.UseVisualStyleBackColor = true;
            // 
            // radCourtCaseLetter
            // 
            this.radCourtCaseLetter.AutoSize = true;
            this.radCourtCaseLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCourtCaseLetter.ForeColor = System.Drawing.Color.Gray;
            this.radCourtCaseLetter.Location = new System.Drawing.Point(520, 28);
            this.radCourtCaseLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radCourtCaseLetter.Name = "radCourtCaseLetter";
            this.radCourtCaseLetter.Size = new System.Drawing.Size(160, 22);
            this.radCourtCaseLetter.TabIndex = 196;
            this.radCourtCaseLetter.TabStop = true;
            this.radCourtCaseLetter.Text = "Court Case Letter";
            this.radCourtCaseLetter.UseVisualStyleBackColor = true;
            // 
            // radGeneralLetter
            // 
            this.radGeneralLetter.AutoSize = true;
            this.radGeneralLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGeneralLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGeneralLetter.Location = new System.Drawing.Point(358, 28);
            this.radGeneralLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGeneralLetter.Name = "radGeneralLetter";
            this.radGeneralLetter.Size = new System.Drawing.Size(133, 22);
            this.radGeneralLetter.TabIndex = 195;
            this.radGeneralLetter.TabStop = true;
            this.radGeneralLetter.Text = "General Letter";
            this.radGeneralLetter.UseVisualStyleBackColor = true;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCategory.Location = new System.Drawing.Point(55, 30);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(128, 18);
            this.lblSelectCategory.TabIndex = 194;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Datewise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 469);
            this.Controls.Add(this.radDOLetter);
            this.Controls.Add(this.radGovtLetter);
            this.Controls.Add(this.radRightToInformationLetter);
            this.Controls.Add(this.radCourtCaseLetter);
            this.Controls.Add(this.radGeneralLetter);
            this.Controls.Add(this.lblSelectCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dateTimePickerToDate);
            this.Controls.Add(this.dateTimePickerFromDate);
            this.Name = "Datewise";
            this.Text = "Datewise";
            this.Load += new System.EventHandler(this.Datewise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewLinkColumn Gl_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicant_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCaseWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Government_Letter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hobli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Village;
        private System.Windows.Forms.DataGridViewTextBoxColumn Survey_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inward_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSubSection;
        private System.Windows.Forms.RadioButton radDOLetter;
        private System.Windows.Forms.RadioButton radGovtLetter;
        private System.Windows.Forms.RadioButton radRightToInformationLetter;
        private System.Windows.Forms.RadioButton radCourtCaseLetter;
        private System.Windows.Forms.RadioButton radGeneralLetter;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}