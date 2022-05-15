namespace SymptomChecker
{
    partial class HomePage
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
            this.pharmacies_btn = new System.Windows.Forms.Button();
            this.symptomChecker_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pharmacies_btn
            // 
            this.pharmacies_btn.Location = new System.Drawing.Point(68, 57);
            this.pharmacies_btn.Name = "pharmacies_btn";
            this.pharmacies_btn.Size = new System.Drawing.Size(150, 79);
            this.pharmacies_btn.TabIndex = 0;
            this.pharmacies_btn.Text = "Pharmacies On Duty";
            this.pharmacies_btn.UseVisualStyleBackColor = true;
            this.pharmacies_btn.Click += new System.EventHandler(this.pharmacies_btn_Click);
            // 
            // symptomChecker_btn
            // 
            this.symptomChecker_btn.Location = new System.Drawing.Point(253, 57);
            this.symptomChecker_btn.Name = "symptomChecker_btn";
            this.symptomChecker_btn.Size = new System.Drawing.Size(169, 79);
            this.symptomChecker_btn.TabIndex = 1;
            this.symptomChecker_btn.Text = "Symptom Checker";
            this.symptomChecker_btn.UseVisualStyleBackColor = true;
            this.symptomChecker_btn.Click += new System.EventHandler(this.symptomChecker_btn_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 218);
            this.Controls.Add(this.symptomChecker_btn);
            this.Controls.Add(this.pharmacies_btn);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pharmacies_btn;
        private System.Windows.Forms.Button symptomChecker_btn;
    }
}