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
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }

        private void btnsuppliersubmit_Click(object sender, EventArgs e)
        {
            try
            {
                int SId = int.Parse(txtSId.Text);
                string SName = txtSName.Text;
                string SAddress = txtSAddress.Text;   //Supplier Details
                string SEmail = txtSEmail.Text;
                int Sphone = int.Parse(txtSPhone.Text);

                string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";
                string qry1 = "Insert Into Supplier Values(@SId,@SName,@SAddress,@SEmail,@Sphone)";

                SqlConnection conn = new SqlConnection(connectionstring);
                SqlCommand cmd = new SqlCommand(qry1, conn);

                cmd.Parameters.AddWithValue("@SId", SId);
                cmd.Parameters.AddWithValue("@SName", SName);
                cmd.Parameters.AddWithValue("@SAddress", SAddress);
                cmd.Parameters.AddWithValue("@SEmail", SEmail);
                cmd.Parameters.AddWithValue("@Sphone", Sphone);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception exy)
            {
                MessageBox.Show(exy.Message);
            }
           
        }
    }
}
