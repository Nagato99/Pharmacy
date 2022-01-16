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
    public partial class Company : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanyGridView.ReadOnly = true;
            CompanyGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Company()
        {
            InitializeComponent();
        }

        private void compnametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanyLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddCompbtn_Click(object sender, EventArgs e)
        {
            if (compIdtb.Text == "" || compNametb.Text == "" || compPhonetb.Text == "" || compAddresstb.Text == "" )
            {
                MessageBox.Show("Missing data! Please fill all the information.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tbl values('" + compIdtb.Text + "', '" + compNametb.Text + "', '" + compPhonetb.Text + "', '" + compAddresstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company successfully added!");
                Con.Close();
                populate();
            }
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateCompbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Company_tbl SET CompName = '" + compNametb.Text + "', CompPhone = '" + compPhonetb.Text + "', CompAddress = '" + compAddresstb.Text + "' WHERE CompanyID = '" + compIdtb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company updated successfully!");
            Con.Close();
            populate();
        }

        private void CompanyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            compIdtb.Text = CompanyGridView.SelectedRows[0].Cells[0].Value.ToString();
            compNametb.Text = CompanyGridView.SelectedRows[0].Cells[1].Value.ToString();
            compPhonetb.Text = CompanyGridView.SelectedRows[0].Cells[2].Value.ToString();
            compAddresstb.Text = CompanyGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DelCompbtn_Click(object sender, EventArgs e)
        {
            if (compIdtb.Text == "")
            {
                MessageBox.Show("Invalid operation! Please select first a company to be deleted!");
            }
            else
            {
                Con.Open();
                string Myquery = "delete from Company_tbl where CompanyID = '" + compIdtb.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company deleted successfully!");
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
