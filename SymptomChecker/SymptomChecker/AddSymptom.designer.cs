namespace SymptomChecker
{
    partial class AddSymptom
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
            this.Part_ComboBox = new System.Windows.Forms.ComboBox();
            this.Subpart_ComboBox = new System.Windows.Forms.ComboBox();
            this.Symptom_ComboBox = new System.Windows.Forms.ComboBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Part_ComboBox
            // 
            this.Part_ComboBox.FormattingEnabled = true;
            this.Part_ComboBox.Location = new System.Drawing.Point(185, 15);
            this.Part_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Part_ComboBox.Name = "Part_ComboBox";
            this.Part_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.Part_ComboBox.TabIndex = 0;
            this.Part_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Part_ComboBox_SelectedIndexChanged);
            // 
            // Subpart_ComboBox
            // 
            this.Subpart_ComboBox.FormattingEnabled = true;
            this.Subpart_ComboBox.Location = new System.Drawing.Point(185, 48);
            this.Subpart_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Subpart_ComboBox.Name = "Subpart_ComboBox";
            this.Subpart_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.Subpart_ComboBox.TabIndex = 1;
            this.Subpart_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Subpart_ComboBox_SelectedIndexChanged);
            // 
            // Symptom_ComboBox
            // 
            this.Symptom_ComboBox.FormattingEnabled = true;
            this.Symptom_ComboBox.Location = new System.Drawing.Point(185, 81);
            this.Symptom_ComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Symptom_ComboBox.Name = "Symptom_ComboBox";
            this.Symptom_ComboBox.Size = new System.Drawing.Size(160, 24);
            this.Symptom_ComboBox.TabIndex = 2;
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(16, 114);
            this.Add_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(331, 28);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Add Symptom";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Body Part";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Body Subpart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Symptom";
            // 
            // AddSymptom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 159);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Symptom_ComboBox);
            this.Controls.Add(this.Subpart_ComboBox);
            this.Controls.Add(this.Part_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddSymptom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Symptom";
            this.Load += new System.EventHandler(this.AddSymptom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Part_ComboBox;
        private System.Windows.Forms.ComboBox Subpart_ComboBox;
        private System.Windows.Forms.ComboBox Symptom_ComboBox;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}