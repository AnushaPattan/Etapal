namespace EtapalReq
{
    partial class Search
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.GL_No = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Inward_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letter_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other_Dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToCaseWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(27, 140);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(0, 16);
            this.lblSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(151, 140);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gray;
            this.radioButton1.Location = new System.Drawing.Point(151, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GL No";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.Gray;
            this.radioButton2.Location = new System.Drawing.Point(280, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 20);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ack No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.Gray;
            this.radioButton3.Location = new System.Drawing.Point(439, 80);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 20);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Inward No";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.Gray;
            this.radioButton4.Location = new System.Drawing.Point(594, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(78, 20);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Subject";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GL_No,
            this.Inward_No,
            this.Subject,
            this.id,
            this.Received_Date,
            this.Letter_Date,
            this.FromDept,
            this.Other_Dept,
            this.FromOffice,
            this.ToSection,
            this.ToCaseWorker,
            this.Signature});
            this.dataGridView1.Location = new System.Drawing.Point(75, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 125);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(422, 132);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 44);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(560, 132);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 44);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GL_No
            // 
            this.GL_No.DataPropertyName = "GL_No";
            this.GL_No.HeaderText = "GL No";
            this.GL_No.Name = "GL_No";
            this.GL_No.Width = 250;
            // 
            // Inward_No
            // 
            this.Inward_No.DataPropertyName = "Inward_No";
            this.Inward_No.HeaderText = "Inward No";
            this.Inward_No.Name = "Inward_No";
            this.Inward_No.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Inward_No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Inward_No.Width = 250;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Subject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Subject.Width = 250;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Received_Date
            // 
            this.Received_Date.DataPropertyName = "Received_Date";
            this.Received_Date.HeaderText = "Received Date";
            this.Received_Date.Name = "Received_Date";
            this.Received_Date.Visible = false;
            // 
            // Letter_Date
            // 
            this.Letter_Date.DataPropertyName = "Letter_Date";
            this.Letter_Date.HeaderText = "Letter Date";
            this.Letter_Date.Name = "Letter_Date";
            this.Letter_Date.Visible = false;
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
            // FromOffice
            // 
            this.FromOffice.DataPropertyName = "FromOffice";
            this.FromOffice.HeaderText = "From Office";
            this.FromOffice.Name = "FromOffice";
            this.FromOffice.Visible = false;
            // 
            // ToSection
            // 
            this.ToSection.DataPropertyName = "ToSection";
            this.ToSection.HeaderText = "To Section";
            this.ToSection.Name = "ToSection";
            this.ToSection.Visible = false;
            // 
            // ToCaseWorker
            // 
            this.ToCaseWorker.DataPropertyName = "ToCaseWorker";
            this.ToCaseWorker.HeaderText = "To CaseWorker";
            this.ToCaseWorker.Name = "ToCaseWorker";
            this.ToCaseWorker.Visible = false;
            // 
            // Signature
            // 
            this.Signature.DataPropertyName = "Signature";
            this.Signature.HeaderText = "Signature";
            this.Signature.Name = "Signature";
            this.Signature.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1317, 462);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewLinkColumn GL_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inward_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letter_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other_Dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToCaseWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
    }
}