namespace EtapalUpdatedNew
{
    partial class CaseWorker
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
            this.btnSearchCaseWorker = new System.Windows.Forms.Button();
            this.ddlCaseWorker = new System.Windows.Forms.ComboBox();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.lblSelectCaseWorker = new System.Windows.Forms.Label();
            this.lblSelectSection = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gl_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Applicant_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCaseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSubSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inward_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCaseWorker
            // 
            this.btnSearchCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.btnSearchCaseWorker.Location = new System.Drawing.Point(538, 80);
            this.btnSearchCaseWorker.Name = "btnSearchCaseWorker";
            this.btnSearchCaseWorker.Size = new System.Drawing.Size(86, 32);
            this.btnSearchCaseWorker.TabIndex = 45;
            this.btnSearchCaseWorker.Text = "Search";
            this.btnSearchCaseWorker.UseVisualStyleBackColor = true;
            this.btnSearchCaseWorker.Click += new System.EventHandler(this.btnSearchCaseWorker_Click);
            // 
            // ddlCaseWorker
            // 
            this.ddlCaseWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCaseWorker.FormattingEnabled = true;
            this.ddlCaseWorker.Location = new System.Drawing.Point(255, 121);
            this.ddlCaseWorker.Name = "ddlCaseWorker";
            this.ddlCaseWorker.Size = new System.Drawing.Size(214, 21);
            this.ddlCaseWorker.TabIndex = 43;
            // 
            // ddlSection
            // 
            this.ddlSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(255, 80);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(214, 21);
            this.ddlSection.TabIndex = 42;
            // 
            // lblSelectCaseWorker
            // 
            this.lblSelectCaseWorker.AutoSize = true;
            this.lblSelectCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCaseWorker.Location = new System.Drawing.Point(76, 121);
            this.lblSelectCaseWorker.Name = "lblSelectCaseWorker";
            this.lblSelectCaseWorker.Size = new System.Drawing.Size(155, 18);
            this.lblSelectCaseWorker.TabIndex = 41;
            this.lblSelectCaseWorker.Text = "Select CaseWorker";
            // 
            // lblSelectSection
            // 
            this.lblSelectSection.AutoSize = true;
            this.lblSelectSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSection.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectSection.Location = new System.Drawing.Point(76, 86);
            this.lblSelectSection.Name = "lblSelectSection";
            this.lblSelectSection.Size = new System.Drawing.Size(117, 18);
            this.lblSelectSection.TabIndex = 40;
            this.lblSelectSection.Text = "Select Section";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Gray;
            this.btnPrint.Location = new System.Drawing.Point(698, 80);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 32);
            this.btnPrint.TabIndex = 46;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(853, 80);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 32);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.Gl_No,
            this.Applicant_Name,
            this.Letter_No,
            this.Letter_Date,
            this.Subject,
            this.ToSection,
            this.ToCaseWorker,
            this.Signature,
            this.ToSubSection,
            this.FromOffice,
            this.Inward_No,
            this.FromDept,
            this.Other_Dept,
            this.Received_Date});
            this.dataGridView2.Location = new System.Drawing.Point(36, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(849, 265);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1002, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 137);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
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
            this.Subject.Visible = false;
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
            this.Signature.HeaderText = "Sign and Date";
            this.Signature.Name = "Signature";
            // 
            // ToSubSection
            // 
            this.ToSubSection.DataPropertyName = "ToSubSection";
            this.ToSubSection.HeaderText = "ToSubSection";
            this.ToSubSection.Name = "ToSubSection";
            this.ToSubSection.Visible = false;
            // 
            // FromOffice
            // 
            this.FromOffice.DataPropertyName = "FromOffice";
            this.FromOffice.HeaderText = "From Office";
            this.FromOffice.Name = "FromOffice";
            this.FromOffice.Visible = false;
            // 
            // Inward_No
            // 
            this.Inward_No.DataPropertyName = "Inward_No";
            this.Inward_No.HeaderText = "Inward No";
            this.Inward_No.Name = "Inward_No";
            this.Inward_No.Visible = false;
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
            // 
            // Received_Date
            // 
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.Visible = false;
            // 
            // CaseWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSearchCaseWorker);
            this.Controls.Add(this.ddlCaseWorker);
            this.Controls.Add(this.ddlSection);
            this.Controls.Add(this.lblSelectCaseWorker);
            this.Controls.Add(this.lblSelectSection);
            this.Name = "CaseWorker";
            this.Text = "CaseWorker";
            this.Load += new System.EventHandler(this.CaseWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCaseWorker;
        private System.Windows.Forms.ComboBox ddlCaseWorker;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label lblSelectCaseWorker;
        private System.Windows.Forms.Label lblSelectSection;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSubSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inward_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
    }
}