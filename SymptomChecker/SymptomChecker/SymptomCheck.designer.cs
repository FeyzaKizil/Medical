namespace SymptomChecker
{
    partial class SymptomCheck
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
            this.Request_btn = new System.Windows.Forms.Button();
            this.Symptom_ComboBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Configure_btn = new System.Windows.Forms.Button();
            this.ConfigureTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.AddSymptoms_btn = new System.Windows.Forms.Button();
            this.Languages = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Request_btn
            // 
            this.Request_btn.Location = new System.Drawing.Point(293, 74);
            this.Request_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Request_btn.Name = "Request_btn";
            this.Request_btn.Size = new System.Drawing.Size(99, 28);
            this.Request_btn.TabIndex = 1;
            this.Request_btn.Text = "Request";
            this.Request_btn.UseVisualStyleBackColor = true;
            this.Request_btn.Click += new System.EventHandler(this.Request_btn_Click);
            // 
            // Symptom_ComboBox
            // 
            this.Symptom_ComboBox.Location = new System.Drawing.Point(16, 78);
            this.Symptom_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Symptom_ComboBox.Name = "Symptom_ComboBox";
            this.Symptom_ComboBox.ReadOnly = true;
            this.Symptom_ComboBox.Size = new System.Drawing.Size(160, 22);
            this.Symptom_ComboBox.TabIndex = 3;
            this.Symptom_ComboBox.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(16, 11);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(0, 16);
            this.nameLbl.TabIndex = 5;
            // 
            // LinkLabel
            // 
            this.LinkLabel.Location = new System.Drawing.Point(0, 0);
            this.LinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(133, 28);
            this.LinkLabel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current user:";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(113, 15);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(132, 22);
            this.UserName.TabIndex = 4;
            this.UserName.TabStop = false;
            // 
            // Configure_btn
            // 
            this.Configure_btn.Location = new System.Drawing.Point(255, 15);
            this.Configure_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Configure_btn.Name = "Configure_btn";
            this.Configure_btn.Size = new System.Drawing.Size(31, 27);
            this.Configure_btn.TabIndex = 2;
            this.Configure_btn.Text = "⚙";
            this.ConfigureTooltip.SetToolTip(this.Configure_btn, "Configure user");
            this.Configure_btn.UseVisualStyleBackColor = true;
            this.Configure_btn.Click += new System.EventHandler(this.Configure_btn_Click);
            // 
            // AddSymptoms_btn
            // 
            this.AddSymptoms_btn.Location = new System.Drawing.Point(185, 74);
            this.AddSymptoms_btn.Margin = new System.Windows.Forms.Padding(4);
            this.AddSymptoms_btn.Name = "AddSymptoms_btn";
            this.AddSymptoms_btn.Size = new System.Drawing.Size(100, 28);
            this.AddSymptoms_btn.TabIndex = 0;
            this.AddSymptoms_btn.Text = "+";
            this.ConfigureTooltip.SetToolTip(this.AddSymptoms_btn, "Add symptom");
            this.AddSymptoms_btn.UseVisualStyleBackColor = true;
            this.AddSymptoms_btn.Click += new System.EventHandler(this.AddSymptoms_btn_Click);
            // 
            // Languages
            // 
            this.Languages.FormattingEnabled = true;
            this.Languages.Items.AddRange(new object[] {
            "English",
            "Español",
            "Français",
            "Deutsche",
            "Italiano",
            "عربى",
            "Русский",
            "Türk",
            "Srpski",
            "Slovenskí"});
            this.Languages.Location = new System.Drawing.Point(293, 15);
            this.Languages.Margin = new System.Windows.Forms.Padding(4);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(97, 24);
            this.Languages.TabIndex = 3;
            this.Languages.SelectedIndexChanged += new System.EventHandler(this.Languages_SelectedIndexChanged);
            // 
            // SymptomCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 114);
            this.Controls.Add(this.AddSymptoms_btn);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.Configure_btn);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.Symptom_ComboBox);
            this.Controls.Add(this.Request_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SymptomCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symptom Checker";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Request_btn;
        private System.Windows.Forms.TextBox Symptom_ComboBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button Configure_btn;
        private System.Windows.Forms.ToolTip ConfigureTooltip;
        private System.Windows.Forms.ComboBox Languages;
        private System.Windows.Forms.Button AddSymptoms_btn;
    }
}