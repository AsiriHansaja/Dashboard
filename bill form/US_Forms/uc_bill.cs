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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Text;

namespace bill_form.US_Forms
{
    public partial class uc_bill : UserControl
    {
        public uc_bill()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\shoeshopbilldb.mdf;Integrated Security=True;Connect Timeout=30");
        private void lblTotalPriceDisplay_Click(object sender, EventArgs e)
        {

        }

        private void load_data()
        {
            bool deleteColumnExists = false;
            foreach (DataGridViewColumn column in DataGridViewOrder2.Columns)
            {
                if (column.HeaderText == "Delete Item")
                {
                    deleteColumnExists = true;
                    break;
                }
            }

            if (!deleteColumnExists)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                DataGridViewOrder2.Columns.Insert(4, buttonColumn);
                buttonColumn.HeaderText = "Delete Item";
                buttonColumn.Width = 200;
                buttonColumn.Text = "Delete";
                buttonColumn.UseColumnTextForButtonValue = true;
            }
        }
        private void btnAddProduct1_Click(object sender, EventArgs e)
        {

            try
            {
                int ID = int.Parse(txtProductID.Text);
                int qn = int.Parse(txtQuantity.Text);
                int OID = int.Parse(txtOrderID.Text);
                con.Open();
                DataGridViewOrder2.Columns.Clear();
                
                string selectQry = "SELECT * FROM Product_Table WHERE Product_ID = '" + ID + "'";
                SqlDataAdapter da = new SqlDataAdapter(selectQry, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Product_Table");

                if (ds.Tables["Product_Table"].Rows.Count > 0)
                {
                   
                    string insertQry = "INSERT INTO Bill_Table (ProductID, ProductName, Size, Price, Quantity, OrderID) SELECT Product_ID, Product_Name, Product_Size, Product_Price, @Quantity, @OrderID FROM Product_Table WHERE Product_ID = '" + ID + "'";
                    SqlCommand cmd = new SqlCommand(insertQry, con);
                    cmd.Parameters.AddWithValue("@Quantity", qn);
                    cmd.Parameters.AddWithValue("@OrderID", OID);


                    cmd.ExecuteNonQuery();

                    
                    string selectBillQry = "SELECT * FROM Bill_Table";
                    SqlDataAdapter daBill = new SqlDataAdapter(selectBillQry, con);
                    DataSet dsBill = new DataSet();
                    daBill.Fill(dsBill, "Bill_Table");
                    DataGridViewOrder2.DataSource = dsBill.Tables["Bill_Table"];

                    load_data();

                    UpdateTotalPrice();

                    txtOrderID.Enabled = false;

                    DataGridViewColumn quantityColumn = DataGridViewOrder2.Columns["Quantity"];
                    if (quantityColumn != null)
                    {
                        quantityColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    foreach (DataGridViewColumn column in DataGridViewOrder2.Columns)
                    {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void billCLear()
        {
            try
            {
                con.Open();
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show("All records will be deleted from Bill Table?", "Deletion Confirmation", buttons, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                
                    string deleteQuery = "DELETE FROM Bill_Table";
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);
                    cmd.ExecuteNonQuery();

                  
                    string selectBillQry = "SELECT * FROM Bill_Table";
                    SqlDataAdapter daBill = new SqlDataAdapter(selectBillQry, con);
                    DataSet dsBill = new DataSet();
                    daBill.Fill(dsBill, "Bill_Table");
                    DataGridViewOrder2.DataSource = dsBill.Tables["Bill_Table"];

                    txtProductID.Text = "";
                    txtQuantity.Text = "";
                    txtOrderID.Text = "";
                    txtDiscount.Text = "";
                    lblFinalPriceDisplay.Text = " ";
                    lblTotalPriceDisplay.Text = " ";

                }
                else
                {
                    string selectBillQry = "SELECT * FROM Bill_Table";
                    SqlDataAdapter daBill = new SqlDataAdapter(selectBillQry, con);
                    DataSet dsBill = new DataSet();
                    daBill.Fill(dsBill, "Bill_Table");
                    DataGridViewOrder2.DataSource = dsBill.Tables["Bill_Table"];
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            billCLear();
        }

        private void DataGridViewOrder2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewOrder2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DataGridViewOrder2.Columns[e.ColumnIndex].HeaderText == "Delete Item")
            {
                if (MessageBox.Show("Do you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#\shoeshopbilldb.mdf;Integrated Security=True;Connect Timeout=30");
                    connection.Open();
                    try
                    {
                        int id;
                        id = Convert.ToInt32(DataGridViewOrder2.Rows[e.RowIndex].Cells["ProductID"].Value);
                        string query = "DELETE FROM Bill_Table WHERE ProductID=@ProductID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@ProductID", id);
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data Deleted Successfull");
                            string selectBillQuery = "SELECT * FROM Bill_Table";
                            SqlDataAdapter daBill = new SqlDataAdapter(selectBillQuery, con);
                            DataSet dsBill = new DataSet();
                            daBill.Fill(dsBill, "Bill_Table");
                            DataGridViewOrder2.DataSource = dsBill.Tables["Bill_Table"];

                            UpdateTotalPrice();
                        }

                        else
                        {
                            MessageBox.Show("Data Not Deleted");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally { connection.Close(); }

                }
            }

        }


        private int fileCounter = 1; 
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            
       

            try
            {
                
                Document document = new Document();

               
                string filePath = $"C:\\Users\\neeth\\Desktop\\Project\\ExportedBill\\Bill_Table_{fileCounter}.pdf"; 
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                
                document.Open();

                string logoPath = "C:\\Users\\neeth\\Desktop\\Project\\logoPNG.png"; 
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                logo.ScaleAbsolute(200f, 100f);
                document.Add(logo);

                document.Add(new Paragraph(" "));

                PdfPTable pdfTable = new PdfPTable(DataGridViewOrder2.ColumnCount);


                for (int i = 0; i < DataGridViewOrder2.ColumnCount; i++)
                {
                    pdfTable.AddCell(DataGridViewOrder2.Columns[i].HeaderText);
                }

                foreach (DataGridViewRow row in DataGridViewOrder2.Rows)
                {
                    for (int j = 0; j < DataGridViewOrder2.ColumnCount; j++)
                    {
                        if (row.Cells[j].Value != null)
                        {
                            pdfTable.AddCell(row.Cells[j].Value.ToString());
                        }
                    }
                }


                document.Add(pdfTable);

                document.Add(new Paragraph(" "));

                Paragraph infoParagraph = new Paragraph();
                infoParagraph.Alignment = Element.ALIGN_LEFT;
                infoParagraph.Add(new Chunk("Order ID: "));
                infoParagraph.Add(new Chunk(txtOrderID.Text));
                infoParagraph.Add(Chunk.NEWLINE);
                infoParagraph.Add(new Chunk("Total Price: "));
                infoParagraph.Add(new Chunk(lblTotalPriceDisplay.Text));
                infoParagraph.Add(Chunk.NEWLINE); 
                infoParagraph.Add(new Chunk("Discount Percentage (%): "));
                infoParagraph.Add(new Chunk(txtDiscount.Text));
                infoParagraph.Add(Chunk.NEWLINE); 
                infoParagraph.Add(new Chunk("Final Price: "));
                infoParagraph.Add(new Chunk(lblFinalPriceDisplay.Text));


                document.Add(infoParagraph);

                fileCounter++;


                document.Close();

                MessageBox.Show("DataGridView exported to PDF successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                billCLear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }



        private void UpdateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in DataGridViewOrder2.Rows)
            {
                if (row.Cells["Price"].Value != null && decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price) &&
                    row.Cells["Quantity"].Value != null && decimal.TryParse(row.Cells["Quantity"].Value.ToString(), out decimal Quantity))
                {
                    totalPrice += price * Quantity;
                }
            }
            lblTotalPriceDisplay.Text = totalPrice.ToString("C");

            if (decimal.TryParse(txtDiscount.Text, out decimal discount) && discount >= 0 && discount <= 100)
            {
                decimal discountAmount = totalPrice * (discount / 100);
                totalPrice -= discountAmount;
            }


            lblFinalPriceDisplay.Text = totalPrice.ToString("C"); 
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEnterOrderID_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
