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

namespace Dashboard
{
    public partial class SearchItem : UserControl
    {
        public SearchItem()
        {
            InitializeComponent();
        }

        private void SearchItem_Load(object sender, EventArgs e)
        {

            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";
            string qry = "SELECT [Product ID],[Product Name],[Brand],[Size],[Stocks] FROM Product";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(qry, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds,"Product");
                    searchitemgrid.DataSource = ds.Tables["Product"];

                    cmd.ExecuteNonQuery();
                }
                
            }

            


        }

        private void btnsearchitem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPName.Text)|| string.IsNullOrEmpty(txtProID.Text) || string.IsNullOrEmpty(txtSize.Text))
            {
                MessageBox.Show("All the fields have to be filled");
            }
            else
            {
                string proname = txtPName.Text;
                int proid = int.Parse(txtProID.Text);
                int psize = int.Parse(txtSize.Text);

                string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";
                string qry = "SELECT [Product ID],[Product Name],[Brand],[Size],[Stocks] FROM Product WHERE [Product ID]=@proid AND [Product Name]=@proname AND [Size]=@psize";

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(qry, conn))
                    {
                        cmd.Parameters.AddWithValue("@proid", proid);
                        cmd.Parameters.AddWithValue("@proname", proname);
                        cmd.Parameters.AddWithValue("@psize", psize);


                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        da.Fill(ds, "Product");
                        searchitemgrid.DataSource = ds.Tables["Product"];

                        cmd.ExecuteNonQuery();
                    }

                }
            }
            
        }
    }
}
