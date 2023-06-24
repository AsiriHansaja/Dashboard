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
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }
        private void login_Click_1(object sender, EventArgs e)
        {
            string uname = txtname.Text;
            var pass = txtpassword.Text;

            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

            try
            {
                string qry = "SELECT* FROM [User] WHERE (Username = '" + uname + "' AND Password = '" + pass + "')";

                SqlDataAdapter da = new SqlDataAdapter(qry, connectionstring);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    uname = txtname.Text;
                    pass = txtpassword.Text;

                    Form1 objform1 = new Form1();
                    objform1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signup_Click_1(object sender, EventArgs e)
        {
            registerform objreg = new registerform();
            objreg.Show();

            this.Hide();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
}

