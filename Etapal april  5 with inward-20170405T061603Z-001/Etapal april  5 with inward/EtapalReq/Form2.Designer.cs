namespace EtapalReq
{
    partial class Form2
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
            this.lblToSection = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblToSection
            // 
            this.lblToSection.AutoSize = true;
            this.lblToSection.BackColor = System.Drawing.Color.White;
            this.lblToSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToSection.ForeColor = System.Drawing.Color.Gray;
            this.lblToSection.Location = new System.Drawing.Point(58, 59);
            this.lblToSection.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblToSection.Name = "lblToSection";
            this.lblToSection.Size = new System.Drawing.Size(227, 29);
            this.lblToSection.TabIndex = 322;
            this.lblToSection.Text = "ಯಾವ  ವಿಭಾಗಕ್ಕೆ ಕಳುಹಿಸಲಾಗಿದೆ";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(311, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 324;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 313);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblToSection);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToSection;
        private System.Windows.Forms.ListView listView1;
    }
}