
namespace Pharmacy
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.BillGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillingLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.AddBillbtn = new Guna.UI2.WinForms.Guna2Button();
            this.QtyBill = new Bunifu.UI.WinForms.BunifuTextBox();
            this.totalamount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteMedicine = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillGridView
            // 
            this.BillGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillGridView.BackgroundColor = System.Drawing.Color.White;
            this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedID,
            this.MedName,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillGridView.EnableHeadersVisualStyles = false;
            this.BillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.Location = new System.Drawing.Point(493, 12);
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.RowTemplate.Height = 30;
            this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGridView.Size = new System.Drawing.Size(679, 426);
            this.BillGridView.TabIndex = 21;
            this.BillGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.BillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.BillGridView.ThemeStyle.ReadOnly = false;
            this.BillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.ThemeStyle.RowsStyle.Height = 30;
            this.BillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BillGridView_CellContentClick);
            // 
            // MedID
            // 
            this.MedID.HeaderText = "MedID";
            this.MedID.Name = "MedID";
            // 
            // MedName
            // 
            this.MedName.HeaderText = "MedName";
            this.MedName.Name = "MedName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // BillingLabel
            // 
            this.BillingLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingLabel.ForeColor = System.Drawing.Color.Green;
            this.BillingLabel.Location = new System.Drawing.Point(140, 37);
            this.BillingLabel.Name = "BillingLabel";
            this.BillingLabel.Size = new System.Drawing.Size(210, 44);
            this.BillingLabel.TabIndex = 22;
            this.BillingLabel.Text = "Billing Form";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(183, 230);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(102, 17);
            this.StockLabel.TabIndex = 24;
            this.StockLabel.Text = "Available Stock";
            this.StockLabel.Visible = false;
            // 
            // AddBillbtn
            // 
            this.AddBillbtn.BorderRadius = 15;
            this.AddBillbtn.CheckedState.Parent = this.AddBillbtn;
            this.AddBillbtn.CustomImages.Parent = this.AddBillbtn;
            this.AddBillbtn.FillColor = System.Drawing.Color.Green;
            this.AddBillbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBillbtn.ForeColor = System.Drawing.Color.White;
            this.AddBillbtn.HoverState.Parent = this.AddBillbtn;
            this.AddBillbtn.Location = new System.Drawing.Point(69, 306);
            this.AddBillbtn.Name = "AddBillbtn";
            this.AddBillbtn.ShadowDecoration.Parent = this.AddBillbtn;
            this.AddBillbtn.Size = new System.Drawing.Size(93, 45);
            this.AddBillbtn.TabIndex = 26;
            this.AddBillbtn.Text = "Add To Bill";
            this.AddBillbtn.Click += new System.EventHandler(this.AddBillbtn_Click);
            // 
            // QtyBill
            // 
            this.QtyBill.AcceptsReturn = false;
            this.QtyBill.AcceptsTab = false;
            this.QtyBill.AnimationSpeed = 200;
            this.QtyBill.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.QtyBill.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.QtyBill.AutoSizeHeight = true;
            this.QtyBill.BackColor = System.Drawing.Color.Transparent;
            this.QtyBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QtyBill.BackgroundImage")));
            this.QtyBill.BorderColorActive = System.Drawing.Color.Green;
            this.QtyBill.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.QtyBill.BorderColorHover = System.Drawing.Color.Green;
            this.QtyBill.BorderColorIdle = System.Drawing.Color.Silver;
            this.QtyBill.BorderRadius = 1;
            this.QtyBill.BorderThickness = 1;
            this.QtyBill.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.QtyBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyBill.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyBill.DefaultText = "";
            this.QtyBill.FillColor = System.Drawing.Color.White;
            this.QtyBill.HideSelection = true;
            this.QtyBill.IconLeft = null;
            this.QtyBill.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyBill.IconPadding = 10;
            this.QtyBill.IconRight = null;
            this.QtyBill.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.QtyBill.Lines = new string[0];
            this.QtyBill.Location = new System.Drawing.Point(274, 140);
            this.QtyBill.MaxLength = 32767;
            this.QtyBill.MinimumSize = new System.Drawing.Size(1, 1);
            this.QtyBill.Modified = false;
            this.QtyBill.Multiline = false;
            this.QtyBill.Name = "QtyBill";
            stateProperties1.BorderColor = System.Drawing.Color.Green;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QtyBill.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.QtyBill.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Green;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QtyBill.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.QtyBill.OnIdleState = stateProperties4;
            this.QtyBill.Padding = new System.Windows.Forms.Padding(3);
            this.QtyBill.PasswordChar = '\0';
            this.QtyBill.PlaceholderForeColor = System.Drawing.Color.Green;
            this.QtyBill.PlaceholderText = "Quantity";
            this.QtyBill.ReadOnly = false;
            this.QtyBill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QtyBill.SelectedText = "";
            this.QtyBill.SelectionLength = 0;
            this.QtyBill.SelectionStart = 0;
            this.QtyBill.ShortcutsEnabled = true;
            this.QtyBill.Size = new System.Drawing.Size(156, 37);
            this.QtyBill.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.QtyBill.TabIndex = 27;
            this.QtyBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QtyBill.TextMarginBottom = 0;
            this.QtyBill.TextMarginLeft = 3;
            this.QtyBill.TextMarginTop = 1;
            this.QtyBill.TextPlaceholder = "Quantity";
            this.QtyBill.UseSystemPasswordChar = false;
            this.QtyBill.WordWrap = true;
            // 
            // totalamount
            // 
            this.totalamount.BackColor = System.Drawing.Color.Transparent;
            this.totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.ForeColor = System.Drawing.Color.Green;
            this.totalamount.Location = new System.Drawing.Point(719, 497);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(236, 44);
            this.totalamount.TabIndex = 28;
            this.totalamount.Text = "Total Amount";
            // 
            // Printbtn
            // 
            this.Printbtn.BorderRadius = 15;
            this.Printbtn.CheckedState.Parent = this.Printbtn;
            this.Printbtn.CustomImages.Parent = this.Printbtn;
            this.Printbtn.FillColor = System.Drawing.Color.Green;
            this.Printbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.ForeColor = System.Drawing.Color.White;
            this.Printbtn.HoverState.Parent = this.Printbtn;
            this.Printbtn.Location = new System.Drawing.Point(299, 306);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.ShadowDecoration.Parent = this.Printbtn;
            this.Printbtn.Size = new System.Drawing.Size(93, 45);
            this.Printbtn.TabIndex = 29;
            this.Printbtn.Text = "Print";
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Green;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(299, 410);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(93, 45);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DeleteMedicine
            // 
            this.DeleteMedicine.BorderRadius = 15;
            this.DeleteMedicine.CheckedState.Parent = this.DeleteMedicine;
            this.DeleteMedicine.CustomImages.Parent = this.DeleteMedicine;
            this.DeleteMedicine.FillColor = System.Drawing.Color.Green;
            this.DeleteMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMedicine.ForeColor = System.Drawing.Color.White;
            this.DeleteMedicine.HoverState.Parent = this.DeleteMedicine;
            this.DeleteMedicine.Location = new System.Drawing.Point(69, 410);
            this.DeleteMedicine.Name = "DeleteMedicine";
            this.DeleteMedicine.ShadowDecoration.Parent = this.DeleteMedicine;
            this.DeleteMedicine.Size = new System.Drawing.Size(93, 45);
            this.DeleteMedicine.TabIndex = 31;
            this.DeleteMedicine.Text = "Delete";
            this.DeleteMedicine.Click += new System.EventHandler(this.DeleteMedicine_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.DeleteMedicine);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.QtyBill);
            this.Controls.Add(this.AddBillbtn);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BillingLabel);
            this.Controls.Add(this.BillGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView BillGridView;
        private Guna.UI2.WinForms.Guna2HtmlLabel BillingLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label StockLabel;
        private Guna.UI2.WinForms.Guna2Button AddBillbtn;
        private Bunifu.UI.WinForms.BunifuTextBox QtyBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalamount;
        private Guna.UI2.WinForms.Guna2Button Printbtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button DeleteMedicine;
    }
}