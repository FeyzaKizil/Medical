namespace SymptomChecker
{
    partial class ConfigureUser
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Register_btn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.BirthYearLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(124, 15);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(140, 22);
            this.NameBox.TabIndex = 0;
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(20, 112);
            this.Register_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(145, 28);
            this.Register_btn.TabIndex = 3;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(16, 18);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Name";
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(124, 47);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(4);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(140, 22);
            this.AgeBox.TabIndex = 1;
            // 
            // BirthYearLbl
            // 
            this.BirthYearLbl.AutoSize = true;
            this.BirthYearLbl.Location = new System.Drawing.Point(16, 50);
            this.BirthYearLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthYearLbl.Name = "BirthYearLbl";
            this.BirthYearLbl.Size = new System.Drawing.Size(65, 16);
            this.BirthYearLbl.TabIndex = 6;
            this.BirthYearLbl.Text = "Birth Year";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Location = new System.Drawing.Point(16, 82);
            this.GenderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(52, 16);
            this.GenderLbl.TabIndex = 7;
            this.GenderLbl.Text = "Gender";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(124, 79);
            this.GenderBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(140, 24);
            this.GenderBox.TabIndex = 2;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(173, 112);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(92, 28);
            this.Cancel_btn.TabIndex = 4;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ConfigureUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 151);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.BirthYearLbl);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConfigureUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.ConfigureUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label BirthYearLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.ComboBox GenderBox;
        public  System.Windows.Forms.Button Cancel_btn;
    }
}