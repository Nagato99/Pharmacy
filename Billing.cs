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
    public partial class Billing : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nagato\Documents\Pharmacy_db.mdf;Integrated Security=True;Connect Timeout=30");

        int x, unitp;

        public void fetchQty()
        {
            Con.Open();
            string mysql = "select * from Medicine_tbl where MedName = '" + comboBox1.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["MedQty"].ToString());
                unitp = Convert.ToInt32(dr["SellPrice"].ToString());
                StockLabel.Text = "Available stock is " + dr["MedQty"].ToString();
                StockLabel.Visible = true;
            }
            Con.Close();
        }

        public void updateMedicine()
        {
            int newQty = x - Convert.ToInt32(QtyBill.Text);
            Con.Open();
            string Myquery = "UPDATE Medicine_tbl SET MedQty = " + newQty + " WHERE MedName = '" + comboBox1.SelectedValue.ToString() + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            // MessageBox.Show("Medicine updated successfully!");
            Con.Close();
        }

        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MedName from Medicine_tbl", Con);
            SqlDataReader rdr;
            DataTable dt = new DataTable();
            dt.Columns.Add("MedName", typeof(string));
            rdr = cmd.ExecuteReader();
            dt.Load(rdr);
            comboBox1.ValueMember = "MedName";
            comboBox1.DataSource = dt;
            Con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        int GrdTotal = 0;

        Bitmap bitmap;
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // printDocument1.DefaultPageSettings.Landscape = true;
            e.Graphics.DrawImage(bitmap, -500, 0);
            //e.Graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height), new Rectangle(20, 20, 100, 100), GraphicsUnit.Pixel);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void BillGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteMedicine_Click(object sender, EventArgs e)
        {
            if (this.BillGridView.SelectedRows.Count > 0)
            {
                BillGridView.Rows.RemoveAt(this.BillGridView.SelectedRows[0].Index);
            }
        }

        private void AddBillbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (QtyBill.Text == "" || Convert.ToInt32(QtyBill.Text) > x || Convert.ToInt32(QtyBill.Text) <=0)
            {
                MessageBox.Show("Invalid value! Please verify the stock.");
            }
            else
            {
                int total = Convert.ToInt32(QtyBill.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = QtyBill.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(QtyBill.Text);
                BillGridView.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                totalamount.Text = "Total: " + GrdTotal;
                updateMedicine();
            }
        }
    }
}
