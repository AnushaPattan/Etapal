namespace EtapalReq
{
    partial class SelectCategory_WO
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
            this.radGovtLetter = new System.Windows.Forms.RadioButton();
            this.lblFinYearValue = new System.Windows.Forms.Label();
            this.lblFinancialYear = new System.Windows.Forms.Label();
            this.radGeneralLetter = new System.Windows.Forms.RadioButton();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radGovtLetter
            // 
            this.radGovtLetter.AutoSize = true;
            this.radGovtLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGovtLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGovtLetter.Location = new System.Drawing.Point(309, 191);
            this.radGovtLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGovtLetter.Name = "radGovtLetter";
            this.radGovtLetter.Size = new System.Drawing.Size(223, 22);
            this.radGovtLetter.TabIndex = 281;
            this.radGovtLetter.TabStop = true;
            this.radGovtLetter.Text = "GOVERNMENT LETTERS";
            this.radGovtLetter.UseVisualStyleBackColor = true;
            // 
            // lblFinYearValue
            // 
            this.lblFinYearValue.AutoSize = true;
            this.lblFinYearValue.BackColor = System.Drawing.Color.White;
            this.lblFinYearValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinYearValue.ForeColor = System.Drawing.Color.Gray;
            this.lblFinYearValue.Location = new System.Drawing.Point(209, 70);
            this.lblFinYearValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinYearValue.Name = "lblFinYearValue";
            this.lblFinYearValue.Size = new System.Drawing.Size(0, 18);
            this.lblFinYearValue.TabIndex = 280;
            // 
            // lblFinancialYear
            // 
            this.lblFinancialYear.AutoSize = true;
            this.lblFinancialYear.BackColor = System.Drawing.Color.White;
            this.lblFinancialYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinancialYear.ForeColor = System.Drawing.Color.Gray;
            this.lblFinancialYear.Location = new System.Drawing.Point(70, 67);
            this.lblFinancialYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFinancialYear.Name = "lblFinancialYear";
            this.lblFinancialYear.Size = new System.Drawing.Size(129, 18);
            this.lblFinancialYear.TabIndex = 274;
            this.lblFinancialYear.Text = "Financial Year : ";
            // 
            // radGeneralLetter
            // 
            this.radGeneralLetter.AutoSize = true;
            this.radGeneralLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGeneralLetter.ForeColor = System.Drawing.Color.Gray;
            this.radGeneralLetter.Location = new System.Drawing.Point(309, 130);
            this.radGeneralLetter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radGeneralLetter.Name = "radGeneralLetter";
            this.radGeneralLetter.Size = new System.Drawing.Size(172, 22);
            this.radGeneralLetter.TabIndex = 277;
            this.radGeneralLetter.TabStop = true;
            this.radGeneralLetter.Text = "GENERAL LETTER";
            this.radGeneralLetter.UseVisualStyleBackColor = true;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.AutoSize = true;
            this.lblSelectCategory.BackColor = System.Drawing.Color.White;
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.ForeColor = System.Drawing.Color.Gray;
            this.lblSelectCategory.Location = new System.Drawing.Point(66, 130);
            this.lblSelectCategory.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(163, 18);
            this.lblSelectCategory.TabIndex = 275;
            this.lblSelectCategory.Text = "Select Category     : ";
            // 
            // SelectCategory_WO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 510);
            this.Controls.Add(this.radGovtLetter);
            this.Controls.Add(this.lblFinYearValue);
            this.Controls.Add(this.lblFinancialYear);
            this.Controls.Add(this.radGeneralLetter);
            this.Controls.Add(this.lblSelectCategory);
            this.Name = "SelectCategory_WO";
            this.Text = "SelectCategory_WO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radGovtLetter;
        private System.Windows.Forms.Label lblFinYearValue;
        private System.Windows.Forms.Label lblFinancialYear;
        private System.Windows.Forms.RadioButton radGeneralLetter;
        private System.Windows.Forms.Label lblSelectCategory;
    }
}