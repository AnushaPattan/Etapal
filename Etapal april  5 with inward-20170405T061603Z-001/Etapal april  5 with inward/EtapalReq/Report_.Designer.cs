namespace EtapalReq
{
    partial class Report_
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
            this.btnBack = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ddlCaseWorker = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.optCaseWorker = new System.Windows.Forms.RadioButton();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.optDateWise = new System.Windows.Forms.RadioButton();
            this.lblSelectCaseWorker = new System.Windows.Forms.Label();
            this.lblSelectSection = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchCaseWorker = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1063, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 44);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ddlCaseWorker
            // 
            this.ddlCaseWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCaseWorker.FormattingEnabled = true;
            this.ddlCaseWorker.Location = new System.Drawing.Point(243, 64);
            this.ddlCaseWorker.Name = "ddlCaseWorker";
            this.ddlCaseWorker.Size = new System.Drawing.Size(121, 24);
            this.ddlCaseWorker.TabIndex = 36;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(896, 47);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 42);
            this.btnPrint.TabIndex = 35;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // optCaseWorker
            // 
            this.optCaseWorker.AutoSize = true;
            this.optCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.optCaseWorker.Location = new System.Drawing.Point(59, 90);
            this.optCaseWorker.Name = "optCaseWorker";
            this.optCaseWorker.Size = new System.Drawing.Size(125, 24);
            this.optCaseWorker.TabIndex = 34;
            this.optCaseWorker.TabStop = true;
            this.optCaseWorker.Text = "CaseWorker";
            this.optCaseWorker.UseVisualStyleBackColor = true;
            this.optCaseWorker.CheckedChanged += new System.EventHandler(this.optCaseWorker_CheckedChanged);
            // 
            // ddlSection
            // 
            this.ddlSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(243, 23);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(121, 24);
            this.ddlSection.TabIndex = 35;
            // 
            // optDateWise
            // 
            this.optDateWise.AutoSize = true;
            this.optDateWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDateWise.ForeColor = System.Drawing.Color.Gray;
            this.optDateWise.Location = new System.Drawing.Point(59, 45);
            this.optDateWise.Name = "optDateWise";
            this.optDateWise.Size = new System.Drawing.Size(105, 24);
            this.optDateWise.TabIndex = 33;
            this.optDateWise.TabStop = true;
            this.optDateWise.Text = "DateWise";
            this.optDateWise.UseVisualStyleBackColor = true;
            this.optDateWise.CheckedChanged += new System.EventHandler(this.optDateWise_CheckedChanged);
            // 
            // lblSelectCaseWorker
            // 
            this.lblSelectCaseWorker.AutoSize = true;
            this.lblSelectCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCaseWorker.Location = new System.Drawing.Point(64, 64);
            this.lblSelectCaseWorker.Name = "lblSelectCaseWorker";
            this.lblSelectCaseWorker.Size = new System.Drawing.Size(142, 16);
            this.lblSelectCaseWorker.TabIndex = 34;
            this.lblSelectCaseWorker.Text = "Select CaseWorker";
            // 
            // lblSelectSection
            // 
            this.lblSelectSection.AutoSize = true;
            this.lblSelectSection.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectSection.Location = new System.Drawing.Point(87, 26);
            this.lblSelectSection.Name = "lblSelectSection";
            this.lblSelectSection.Size = new System.Drawing.Size(108, 16);
            this.lblSelectSection.TabIndex = 33;
            this.lblSelectSection.Text = "Select Section";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnSearchDate);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 325);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Wise";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 188);
            this.dataGridView1.TabIndex = 28;
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.ForeColor = System.Drawing.Color.Black;
            this.btnSearchDate.Location = new System.Drawing.Point(797, 35);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(112, 44);
            this.btnSearchDate.TabIndex = 27;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.ForeColor = System.Drawing.Color.Gray;
            this.lblToDate.Location = new System.Drawing.Point(423, 49);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(64, 16);
            this.lblToDate.TabIndex = 26;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.ForeColor = System.Drawing.Color.Gray;
            this.lblFromDate.Location = new System.Drawing.Point(51, 49);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(80, 16);
            this.lblFromDate.TabIndex = 25;
            this.lblFromDate.Text = "From Date";
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Location = new System.Drawing.Point(493, 49);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerToDate.TabIndex = 24;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(131, 49);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFromDate.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnSearchCaseWorker);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.ddlCaseWorker);
            this.groupBox2.Controls.Add(this.ddlSection);
            this.groupBox2.Controls.Add(this.lblSelectCaseWorker);
            this.groupBox2.Controls.Add(this.lblSelectSection);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1227, 347);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Case Worker";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 40;
            // 
            // btnSearchCaseWorker
            // 
            this.btnSearchCaseWorker.ForeColor = System.Drawing.Color.Black;
            this.btnSearchCaseWorker.Location = new System.Drawing.Point(442, 23);
            this.btnSearchCaseWorker.Name = "btnSearchCaseWorker";
            this.btnSearchCaseWorker.Size = new System.Drawing.Size(114, 42);
            this.btnSearchCaseWorker.TabIndex = 39;
            this.btnSearchCaseWorker.Text = "Search";
            this.btnSearchCaseWorker.UseVisualStyleBackColor = true;
            this.btnSearchCaseWorker.Click += new System.EventHandler(this.btnSearchCaseWorker_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(67, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(987, 206);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Report_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1231, 520);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.optCaseWorker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.optDateWise);
            this.Controls.Add(this.groupBox1);
            this.Name = "Report_";
            this.Text = "Report_";
            this.Load += new System.EventHandler(this.Report__Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox ddlCaseWorker;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton optCaseWorker;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.RadioButton optDateWise;
        private System.Windows.Forms.Label lblSelectCaseWorker;
        private System.Windows.Forms.Label lblSelectSection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSearchCaseWorker;
        private System.Windows.Forms.Label label1;

    }
}