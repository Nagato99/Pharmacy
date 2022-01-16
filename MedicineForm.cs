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

    public partial class MedicineForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Medicine_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public MedicineForm()
        {
            InitializeComponent();
        }

        public void fillcombobox()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CompName from Company_tbl", Con);
            SqlDataReader rdr;
            DataTable dt = new DataTable();
            dt.Columns.Add("CompName", typeof(string));
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            Companyt.ValueMember = "CompName";
            Companyt.DataSource = dt;
            Con.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedName.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            bprice.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            Sprice.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            qty.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
           // Companyt.Text = MedicineGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "")
            {
                MessageBox.Show("Invalid operation! Please select first a medicine to be deleted!");
            }
            else
            { 
                Con.Open();
                string Myquery = "delete from Medicine_tbl where MedName = '" + MedName.Text + "';";
                SqlCommand cmd = new SqlCommand(Myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine deleted successfully!");
                Con.Close();
                populate();
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            if (MedName.Text == "" || Sprice.Text == "" || bprice.Text == "" || qty.Text == "" || Companyt.SelectedItem == null)
            {
                MessageBox.Show("Missing data! Please fill all the information.");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + MedName.Text + "', " + bprice.Text + ", " + Sprice.Text + ", " + qty.Text + "," +
                    " '" + ExpireDate.Text + "', '" + Companyt.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine successful added!");
                Con.Close();
                populate();
            }
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombobox();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Medicine_tbl SET BuyPrice = " + bprice.Text + ", SellPrice = " + Sprice.Text + ", MedQty = " + qty.Text + "," + " ExpDate = '" + ExpireDate.Text + "', Company = '" + Companyt.Text + "' WHERE MedName = '" + MedName.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine updated successfully!");
            Con.Close();
            populate();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void Companyt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

