using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class ucdashboard : UserControl
    {
        public ucdashboard()
        {
            InitializeComponent();
            Load += UserControl1_Load;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            timer1.Start(); //time 

            //recent orders
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

            string qry = "Select * From Orders Order By [Order Date] Desc;";

            SqlDataAdapter daa = new SqlDataAdapter(qry, connectionstring);

            DataSet dss = new DataSet();

            daa.Fill(dss, "Orders");

            recentordersgrid.DataSource = dss.Tables["Orders"];

            //to get the number of orders
            try
            {
                
                string qrry = "SELECT COUNT(*) FROM Orders";

                SqlConnection connection = new SqlConnection(connectionstring);
                
                SqlCommand command = new SqlCommand(qrry, connection);
                connection.Open();

                int recordCount = (int)command.ExecuteScalar();

                lblorders.Text = recordCount.ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToLongDateString();
        }

        private void lblorders_Click(object sender, EventArgs e)
        {
            

        }
    }
}
