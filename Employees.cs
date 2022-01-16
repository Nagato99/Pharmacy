using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pharmacy
{
    public partial class Employees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Employee_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            EmployeeGridView.ReadOnly = true;
            EmployeeGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            if (empidtb.Text == "" || empnametb.Text == "" || empagetb.Text == "" || empsaltb.Text == "" || empphometb.Text == "" || emppasswordtb.Text=="")
            {
                MessageBox.Show("Missing data! Please fill all the information.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee_tbl values('" + empidtb.Text + "', '" + empnametb.Text + "', " + empsaltb.Text + ", " + empagetb.Text + ", '" + empphometb.Text + "', '"+emppasswordtb.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee successfully added!");
                Con.Close();
                populate();
            }
        }

        private void EmployeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empidtb.Text = EmployeeGridView.SelectedRows[0].Cells[0].Value.ToString();
            empnametb.Text = EmployeeGridView.SelectedRows[0].Cells[1].Value.ToString();
            empsaltb.Text = EmployeeGridView.SelectedRows[0].Cells[2].Value.ToString();
            empagetb.Text = EmployeeGridView.SelectedRows[0].Cells[3].Value.ToString();
            empphometb.Text = EmployeeGridView.SelectedRows[0].Cells[4].Value.ToString();
            emppasswordtb.Text = EmployeeGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void UpdateEmpbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Employee_tbl SET EmpName = '" + empnametb.Text + "', EmpSalary = " + empsaltb.Text + ", EmpAge = " + empagetb.Text + "," + " EmpPhone = '" + empphometb.Text + "', EmpPassword = '" + emppasswordtb.Text + "' WHERE EmpID = '" + empidtb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee updated successfully!");
            Con.Close();
            populate();
        }

        private void DelEmpbtn_Click(object sender, EventArgs e)
        {
            if (empidtb.Text == "")
            {
                MessageBox.Show("Invalid operation! Please select first an employee to be deleted!");
            }
            else
            {
                Con.Open();
                string Myquery = "delete from Employee_tbl where EmpID = '" + empidtb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully!");
                Con.Close();
                populate();
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
