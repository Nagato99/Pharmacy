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
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }
        HomeForm home = new HomeForm();

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //HomeForm home = new HomeForm();
            //if (Username.Text == "Admin" && Password.Text == "admin")
            //{
            //    home.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong Username of Password!");
            //}
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Employee_tbl where EmpName = '" + Username.Text + "' and EmpPassword = '" + Password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username of Password!");
            }
            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Loginbutton;
        }
    }
}
