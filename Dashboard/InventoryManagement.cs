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
    public partial class InventoryManagement : UserControl
    {
       
        public InventoryManagement()
        {
            InitializeComponent();
        }

       
        private void btnaddproduct_Click(object sender, EventArgs e)
        {
           AddProduct1 objaddp = new AddProduct1();

            objaddp.Show();
            
        }

        private void btnsearchproduct_Click(object sender, EventArgs e) //search product by product id and name
        {
            try
            {
                int proid = int.Parse(txtPROID.Text);
                string proname = txtPRONAME.Text;
                string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

                string qry = "Select [Product ID],[Product Name],[Brand],[Size],[Buy Price],[Sell Price] From Product WHERE [Product ID]=@proid AND [Product Name]=@proname";




                SqlConnection conn = new SqlConnection(connectionstring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(qry, conn);

                cmd.Parameters.AddWithValue("@proid ", proid);
                cmd.Parameters.AddWithValue("@proname", proname);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds, "Product");

                productgrid.DataSource = ds.Tables["Product"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
            
        }

        private void InventoryManagement_Load(object sender, EventArgs e) //load the database
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

            string qry = "Select [Product ID],[Product Name],[Brand],[Size],[Buy Price],[Sell Price] From Product";

            SqlDataAdapter da = new SqlDataAdapter(qry, connectionstring);

            DataSet ds = new DataSet();

            da.Fill(ds,"Product");

            productgrid.DataSource = ds.Tables["Product"];



        }

        private void productgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (productgrid.Columns[e.ColumnIndex].HeaderText == "Delete")  //delete button function
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete the record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(confirm == DialogResult.Yes)
                    {
                        int selecid;
                        selecid = Convert.ToInt32(productgrid.Rows[e.RowIndex].Cells["ProIdColumn"].Value);

                        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

                        string qry = "Delete From Product Where [Product ID]=@code";

                        SqlConnection conn = new SqlConnection(connectionstring);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(qry, conn);
                        cmd.Parameters.AddWithValue("@code", selecid);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    
                }
                if (productgrid.Columns[e.ColumnIndex].HeaderText == "Update")  //update button function
                {
                    int id,psize; string pname,pbrand; decimal buyprice, sellprice;
                    id = Convert.ToInt32(productgrid.Rows[e.RowIndex].Cells["ProIdColumn"].Value);
                    pname = Convert.ToString(productgrid.Rows[e.RowIndex].Cells["nameColumn"].Value);
                    pbrand = Convert.ToString(productgrid.Rows[e.RowIndex].Cells["brandcolumn"].Value);
                    psize = Convert.ToInt32(productgrid.Rows[e.RowIndex].Cells["sizeColumn"].Value);
                    buyprice = Convert.ToDecimal(productgrid.Rows[e.RowIndex].Cells["buypriceColumn"].Value);
                    sellprice = Convert.ToDecimal(productgrid.Rows[e.RowIndex].Cells["sellpriceColumn"].Value);

                    updateproductcs objuppro = new updateproductcs(id, pname,pbrand, psize,buyprice, sellprice);
                    objuppro.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
