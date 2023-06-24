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
    public partial class updateproductcs : Form
    {
        int ProID,Psize; string Proname, Pbrand; decimal buyyprice, selllprice;
        public updateproductcs(int id, string pname, string pbrand,int psize,decimal buyprice,decimal sellprice)
        {
            InitializeComponent();
             ProID = id;
             Proname = pname;
             Pbrand = pbrand;
            Psize = psize; 
             buyyprice = buyprice;
             selllprice = sellprice;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProID = int.Parse(txtProId.Text);
                Proname = txtProName.Text;
                Pbrand = txtbrand.Text;
                buyyprice = decimal.Parse(txtBuyPrice.Text);
                selllprice = decimal.Parse(txtSellPrice.Text);
                Psize = int.Parse(txtSize.Text);

                string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

                string qry = "UPDATE Product SET [Product Name]=@Proname,[Brand]=@Pbrand,[Size]=@Psize,[Buy Price]=@buyyprice,[Sell Price]=@selllprice WHERE [Product ID]=@ProID";

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand(qry, conn);

                    cmd.Parameters.AddWithValue("@ProdID", ProID);
                    cmd.Parameters.AddWithValue("@Proname", Proname);
                    cmd.Parameters.AddWithValue("@Pbrand", Pbrand);
                    cmd.Parameters.AddWithValue("@Psize", Psize);
                    cmd.Parameters.AddWithValue("@buyyprice", buyyprice);
                    cmd.Parameters.AddWithValue("@selllprice", selllprice);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
