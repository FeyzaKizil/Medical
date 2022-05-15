namespace SymptomChecker
{
    partial class ShowPharmacies
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
            this.label1 = new System.Windows.Forms.Label();
            this.city_comboBox = new System.Windows.Forms.ComboBox();
            this.district_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pharmacies_dataGridView = new System.Windows.Forms.DataGridView();
            this.show_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacies_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // city_comboBox
            // 
            this.city_comboBox.FormattingEnabled = true;
            this.city_comboBox.Location = new System.Drawing.Point(105, 54);
            this.city_comboBox.Name = "city_comboBox";
            this.city_comboBox.Size = new System.Drawing.Size(176, 24);
            this.city_comboBox.TabIndex = 1;
            this.city_comboBox.SelectedIndexChanged += new System.EventHandler(this.city_comboBox_SelectedIndexChanged);
            // 
            // district_comboBox
            // 
            this.district_comboBox.FormattingEnabled = true;
            this.district_comboBox.Location = new System.Drawing.Point(105, 123);
            this.district_comboBox.Name = "district_comboBox";
            this.district_comboBox.Size = new System.Drawing.Size(176, 24);
            this.district_comboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "District";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pharmacies_dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(316, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 383);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pharmicies On Duty";
            // 
            // pharmacies_dataGridView
            // 
            this.pharmacies_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacies_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacies_dataGridView.Location = new System.Drawing.Point(3, 18);
            this.pharmacies_dataGridView.Name = "pharmacies_dataGridView";
            this.pharmacies_dataGridView.RowHeadersWidth = 51;
            this.pharmacies_dataGridView.RowTemplate.Height = 24;
            this.pharmacies_dataGridView.Size = new System.Drawing.Size(816, 362);
            this.pharmacies_dataGridView.TabIndex = 0;
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(105, 181);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(176, 23);
            this.show_btn.TabIndex = 5;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // SelectLocationForPharmacies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1150, 430);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.district_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.city_comboBox);
            this.Controls.Add(this.label1);
            this.Name = "SelectLocationForPharmacies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectLocationForPharmacies";
            this.Load += new System.EventHandler(this.SelectLocationForPharmacies_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacies_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox city_comboBox;
        private System.Windows.Forms.ComboBox district_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView pharmacies_dataGridView;
        private System.Windows.Forms.Button show_btn;
    }
}