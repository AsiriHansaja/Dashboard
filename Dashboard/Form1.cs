using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



namespace Dashboard
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
            
        }
     
        ucdashboard objucdash = new ucdashboard();
       

        public void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AddUserControl(objucdash);
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

        }

        private void btnorders_Click_1(object sender, EventArgs e)
        {
            orders objord = new orders();
            AddUserControl(objord);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            AddUserControl(objucdash);
        }

        private void btnstocks_Click_1(object sender, EventArgs e)
        {
            Stock objst = new Stock();
            AddUserControl(objst);
        }

        private void btninventory_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnsearchitem_Click(object sender, EventArgs e)
        {
            
        }

    }
}

