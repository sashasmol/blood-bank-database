namespace WindowsFormsApplication1
{
    partial class BloodBankHomepage
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
            this.label_SSN = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_bloodbank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_SSN
            // 
            this.label_SSN.AutoSize = true;
            this.label_SSN.Location = new System.Drawing.Point(46, 83);
            this.label_SSN.Name = "label_SSN";
            this.label_SSN.Size = new System.Drawing.Size(0, 13);
            this.label_SSN.TabIndex = 1;
            this.label_SSN.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Donor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_bloodbank
            // 
            this.button_bloodbank.Location = new System.Drawing.Point(137, 29);
            this.button_bloodbank.Name = "button_bloodbank";
            this.button_bloodbank.Size = new System.Drawing.Size(75, 23);
            this.button_bloodbank.TabIndex = 6;
            this.button_bloodbank.Text = "Blood Bank";
            this.button_bloodbank.UseVisualStyleBackColor = true;
            this.button_bloodbank.Click += new System.EventHandler(this.button_bloodbank_Click);
            // 
            // BloodBankHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 86);
            this.Controls.Add(this.button_bloodbank);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_SSN);
            this.Name = "BloodBankHomepage";
            this.Text = "Blood Bank Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SSN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_bloodbank;
    }
}

