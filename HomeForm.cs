using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void Exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        MedicineForm MedForm = new MedicineForm();
        private void MedButton_Click(object sender, EventArgs e)
        {
           
            MedForm.Show();
            this.Hide();
        }
        Employees EmpForm = new Employees();

        private void EmpButton_Click(object sender, EventArgs e)
        {
            EmpForm.Show();
            this.Hide();
        }

        Company CompForm = new Company();
        private void CompButton_Click(object sender, EventArgs e)
        {
            CompForm.Show();
            this.Hide();
        }

        Billing BillForm = new Billing();
        private void BillingButton_Click(object sender, EventArgs e)
        {
            BillForm.Show();
            this.Hide();
        }

        private void LogoffButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
