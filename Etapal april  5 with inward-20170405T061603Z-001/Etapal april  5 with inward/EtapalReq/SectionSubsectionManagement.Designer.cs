namespace EtapalReq
{
    partial class SectionSubsectionManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblEnterSection = new System.Windows.Forms.Label();
            this.dataGridView_SectionSubsection_Mgmt = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListOfSections = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subsection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblSubsection = new System.Windows.Forms.Label();
            this.txtSubsection = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTodayDateValue = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblFinYearValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SectionSubsection_Mgmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(820, 147);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 32);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Location = new System.Drawing.Point(688, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gray;
            this.btnUpdate.Location = new System.Drawing.Point(820, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Gray;
            this.btnInsert.Location = new System.Drawing.Point(688, 90);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Add ";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblEnterSection
            // 
            this.lblEnterSection.AutoSize = true;
            this.lblEnterSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSection.ForeColor = System.Drawing.Color.Gray;
            this.lblEnterSection.Location = new System.Drawing.Point(57, 38);
            this.lblEnterSection.Name = "lblEnterSection";
            this.lblEnterSection.Size = new System.Drawing.Size(110, 18);
            this.lblEnterSection.TabIndex = 51;
            this.lblEnterSection.Text = "Enter Section";
            // 
            // dataGridView_SectionSubsection_Mgmt
            // 
            this.dataGridView_SectionSubsection_Mgmt.AllowUserToAddRows = false;
            this.dataGridView_SectionSubsection_Mgmt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_SectionSubsection_Mgmt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_SectionSubsection_Mgmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SectionSubsection_Mgmt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.ListOfSections,
            this.Subsection,
            this.idd});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SectionSubsection_Mgmt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SectionSubsection_Mgmt.Location = new System.Drawing.Point(219, 203);
            this.dataGridView_SectionSubsection_Mgmt.Name = "dataGridView_SectionSubsection_Mgmt";
            this.dataGridView_SectionSubsection_Mgmt.ReadOnly = true;
            this.dataGridView_SectionSubsection_Mgmt.Size = new System.Drawing.Size(434, 430);
            this.dataGridView_SectionSubsection_Mgmt.TabIndex = 57;
            this.dataGridView_SectionSubsection_Mgmt.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SectionSubsection_Mgmt_RowHeaderMouseClick);
            this.dataGridView_SectionSubsection_Mgmt.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_SectionSubsection_Mgmt_RowPostPaint);
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Width = 55;
            // 
            // ListOfSections
            // 
            this.ListOfSections.DataPropertyName = "Section";
            this.ListOfSections.HeaderText = "Sections";
            this.ListOfSections.Name = "ListOfSections";
            this.ListOfSections.ReadOnly = true;
            this.ListOfSections.Width = 73;
            // 
            // Subsection
            // 
            this.Subsection.DataPropertyName = "Subsection";
            this.Subsection.HeaderText = "Subsections";
            this.Subsection.Name = "Subsection";
            this.Subsection.ReadOnly = true;
            this.Subsection.Width = 90;
            // 
            // idd
            // 
            this.idd.DataPropertyName = "id";
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Visible = false;
            this.idd.Width = 43;
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.PowderBlue;
            this.txtSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(215, 13);
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSection.Size = new System.Drawing.Size(379, 47);
            this.txtSection.TabIndex = 1;
            // 
            // lblSubsection
            // 
            this.lblSubsection.AutoSize = true;
            this.lblSubsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsection.ForeColor = System.Drawing.Color.Gray;
            this.lblSubsection.Location = new System.Drawing.Point(57, 77);
            this.lblSubsection.Name = "lblSubsection";
            this.lblSubsection.Size = new System.Drawing.Size(137, 18);
            this.lblSubsection.TabIndex = 59;
            this.lblSubsection.Text = "Enter Subsection";
            // 
            // txtSubsection
            // 
            this.txtSubsection.BackColor = System.Drawing.Color.PowderBlue;
            this.txtSubsection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsection.Location = new System.Drawing.Point(215, 69);
            this.txtSubsection.Multiline = true;
            this.txtSubsection.Name = "txtSubsection";
            this.txtSubsection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSubsection.Size = new System.Drawing.Size(379, 48);
            this.txtSubsection.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1111, 590);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 117);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.lblSubsection);
            this.groupBox1.Controls.Add(this.lblEnterSection);
            this.groupBox1.Controls.Add(this.txtSubsection);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(28, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 126);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "S and S";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFinancialYear);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblTodayDateValue);
            this.groupBox2.Controls.Add(this.lblTodayDate);
            this.groupBox2.Controls.Add(this.lblFinYearValue);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Location = new System.Drawing.Point(32, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 43);
            this.groupBox2.TabIndex = 460;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "S and S";
            // 
            // lblFinancialYear
            // 
            this.lblFinancialYear.AutoSize = true;
            this.lblFinancialYear.BackColor = System.Drawing.Color.White;
            this.lblFinancialYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialYear.ForeColor = System.Drawing.Color.Gray;
            this.lblFinancialYear.Location = new System.Drawing.Point(79, 18);
            this.lblFinancialYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancialYear.Name = "lblFinancialYear";
            this.lblFinancialYear.Size = new System.Drawing.Size(120, 16);
            this.lblFinancialYear.TabIndex = 255;
            this.lblFinancialYear.Text = "Financial Year : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(373, 13);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(271, 18);
            this.label13.TabIndex = 456;
            this.label13.Text = "ADD SECTION AND SUBSECTION";
            // 
            // lblTodayDateValue
            // 
            this.lblTodayDateValue.AutoSize = true;
            this.lblTodayDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDateValue.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDateValue.Location = new System.Drawing.Point(935, 13);
            this.lblTodayDateValue.Name = "lblTodayDateValue";
            this.lblTodayDateValue.Size = new System.Drawing.Size(0, 16);
            this.lblTodayDateValue.TabIndex = 455;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDate.Location = new System.Drawing.Point(757, 15);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(171, 16);
            this.lblTodayDate.TabIndex = 454;
            this.lblTodayDate.Text = "Today Date and Time : ";
            // 
            // lblFinYearValue
            // 
            this.lblFinYearValue.AutoSize = true;
            this.lblFinYearValue.BackColor = System.Drawing.Color.White;
            this.lblFinYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinYearValue.ForeColor = System.Drawing.Color.Gray;
            this.lblFinYearValue.Location = new System.Drawing.Point(218, 21);
            this.lblFinYearValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinYearValue.Name = "lblFinYearValue";
            this.lblFinYearValue.Size = new System.Drawing.Size(0, 16);
            this.lblFinYearValue.TabIndex = 271;
            // 
            // SectionSubsectionManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView_SectionSubsection_Mgmt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Name = "SectionSubsectionManagement";
            this.Text = "SectionSubsectionManagement";
            this.Load += new System.EventHandler(this.SectionSubsectionManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SectionSubsection_Mgmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblEnterSection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_SectionSubsection_Mgmt;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label lblSubsection;
        private System.Windows.Forms.TextBox txtSubsection;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListOfSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subsection;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTodayDateValue;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblFinYearValue;
    }
}