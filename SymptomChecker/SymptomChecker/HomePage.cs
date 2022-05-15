using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymptomChecker
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pharmacies_btn_Click(object sender, EventArgs e)
        {
            ShowPharmacies selectLocationForPharmacies = new ShowPharmacies();
            selectLocationForPharmacies.Show();
        }

        private void symptomChecker_btn_Click(object sender, EventArgs e)
        {
            SymptomCheck app = new SymptomCheck();
            app.Show();
        }
    }
}
