namespace EtapalReq
{
    partial class Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GLNo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.InwardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ack_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCaseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GLNoCase = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.ddlCaseWorker = new System.Windows.Forms.ComboBox();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.lblSelectCaseWorker = new System.Windows.Forms.Label();
            this.lblSelectSection = new System.Windows.Forms.Label();
            this.optDateWise = new System.Windows.Forms.RadioButton();
            this.optCaseWorker = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1138, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 44);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.lblToDate);
            this.groupBox1.Controls.Add(this.lblFromDate);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePickerToDate);
            this.groupBox1.Controls.Add(this.dateTimePickerFromDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 325);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Wise";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GLNo,
            this.InwardNo,
            this.Ack_No,
            this.ReceivedDate,
            this.Letter_Date,
            this.FromDept,
            this.FromOffice,
            this.Subject,
            this.ToSection,
            this.ToCaseWorker,
            this.Signature});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Location = new System.Drawing.Point(33, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1195, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GLNo
            // 
            this.GLNo.DataPropertyName = "GL_No";
            this.GLNo.HeaderText = "GL No";
            this.GLNo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GLNo.Name = "GLNo";
            this.GLNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InwardNo
            // 
            this.InwardNo.DataPropertyName = "Inward_No";
            this.InwardNo.HeaderText = "Inward No";
            this.InwardNo.Name = "InwardNo";
            // 
            // Ack_No
            // 
            this.Ack_No.DataPropertyName = "Ack_No";
            this.Ack_No.HeaderText = "Ack No";
            this.Ack_No.Name = "Ack_No";
            // 
            // ReceivedDate
            // 
            this.ReceivedDate.DataPropertyName = "Received_Date";
            this.ReceivedDate.HeaderText = "Received Date";
            this.ReceivedDate.Name = "ReceivedDate";
            // 
            // Letter_Date
            // 
            this.Letter_Date.DataPropertyName = "Letter_Date";
            this.Letter_Date.HeaderText = "Letter Date";
            this.Letter_Date.Name = "Letter_Date";
            // 
            // FromDept
            // 
            this.FromDept.DataPropertyName = "FromDept";
            this.FromDept.HeaderText = "From Dept";
            this.FromDept.Name = "FromDept";
            // 
            // FromOffice
            // 
            this.FromOffice.DataPropertyName = "FromOffice";
            this.FromOffice.HeaderText = "From Office";
            this.FromOffice.Name = "FromOffice";
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
            this.ToSection.HeaderText = "To Section";
            this.ToSection.Name = "ToSection";
            // 
            // ToCaseWorker
            // 
            this.ToCaseWorker.DataPropertyName = "ToCaseWorker";
            this.ToCaseWorker.HeaderText = "To CaseWorker";
            this.ToCaseWorker.Name = "ToCaseWorker";
            // 
            // Signature
            // 
            this.Signature.HeaderText = "Signature";
            this.Signature.Name = "Signature";
            this.Signature.Width = 150;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(797, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.ddlCaseWorker);
            this.groupBox2.Controls.Add(this.ddlSection);
            this.groupBox2.Controls.Add(this.lblSelectCaseWorker);
            this.groupBox2.Controls.Add(this.lblSelectSection);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1238, 294);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Case Worker";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView2.ColumnHeadersHeight = 60;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GLNoCase,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView2.Location = new System.Drawing.Point(100, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(790, 350);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // GLNoCase
            // 
            this.GLNoCase.DataPropertyName = "GL_No";
            this.GLNoCase.HeaderText = "GL No";
            this.GLNoCase.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GLNoCase.Name = "GLNoCase";
            this.GLNoCase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GLNoCase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GLNoCase.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Inward_No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Inward No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ack_No";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ack No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Received_Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Received Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Letter_Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Letter Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FromDept";
            this.dataGridViewTextBoxColumn9.HeaderText = "From Dept";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FromOffice";
            this.dataGridViewTextBoxColumn10.HeaderText = "From Office";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Subject";
            this.dataGridViewTextBoxColumn11.HeaderText = "Subject";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ToSection";
            this.dataGridViewTextBoxColumn12.HeaderText = "To Section";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 70;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ToCaseWorker";
            this.dataGridViewTextBoxColumn13.HeaderText = "ToCase Worker";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.FillWeight = 75F;
            this.dataGridViewTextBoxColumn14.HeaderText = "Signature";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 80;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(439, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 44);
            this.button3.TabIndex = 37;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ddlCaseWorker
            // 
            this.ddlCaseWorker.FormattingEnabled = true;
            this.ddlCaseWorker.Location = new System.Drawing.Point(243, 64);
            this.ddlCaseWorker.Name = "ddlCaseWorker";
            this.ddlCaseWorker.Size = new System.Drawing.Size(121, 24);
            this.ddlCaseWorker.TabIndex = 36;
            // 
            // ddlSection
            // 
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(243, 23);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(121, 24);
            this.ddlSection.TabIndex = 35;
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
            // optDateWise
            // 
            this.optDateWise.AutoSize = true;
            this.optDateWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDateWise.ForeColor = System.Drawing.Color.Gray;
            this.optDateWise.Location = new System.Drawing.Point(95, 90);
            this.optDateWise.Name = "optDateWise";
            this.optDateWise.Size = new System.Drawing.Size(105, 24);
            this.optDateWise.TabIndex = 27;
            this.optDateWise.TabStop = true;
            this.optDateWise.Text = "DateWise";
            this.optDateWise.UseVisualStyleBackColor = true;
            this.optDateWise.CheckedChanged += new System.EventHandler(this.optDateWise_CheckedChanged_1);
            // 
            // optCaseWorker
            // 
            this.optCaseWorker.AutoSize = true;
            this.optCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.optCaseWorker.Location = new System.Drawing.Point(95, 135);
            this.optCaseWorker.Name = "optCaseWorker";
            this.optCaseWorker.Size = new System.Drawing.Size(125, 24);
            this.optCaseWorker.TabIndex = 28;
            this.optCaseWorker.TabStop = true;
            this.optCaseWorker.Text = "CaseWorker";
            this.optCaseWorker.UseVisualStyleBackColor = true;
            this.optCaseWorker.CheckedChanged += new System.EventHandler(this.optCaseWorker_CheckedChanged_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(971, 92);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 42);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(796, 92);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(114, 42);
            this.btnPrintPreview.TabIndex = 30;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
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
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1277, 532);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.optCaseWorker);
            this.Controls.Add(this.optDateWise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ddlCaseWorker;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label lblSelectCaseWorker;
        private System.Windows.Forms.Label lblSelectSection;
        private System.Windows.Forms.RadioButton optDateWise;
        private System.Windows.Forms.RadioButton optCaseWorker;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewLinkColumn GLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InwardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ack_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCaseWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewLinkColumn GLNoCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}