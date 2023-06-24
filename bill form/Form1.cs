using bill_form.US_Forms;
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

namespace bill_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private void addUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Dashboard";
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Search Page";
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            uc_bill objUcBill = new uc_bill();
            addUserControl(objUcBill);
            ucHeading.Text = "Billing Page";
        }

        private void btnInvent_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Inventory Page";
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Sales Page";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Stock Page";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ucHeading.Text = "Orders Page";
        }
    }
}
