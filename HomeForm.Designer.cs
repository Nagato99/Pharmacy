
namespace Pharmacy
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.Menulbl = new System.Windows.Forms.Label();
            this.Medicinelbl = new System.Windows.Forms.Label();
            this.Billinglbl = new System.Windows.Forms.Label();
            this.Companylbl = new System.Windows.Forms.Label();
            this.Employeelbl = new System.Windows.Forms.Label();
            this.MedButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.EmpButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.CompButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BillingButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LogoffButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Exitlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menulbl
            // 
            this.Menulbl.AutoSize = true;
            this.Menulbl.BackColor = System.Drawing.Color.Transparent;
            this.Menulbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menulbl.ForeColor = System.Drawing.Color.White;
            this.Menulbl.Location = new System.Drawing.Point(524, 47);
            this.Menulbl.Name = "Menulbl";
            this.Menulbl.Size = new System.Drawing.Size(161, 32);
            this.Menulbl.TabIndex = 0;
            this.Menulbl.Text = "MAIN MENU";
            // 
            // Medicinelbl
            // 
            this.Medicinelbl.AutoSize = true;
            this.Medicinelbl.BackColor = System.Drawing.Color.Transparent;
            this.Medicinelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicinelbl.ForeColor = System.Drawing.Color.White;
            this.Medicinelbl.Location = new System.Drawing.Point(71, 160);
            this.Medicinelbl.Name = "Medicinelbl";
            this.Medicinelbl.Size = new System.Drawing.Size(120, 32);
            this.Medicinelbl.TabIndex = 1;
            this.Medicinelbl.Text = "Medicine";
            // 
            // Billinglbl
            // 
            this.Billinglbl.AutoSize = true;
            this.Billinglbl.BackColor = System.Drawing.Color.Transparent;
            this.Billinglbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billinglbl.ForeColor = System.Drawing.Color.White;
            this.Billinglbl.Location = new System.Drawing.Point(1007, 390);
            this.Billinglbl.Name = "Billinglbl";
            this.Billinglbl.Size = new System.Drawing.Size(88, 32);
            this.Billinglbl.TabIndex = 2;
            this.Billinglbl.Text = "Billing";
            // 
            // Companylbl
            // 
            this.Companylbl.AutoSize = true;
            this.Companylbl.BackColor = System.Drawing.Color.Transparent;
            this.Companylbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Companylbl.ForeColor = System.Drawing.Color.White;
            this.Companylbl.Location = new System.Drawing.Point(977, 160);
            this.Companylbl.Name = "Companylbl";
            this.Companylbl.Size = new System.Drawing.Size(141, 32);
            this.Companylbl.TabIndex = 3;
            this.Companylbl.Text = "Companies";
            // 
            // Employeelbl
            // 
            this.Employeelbl.AutoSize = true;
            this.Employeelbl.BackColor = System.Drawing.Color.Transparent;
            this.Employeelbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employeelbl.ForeColor = System.Drawing.Color.White;
            this.Employeelbl.Location = new System.Drawing.Point(54, 390);
            this.Employeelbl.Name = "Employeelbl";
            this.Employeelbl.Size = new System.Drawing.Size(137, 32);
            this.Employeelbl.TabIndex = 4;
            this.Employeelbl.Text = "Employees";
            // 
            // MedButton
            // 
            this.MedButton.BackColor = System.Drawing.Color.Transparent;
            this.MedButton.CheckedState.Parent = this.MedButton;
            this.MedButton.HoverState.Parent = this.MedButton;
            this.MedButton.Image = ((System.Drawing.Image)(resources.GetObject("MedButton.Image")));
            this.MedButton.ImageSize = new System.Drawing.Size(90, 90);
            this.MedButton.Location = new System.Drawing.Point(77, 228);
            this.MedButton.Name = "MedButton";
            this.MedButton.PressedState.Parent = this.MedButton;
            this.MedButton.Size = new System.Drawing.Size(96, 89);
            this.MedButton.TabIndex = 9;
            this.MedButton.Click += new System.EventHandler(this.MedButton_Click);
            // 
            // EmpButton
            // 
            this.EmpButton.BackColor = System.Drawing.Color.Transparent;
            this.EmpButton.CheckedState.Parent = this.EmpButton;
            this.EmpButton.HoverState.Parent = this.EmpButton;
            this.EmpButton.Image = ((System.Drawing.Image)(resources.GetObject("EmpButton.Image")));
            this.EmpButton.ImageSize = new System.Drawing.Size(90, 90);
            this.EmpButton.Location = new System.Drawing.Point(77, 448);
            this.EmpButton.Name = "EmpButton";
            this.EmpButton.PressedState.Parent = this.EmpButton;
            this.EmpButton.Size = new System.Drawing.Size(96, 89);
            this.EmpButton.TabIndex = 10;
            this.EmpButton.Click += new System.EventHandler(this.EmpButton_Click);
            // 
            // CompButton
            // 
            this.CompButton.BackColor = System.Drawing.Color.Transparent;
            this.CompButton.CheckedState.Parent = this.CompButton;
            this.CompButton.HoverState.Parent = this.CompButton;
            this.CompButton.Image = ((System.Drawing.Image)(resources.GetObject("CompButton.Image")));
            this.CompButton.ImageSize = new System.Drawing.Size(90, 90);
            this.CompButton.Location = new System.Drawing.Point(999, 228);
            this.CompButton.Name = "CompButton";
            this.CompButton.PressedState.Parent = this.CompButton;
            this.CompButton.Size = new System.Drawing.Size(96, 89);
            this.CompButton.TabIndex = 11;
            this.CompButton.Click += new System.EventHandler(this.CompButton_Click);
            // 
            // BillingButton
            // 
            this.BillingButton.BackColor = System.Drawing.Color.Transparent;
            this.BillingButton.CheckedState.Parent = this.BillingButton;
            this.BillingButton.HoverState.Parent = this.BillingButton;
            this.BillingButton.Image = ((System.Drawing.Image)(resources.GetObject("BillingButton.Image")));
            this.BillingButton.ImageSize = new System.Drawing.Size(90, 90);
            this.BillingButton.Location = new System.Drawing.Point(999, 448);
            this.BillingButton.Name = "BillingButton";
            this.BillingButton.PressedState.Parent = this.BillingButton;
            this.BillingButton.Size = new System.Drawing.Size(96, 89);
            this.BillingButton.TabIndex = 12;
            this.BillingButton.Click += new System.EventHandler(this.BillingButton_Click);
            // 
            // LogoffButton
            // 
            this.LogoffButton.BackColor = System.Drawing.Color.Transparent;
            this.LogoffButton.CheckedState.Parent = this.LogoffButton;
            this.LogoffButton.HoverState.Parent = this.LogoffButton;
            this.LogoffButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoffButton.Image")));
            this.LogoffButton.ImageSize = new System.Drawing.Size(70, 70);
            this.LogoffButton.Location = new System.Drawing.Point(575, 535);
            this.LogoffButton.Name = "LogoffButton";
            this.LogoffButton.PressedState.Parent = this.LogoffButton;
            this.LogoffButton.Size = new System.Drawing.Size(69, 65);
            this.LogoffButton.TabIndex = 13;
            this.LogoffButton.Click += new System.EventHandler(this.LogoffButton_Click);
            // 
            // Exitlbl
            // 
            this.Exitlbl.AutoSize = true;
            this.Exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.Exitlbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitlbl.ForeColor = System.Drawing.Color.Red;
            this.Exitlbl.Location = new System.Drawing.Point(1111, 23);
            this.Exitlbl.Name = "Exitlbl";
            this.Exitlbl.Size = new System.Drawing.Size(27, 30);
            this.Exitlbl.TabIndex = 14;
            this.Exitlbl.Text = "X";
            this.Exitlbl.Click += new System.EventHandler(this.Exitlbl_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 612);
            this.Controls.Add(this.Exitlbl);
            this.Controls.Add(this.LogoffButton);
            this.Controls.Add(this.BillingButton);
            this.Controls.Add(this.CompButton);
            this.Controls.Add(this.EmpButton);
            this.Controls.Add(this.MedButton);
            this.Controls.Add(this.Employeelbl);
            this.Controls.Add(this.Companylbl);
            this.Controls.Add(this.Billinglbl);
            this.Controls.Add(this.Medicinelbl);
            this.Controls.Add(this.Menulbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menulbl;
        private System.Windows.Forms.Label Medicinelbl;
        private System.Windows.Forms.Label Billinglbl;
        private System.Windows.Forms.Label Companylbl;
        private System.Windows.Forms.Label Employeelbl;
        private Guna.UI2.WinForms.Guna2ImageButton MedButton;
        private Guna.UI2.WinForms.Guna2ImageButton EmpButton;
        private Guna.UI2.WinForms.Guna2ImageButton CompButton;
        private Guna.UI2.WinForms.Guna2ImageButton BillingButton;
        private Guna.UI2.WinForms.Guna2ImageButton LogoffButton;
        private System.Windows.Forms.Label Exitlbl;
    }
}