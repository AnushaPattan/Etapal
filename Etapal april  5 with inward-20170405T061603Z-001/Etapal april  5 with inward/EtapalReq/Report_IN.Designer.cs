namespace EtapalReq
{
    partial class Report_IN
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.optCaseWorker = new System.Windows.Forms.RadioButton();
            this.optDateWise = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EtapalReq.Properties.Resources.Digital;
            this.pictureBox1.Location = new System.Drawing.Point(1019, 624);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 137);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCategory.Location = new System.Drawing.Point(31, 29);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(128, 18);
            this.lblSelectCategory.TabIndex = 54;
            this.lblSelectCategory.Text = "Select Category";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(342, 125);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(147, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // optCaseWorker
            // 
            this.optCaseWorker.AutoSize = true;
            this.optCaseWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCaseWorker.ForeColor = System.Drawing.Color.Gray;
            this.optCaseWorker.Location = new System.Drawing.Point(34, 133);
            this.optCaseWorker.Name = "optCaseWorker";
            this.optCaseWorker.Size = new System.Drawing.Size(121, 22);
            this.optCaseWorker.TabIndex = 2;
            this.optCaseWorker.Text = "CaseWorker";
            this.optCaseWorker.UseVisualStyleBackColor = true;
            this.optCaseWorker.CheckedChanged += new System.EventHandler(this.optCaseWorker_CheckedChanged);
            // 
            // optDateWise
            // 
            this.optDateWise.AutoSize = true;
            this.optDateWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDateWise.ForeColor = System.Drawing.Color.Gray;
            this.optDateWise.Location = new System.Drawing.Point(34, 77);
            this.optDateWise.Name = "optDateWise";
            this.optDateWise.Size = new System.Drawing.Size(99, 22);
            this.optDateWise.TabIndex = 1;
            this.optDateWise.Text = "DateWise";
            this.optDateWise.UseVisualStyleBackColor = true;
            this.optDateWise.CheckedChanged += new System.EventHandler(this.optDateWise_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSelectCategory);
            this.groupBox1.Controls.Add(this.optDateWise);
            this.groupBox1.Controls.Add(this.optCaseWorker);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(74, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 203);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // Report_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Report_IN";
            this.Text = "Report_IN";
            this.Load += new System.EventHandler(this.Report_IN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton optCaseWorker;
        private System.Windows.Forms.RadioButton optDateWise;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}