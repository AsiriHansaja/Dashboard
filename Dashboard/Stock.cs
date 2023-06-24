using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Dashboard
{
    public partial class Stock : UserControl
    {
        public Stock()
        {
            InitializeComponent();
            txtSPrice.TextChanged += txtSPrice_TextChanged;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtDiscount.TextChanged += FinalValue;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime OrderTime = DateTime.Now;
            dtstockdate.Value = DateTime.Now;
        }

        private void txtSPrice_TextChanged(object sender, EventArgs e)
        {
            calcmult();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calcmult();
        }

        private void calcmult()
        {
            if (decimal.TryParse(txtSPrice.Text, out decimal SalesPrice) && decimal.TryParse(txtQuantity.Text, out decimal Pquantity))
            {
                decimal mult = SalesPrice * Pquantity;
                lbltotal.Text = mult.ToString();
            }
        }

        private void FinalValue(object sender, EventArgs e)
        {
            calcfinal();
        }

        private void calcfinal()
        {
            if(decimal.TryParse(txtSPrice.Text, out decimal SalesPrice) && decimal.TryParse(txtQuantity.Text, out decimal Pquantity) && int.TryParse(txtDiscount.Text, out int Discount))
            {
                decimal disc = (SalesPrice *Pquantity) * (decimal)Discount/100;
                decimal final = (SalesPrice * Pquantity) - disc;
                lblfinalprice.Text = final.ToString();
            }
        }
        private void btnsubmitstock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSId.Text) || string.IsNullOrWhiteSpace(txtOrderID.Text) || string.IsNullOrWhiteSpace(txtPId.Text) || string.IsNullOrWhiteSpace(txtSPrice.Text) || string.IsNullOrWhiteSpace(txtQuantity.Text) || string.IsNullOrWhiteSpace(txtsize.Text))
            {  
                 MessageBox.Show("Please fill in all the fields.");
            }
            else
            {
                int SId = int.Parse(txtSId.Text);

                int OrderID = int.Parse(txtOrderID.Text);
                int ProID = int.Parse(txtPId.Text);
                decimal SalesPrice = decimal.Parse(txtSPrice.Text);   //Product Details
                int Pquantity = int.Parse(txtQuantity.Text);
                int psize = int.Parse(txtsize.Text);

                DateTime stockDate = dtstockdate.Value;
                DateTime OrderTime = DateTime.Now;


                string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";
                string qry2 = "Insert Into StockPurchase Values(@OrderID,@SId,(Select [Supplier Name] From supplier Where [Supplier ID] =@SId),(Select [Supplier Email] From supplier Where [Supplier ID] =@SId),@ProID,@Pquantity,@psize,@SalesPrice,@stockDate,@OrderTime)";
                string qry3 = "Update Product SET Stocks=@Pquantity WHERE [Product ID]=@ProID";
                string qry4 = "Select [Product ID][Size] From Product Where [Product ID]=@ProID AND [Size]=@psize";
                string qry5 = "Select [Supplier ID] From Supplier WHERE [Supplier ID]=@SId";

                SqlConnection conn = new SqlConnection(connectionstring);

                SqlCommand cmd2 = new SqlCommand(qry2, conn);
                SqlCommand cmd3 = new SqlCommand(qry3, conn);
                SqlCommand cmd4 = new SqlCommand(qry4, conn);
                SqlCommand cmd5 = new SqlCommand(qry5, conn);

                //Parameterized queries

                cmd2.Parameters.AddWithValue("@OrderID", OrderID);
                cmd2.Parameters.AddWithValue("@SId", SId);
                cmd2.Parameters.AddWithValue("@ProID", ProID);
                cmd2.Parameters.AddWithValue("@Pquantity", Pquantity);
                cmd2.Parameters.AddWithValue("@psize", psize);
                cmd2.Parameters.AddWithValue("@SalesPrice", SalesPrice);
                cmd2.Parameters.AddWithValue("@stockDate", stockDate);
                cmd2.Parameters.AddWithValue("@OrderTime", OrderTime);

                cmd3.Parameters.AddWithValue("@Pquantity", Pquantity);
                cmd3.Parameters.AddWithValue("@ProID", ProID);

                cmd4.Parameters.AddWithValue("@ProID", ProID);
                cmd4.Parameters.AddWithValue("@psize", psize);

                cmd5.Parameters.AddWithValue("@SId", SId);

                bool checkProductIdExists = false;
                bool checkSupplierIdExists = false;

                try                                                     //check whether the product ID exists
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd4.ExecuteReader())
                    {
                        checkProductIdExists = reader.HasRows;
                    }
                    using (SqlDataReader reader1 = cmd5.ExecuteReader())
                    {
                        checkSupplierIdExists = reader1.HasRows;
                    }

                    if (!checkProductIdExists)
                    {
                        MessageBox.Show("Invalid Product ID or product size");
                    }
                    else if (!checkSupplierIdExists)
                    {
                        MessageBox.Show("Invalid  Supplier ID");
                    }
                    else
                    {
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Data Has been successfully inserted");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

           
             
        }     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            supplier objsup = new supplier();

            objsup.Show();
        }
       
    }
}
