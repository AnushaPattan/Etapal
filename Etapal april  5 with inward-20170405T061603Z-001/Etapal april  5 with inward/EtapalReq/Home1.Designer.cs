namespace EtapalReq
{
    partial class Home1
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
            this.components = new System.ComponentModel.Container();
            this.radSearch = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radReceive = new System.Windows.Forms.RadioButton();
            this.radReport = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radSearch
            // 
            this.radSearch.AutoSize = true;
            this.radSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSearch.ForeColor = System.Drawing.Color.Gray;
            this.radSearch.Location = new System.Drawing.Point(81, 161);
            this.radSearch.Name = "radSearch";
            this.radSearch.Size = new System.Drawing.Size(94, 28);
            this.radSearch.TabIndex = 11;
            this.radSearch.Text = "Search";
            this.radSearch.UseVisualStyleBackColor = true;
            this.radSearch.CheckedChanged += new System.EventHandler(this.radSearch_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Management",
            "Section Management",
            "User Management"});
            this.comboBox1.Location = new System.Drawing.Point(85, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "qwerty";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radReceive
            // 
            this.radReceive.AutoSize = true;
            this.radReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReceive.ForeColor = System.Drawing.Color.Gray;
            this.radReceive.Location = new System.Drawing.Point(81, 127);
            this.radReceive.Name = "radReceive";
            this.radReceive.Size = new System.Drawing.Size(104, 28);
            this.radReceive.TabIndex = 8;
            this.radReceive.Text = "Receive";
            this.radReceive.UseVisualStyleBackColor = true;
            this.radReceive.CheckedChanged += new System.EventHandler(this.radReceive_CheckedChanged);
            // 
            // radReport
            // 
            this.radReport.AutoSize = true;
            this.radReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReport.ForeColor = System.Drawing.Color.Gray;
            this.radReport.Location = new System.Drawing.Point(85, 204);
            this.radReport.Name = "radReport";
            this.radReport.Size = new System.Drawing.Size(90, 28);
            this.radReport.TabIndex = 12;
            this.radReport.Text = "Report";
            this.radReport.UseVisualStyleBackColor = true;
            this.radReport.CheckedChanged += new System.EventHandler(this.radReport_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Logout";
            this.toolTip1.SetToolTip(this.button1, "Logout");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radReport);
            this.Controls.Add(this.radSearch);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radReceive);
            this.Name = "Home1";
            this.Text = "Home1";
            this.Load += new System.EventHandler(this.Home1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radReceive;
        private System.Windows.Forms.RadioButton radReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}