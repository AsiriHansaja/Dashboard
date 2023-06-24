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
using System.Threading;

namespace Dashboard
{
    public partial class AddProduct1 : Form
    {
        public AddProduct1()
        {
            InitializeComponent();
        }     

        private void btnsubmitproduct_Click(object sender, EventArgs e)   //passing data to the database
        {
            if(string.IsNullOrEmpty(txtProId.Text)|| string.IsNullOrEmpty(txtSellPrice.Text) || string.IsNullOrEmpty(txtBuyPrice.Text) || string.IsNullOrEmpty(txtProName.Text) || string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtproductDesc.Text) || string.IsNullOrEmpty(txtsize.Text))
            {
                MessageBox.Show("All the fields should be filled");
            }
            else
            {
                try
                {
                    int ProID = int.Parse(txtProId.Text);
                    decimal sellprice = decimal.Parse(txtSellPrice.Text);
                    decimal buyprice = decimal.Parse(txtBuyPrice.Text);
                    string Proname = txtProName.Text;
                    string brand = txtBrand.Text;
                    string ProDesc = txtproductDesc.Text;
                    int psize = int.Parse(txtsize.Text);

                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string qry = "INSERT INTO Product([Product ID],[Product Name],[Brand],[Size],[Sell Price],[Buy Price],[Product Description]) VALUES (@ProID, @Proname, @brand,@psize ,@Psellprice, @buyprice, @ProDesc)";

                        using (SqlCommand cmd = new SqlCommand(qry, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProID", ProID);
                            cmd.Parameters.AddWithValue("@Proname", Proname);
                            cmd.Parameters.AddWithValue("@brand", brand);
                            cmd.Parameters.AddWithValue("@Psellprice", sellprice);
                            cmd.Parameters.AddWithValue("@buyprice", buyprice);
                            cmd.Parameters.AddWithValue("@ProDesc", ProDesc);
                            cmd.Parameters.AddWithValue("@psize", psize);

                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data inserted successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message, "Error");
                            }
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                
            }
        }
    }
}

