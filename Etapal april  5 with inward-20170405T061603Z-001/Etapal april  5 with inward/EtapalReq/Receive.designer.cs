namespace etapal
{
    partial class Form1
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
            this.radRightToInformationLetter = new System.Windows.Forms.RadioButton();
            this.radCourtCaseLetter = new System.Windows.Forms.RadioButton();
            this.radGeneralLetter = new System.Windows.Forms.RadioButton();
            this.radDO = new System.Windows.Forms.RadioButton();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblAckNumber = new System.Windows.Forms.Label();
            this.lblLetterDate = new System.Windows.Forms.Label();
            this.lblGLNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToSection = new System.Windows.Forms.Label();
            this.lblCaseWorker = new System.Windows.Forms.Label();
            this.lblFromOffice = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtFromOffice = new System.Windows.Forms.TextBox();
            this.txtFromDept = new System.Windows.Forms.TextBox();
            this.dateTimePickerLetterDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.txtAckNo = new System.Windows.Forms.TextBox();
            this.txtInwardNo = new System.Windows.Forms.TextBox();
            this.txtGLNo = new System.Windows.Forms.TextBox();
            this.lblOtherDept = new System.Windows.Forms.Label();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.txtDeptOthers = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtAutoIncNo = new System.Windows.Forms.TextBox();
            this.cbToCaseWorker = new System.Windows.Forms.ComboBox();
            this.cbToSection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // radRightToInformationLetter
            // 
            this.radRightToInformationLetter.AutoSize = true;
            this.radRightToInformationLetter.Location = new System.Drawing.Point(599, 56);
            this.radRightToInformationLetter.Name = "radRightToInformationLetter";
            this.radRightToInformationLetter.Size = new System.Drawing.Size(151, 17);
            this.radRightToInformationLetter.TabIndex = 7;
            this.radRightToInformationLetter.TabStop = true;
            this.radRightToInformationLetter.Text = "Right To Information Letter";
            this.radRightToInformationLetter.UseVisualStyleBackColor = true;
            this.radRightToInformationLetter.CheckedChanged += new System.EventHandler(this.radRightToInformationLetter_CheckedChanged);
            // 
            // radCourtCaseLetter
            // 
            this.radCourtCaseLetter.AutoSize = true;
            this.radCourtCaseLetter.Location = new System.Drawing.Point(426, 56);
            this.radCourtCaseLetter.Name = "radCourtCaseLetter";
            this.radCourtCaseLetter.Size = new System.Drawing.Size(107, 17);
            this.radCourtCaseLetter.TabIndex = 6;
            this.radCourtCaseLetter.TabStop = true;
            this.radCourtCaseLetter.Text = "Court Case Letter";
            this.radCourtCaseLetter.UseVisualStyleBackColor = true;
            this.radCourtCaseLetter.CheckedChanged += new System.EventHandler(this.radCourtCaseLetter_CheckedChanged);
            // 
            // radGeneralLetter
            // 
            this.radGeneralLetter.AutoSize = true;
            this.radGeneralLetter.Location = new System.Drawing.Point(282, 56);
            this.radGeneralLetter.Name = "radGeneralLetter";
            this.radGeneralLetter.Size = new System.Drawing.Size(92, 17);
            this.radGeneralLetter.TabIndex = 5;
            this.radGeneralLetter.TabStop = true;
            this.radGeneralLetter.Text = "General Letter";
            this.radGeneralLetter.UseVisualStyleBackColor = true;
            this.radGeneralLetter.CheckedChanged += new System.EventHandler(this.radGeneralLetter_CheckedChanged);
            // 
            // radDO
            // 
            this.radDO.AutoSize = true;
            this.radDO.Location = new System.Drawing.Point(148, 56);
            this.radDO.Name = "radDO";
            this.radDO.Size = new System.Drawing.Size(41, 17);
            this.radDO.TabIndex = 4;
            this.radDO.TabStop = true;
            this.radDO.Text = "DO";
            this.radDO.UseVisualStyleBackColor = true;
            this.radDO.CheckedChanged += new System.EventHandler(this.radDO_CheckedChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Black;
            this.lblSubject.Location = new System.Drawing.Point(80, 346);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(60, 16);
            this.lblSubject.TabIndex = 70;
            this.lblSubject.Text = "Subject";
            // 
            // lblAckNumber
            // 
            this.lblAckNumber.AutoSize = true;
            this.lblAckNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAckNumber.ForeColor = System.Drawing.Color.Black;
            this.lblAckNumber.Location = new System.Drawing.Point(80, 178);
            this.lblAckNumber.Name = "lblAckNumber";
            this.lblAckNumber.Size = new System.Drawing.Size(92, 16);
            this.lblAckNumber.TabIndex = 69;
            this.lblAckNumber.Text = "Ack Number";
            // 
            // lblLetterDate
            // 
            this.lblLetterDate.AutoSize = true;
            this.lblLetterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterDate.ForeColor = System.Drawing.Color.Black;
            this.lblLetterDate.Location = new System.Drawing.Point(80, 244);
            this.lblLetterDate.Name = "lblLetterDate";
            this.lblLetterDate.Size = new System.Drawing.Size(84, 16);
            this.lblLetterDate.TabIndex = 68;
            this.lblLetterDate.Text = "Letter Date";
            // 
            // lblGLNumber
            // 
            this.lblGLNumber.AutoSize = true;
            this.lblGLNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGLNumber.ForeColor = System.Drawing.Color.Black;
            this.lblGLNumber.Location = new System.Drawing.Point(80, 111);
            this.lblGLNumber.Name = "lblGLNumber";
            this.lblGLNumber.Size = new System.Drawing.Size(85, 16);
            this.lblGLNumber.TabIndex = 67;
            this.lblGLNumber.Text = "GL Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "Inward Number";
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceivedDate.ForeColor = System.Drawing.Color.Black;
            this.lblReceivedDate.Location = new System.Drawing.Point(80, 207);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(120, 16);
            this.lblReceivedDate.TabIndex = 61;
            this.lblReceivedDate.Text = "Received Date  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "From Department ";
            // 
            // lblToSection
            // 
            this.lblToSection.AutoSize = true;
            this.lblToSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSection.ForeColor = System.Drawing.Color.Black;
            this.lblToSection.Location = new System.Drawing.Point(80, 388);
            this.lblToSection.Name = "lblToSection";
            this.lblToSection.Size = new System.Drawing.Size(83, 16);
            this.lblToSection.TabIndex = 63;
            this.lblToSection.Text = "To Section";
            // 
            // lblCaseWorker
            // 
            this.lblCaseWorker.AutoSize = true;
            this.lblCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseWorker.ForeColor = System.Drawing.Color.Black;
            this.lblCaseWorker.Location = new System.Drawing.Point(80, 417);
            this.lblCaseWorker.Name = "lblCaseWorker";
            this.lblCaseWorker.Size = new System.Drawing.Size(117, 16);
            this.lblCaseWorker.TabIndex = 64;
            this.lblCaseWorker.Text = "To CaseWorker";
            // 
            // lblFromOffice
            // 
            this.lblFromOffice.AutoSize = true;
            this.lblFromOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromOffice.ForeColor = System.Drawing.Color.Black;
            this.lblFromOffice.Location = new System.Drawing.Point(80, 304);
            this.lblFromOffice.Name = "lblFromOffice";
            this.lblFromOffice.Size = new System.Drawing.Size(87, 16);
            this.lblFromOffice.TabIndex = 65;
            this.lblFromOffice.Text = "From Office";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(214, 342);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 20);
            this.txtSubject.TabIndex = 83;
            // 
            // txtFromOffice
            // 
            this.txtFromOffice.Location = new System.Drawing.Point(214, 304);
            this.txtFromOffice.Name = "txtFromOffice";
            this.txtFromOffice.Size = new System.Drawing.Size(150, 20);
            this.txtFromOffice.TabIndex = 82;
            // 
            // txtFromDept
            // 
            this.txtFromDept.Location = new System.Drawing.Point(214, 273);
            this.txtFromDept.Name = "txtFromDept";
            this.txtFromDept.Size = new System.Drawing.Size(150, 20);
            this.txtFromDept.TabIndex = 81;
            // 
            // dateTimePickerLetterDate
            // 
            this.dateTimePickerLetterDate.Location = new System.Drawing.Point(214, 239);
            this.dateTimePickerLetterDate.Name = "dateTimePickerLetterDate";
            this.dateTimePickerLetterDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLetterDate.TabIndex = 80;
            // 
            // dateTimePickerReceivedDate
            // 
            this.dateTimePickerReceivedDate.Location = new System.Drawing.Point(214, 207);
            this.dateTimePickerReceivedDate.Name = "dateTimePickerReceivedDate";
            this.dateTimePickerReceivedDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReceivedDate.TabIndex = 79;
            // 
            // txtAckNo
            // 
            this.txtAckNo.Location = new System.Drawing.Point(214, 178);
            this.txtAckNo.Name = "txtAckNo";
            this.txtAckNo.Size = new System.Drawing.Size(150, 20);
            this.txtAckNo.TabIndex = 78;
            // 
            // txtInwardNo
            // 
            this.txtInwardNo.Location = new System.Drawing.Point(214, 146);
            this.txtInwardNo.Name = "txtInwardNo";
            this.txtInwardNo.Size = new System.Drawing.Size(150, 20);
            this.txtInwardNo.TabIndex = 77;
            // 
            // txtGLNo
            // 
            this.txtGLNo.Location = new System.Drawing.Point(214, 111);
            this.txtGLNo.Name = "txtGLNo";
            this.txtGLNo.Size = new System.Drawing.Size(150, 20);
            this.txtGLNo.TabIndex = 76;
            // 
            // lblOtherDept
            // 
            this.lblOtherDept.AutoSize = true;
            this.lblOtherDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherDept.Location = new System.Drawing.Point(561, 256);
            this.lblOtherDept.Name = "lblOtherDept";
            this.lblOtherDept.Size = new System.Drawing.Size(173, 13);
            this.lblOtherDept.TabIndex = 90;
            this.lblOtherDept.Text = "Enter Other Deparment Name";
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOthers.ForeColor = System.Drawing.Color.Black;
            this.chkOthers.Location = new System.Drawing.Point(489, 275);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(75, 17);
            this.chkOthers.TabIndex = 89;
            this.chkOthers.Text = "If Others";
            this.chkOthers.UseVisualStyleBackColor = true;
            this.chkOthers.CheckedChanged += new System.EventHandler(this.chkOthers_CheckedChanged);
            // 
            // txtDeptOthers
            // 
            this.txtDeptOthers.Location = new System.Drawing.Point(572, 275);
            this.txtDeptOthers.Name = "txtDeptOthers";
            this.txtDeptOthers.Size = new System.Drawing.Size(157, 20);
            this.txtDeptOthers.TabIndex = 91;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(202, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 93;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(289, 454);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtAutoIncNo
            // 
            this.txtAutoIncNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoIncNo.Location = new System.Drawing.Point(414, 110);
            this.txtAutoIncNo.Name = "txtAutoIncNo";
            this.txtAutoIncNo.ReadOnly = true;
            this.txtAutoIncNo.Size = new System.Drawing.Size(46, 20);
            this.txtAutoIncNo.TabIndex = 95;
            // 
            // cbToCaseWorker
            // 
            this.cbToCaseWorker.FormattingEnabled = true;
            this.cbToCaseWorker.Location = new System.Drawing.Point(214, 413);
            this.cbToCaseWorker.Name = "cbToCaseWorker";
            this.cbToCaseWorker.Size = new System.Drawing.Size(200, 21);
            this.cbToCaseWorker.TabIndex = 97;
            // 
            // cbToSection
            // 
            this.cbToSection.FormattingEnabled = true;
            this.cbToSection.Location = new System.Drawing.Point(214, 383);
            this.cbToSection.Name = "cbToSection";
            this.cbToSection.Size = new System.Drawing.Size(200, 21);
            this.cbToSection.TabIndex = 96;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 489);
            this.Controls.Add(this.cbToCaseWorker);
            this.Controls.Add(this.cbToSection);
            this.Controls.Add(this.txtAutoIncNo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDeptOthers);
            this.Controls.Add(this.lblOtherDept);
            this.Controls.Add(this.chkOthers);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtFromOffice);
            this.Controls.Add(this.txtFromDept);
            this.Controls.Add(this.dateTimePickerLetterDate);
            this.Controls.Add(this.dateTimePickerReceivedDate);
            this.Controls.Add(this.txtAckNo);
            this.Controls.Add(this.txtInwardNo);
            this.Controls.Add(this.txtGLNo);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblAckNumber);
            this.Controls.Add(this.lblLetterDate);
            this.Controls.Add(this.lblGLNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToSection);
            this.Controls.Add(this.lblCaseWorker);
            this.Controls.Add(this.lblFromOffice);
            this.Controls.Add(this.radRightToInformationLetter);
            this.Controls.Add(this.radCourtCaseLetter);
            this.Controls.Add(this.radGeneralLetter);
            this.Controls.Add(this.radDO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRightToInformationLetter;
        private System.Windows.Forms.RadioButton radCourtCaseLetter;
        private System.Windows.Forms.RadioButton radGeneralLetter;
        private System.Windows.Forms.RadioButton radDO;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblAckNumber;
        private System.Windows.Forms.Label lblLetterDate;
        private System.Windows.Forms.Label lblGLNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToSection;
        private System.Windows.Forms.Label lblCaseWorker;
        private System.Windows.Forms.Label lblFromOffice;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtFromOffice;
        private System.Windows.Forms.TextBox txtFromDept;
        private System.Windows.Forms.DateTimePicker dateTimePickerLetterDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerReceivedDate;
        private System.Windows.Forms.TextBox txtAckNo;
        private System.Windows.Forms.TextBox txtInwardNo;
        private System.Windows.Forms.TextBox txtGLNo;
        private System.Windows.Forms.Label lblOtherDept;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.TextBox txtDeptOthers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtAutoIncNo;
        private System.Windows.Forms.ComboBox cbToCaseWorker;
        private System.Windows.Forms.ComboBox cbToSection;
    }
}

