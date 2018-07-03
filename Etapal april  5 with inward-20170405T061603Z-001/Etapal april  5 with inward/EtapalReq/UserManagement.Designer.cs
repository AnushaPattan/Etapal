namespace EtapalReq
{
    partial class UserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaseWorkers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.lblEnterCaseWorker = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTodayDateValue = new System.Windows.Forms.Label();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblFinYearValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(808, 65);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gray;
            this.btnDelete.Location = new System.Drawing.Point(678, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gray;
            this.btnUpdate.Location = new System.Drawing.Point(808, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Gray;
            this.btnInsert.Location = new System.Drawing.Point(678, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(86, 32);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlNo,
            this.CaseWorkers,
            this.idname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(218, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 500);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // SlNo
            // 
            this.SlNo.HeaderText = "SlNo";
            this.SlNo.Name = "SlNo";
            this.SlNo.ReadOnly = true;
            this.SlNo.Width = 55;
            // 
            // CaseWorkers
            // 
            this.CaseWorkers.DataPropertyName = "CaseWorker";
            this.CaseWorkers.HeaderText = "Case Workers";
            this.CaseWorkers.Name = "CaseWorkers";
            this.CaseWorkers.ReadOnly = true;
            this.CaseWorkers.Width = 99;
            // 
            // idname
            // 
            this.idname.DataPropertyName = "id";
            this.idname.HeaderText = "idname";
            this.idname.Name = "idname";
            this.idname.ReadOnly = true;
            this.idname.Visible = false;
            this.idname.Width = 66;
            // 
            // txtSection
            // 
            this.txtSection.BackColor = System.Drawing.Color.PowderBlue;
            this.txtSection.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSection.Location = new System.Drawing.Point(221, 30);
            this.txtSection.Multiline = true;
            this.txtSection.Name = "txtSection";
            this.txtSection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSection.Size = new System.Drawing.Size(350, 46);
            this.txtSection.TabIndex = 1;
            // 
            // lblEnterCaseWorker
            // 
            this.lblEnterCaseWorker.AutoSize = true;
            this.lblEnterCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.lblEnterCaseWorker.Location = new System.Drawing.Point(52, 44);
            this.lblEnterCaseWorker.Name = "lblEnterCaseWorker";
            this.lblEnterCaseWorker.Size = new System.Drawing.Size(153, 18);
            this.lblEnterCaseWorker.TabIndex = 13;
            this.lblEnterCaseWorker.Text = "Enter Case Worker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnterCaseWorker);
            this.groupBox1.Controls.Add(this.txtSection);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(20, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 109);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CW";
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
            this.groupBox2.Location = new System.Drawing.Point(15, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 43);
            this.groupBox2.TabIndex = 461;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CW";
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
            this.label13.Size = new System.Drawing.Size(181, 18);
            this.label13.TabIndex = 456;
            this.label13.Text = "ADD CASEWORKER\'S";
            // 
            // lblTodayDateValue
            // 
            this.lblTodayDateValue.AutoSize = true;
            this.lblTodayDateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDateValue.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDateValue.Location = new System.Drawing.Point(961, 13);
            this.lblTodayDateValue.Name = "lblTodayDateValue";
            this.lblTodayDateValue.Size = new System.Drawing.Size(0, 16);
            this.lblTodayDateValue.TabIndex = 455;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayDate.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayDate.Location = new System.Drawing.Point(783, 15);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(890, 557);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 117);
            this.pictureBox1.TabIndex = 462;
            this.pictureBox1.TabStop = false;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label lblEnterCaseWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn idname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTodayDateValue;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblFinYearValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}