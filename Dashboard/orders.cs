using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class orders : UserControl
    {
        private string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";
        private DataTable ordersTable;
        private DataTable stockPurchaseTable;
        private bool displayStockPurchase = false;

        public orders()
        {
            InitializeComponent();
            Load += orders_Load;
        }

        private void orders_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LoadOrdersTable();
        }

        private void LoadOrdersTable()
        {
            string qry = "SELECT * FROM Orders";
            SqlDataAdapter da = new SqlDataAdapter(qry, connectionstring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            ordersTable = ds.Tables["Orders"];
            ordersgrid.DataSource = ordersTable;
        }

        private void LoadStockPurchaseTable()
        {
            string qry = "SELECT * FROM StockPurchase";
            SqlDataAdapter da = new SqlDataAdapter(qry, connectionstring);
            DataSet ds = new DataSet();
            da.Fill(ds, "StockPurchase");
            stockPurchaseTable = ds.Tables["StockPurchase"];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtFromDate.Value;
            DateTime todate = dtToDate.Value;

            string ordersqry = "SELECT * FROM Orders WHERE [Order Date] BETWEEN @fromdate AND @todate";
            string stockqry = "SELECT * FROM StockPurchase WHERE [Order Date] BETWEEN @fromdate AND @todate";

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                // Filter Orders table
                SqlDataAdapter ordersAdapter = new SqlDataAdapter(ordersqry, connection);
                ordersAdapter.SelectCommand.Parameters.AddWithValue("@fromdate", fromdate);
                ordersAdapter.SelectCommand.Parameters.AddWithValue("@todate", todate);
                DataSet ordersDataSet = new DataSet();
                ordersAdapter.Fill(ordersDataSet, "Orders");
                ordersTable = ordersDataSet.Tables["Orders"];

                // Filter StockPurchase table
                SqlDataAdapter stockPurchaseAdapter = new SqlDataAdapter(stockqry, connection);
                stockPurchaseAdapter.SelectCommand.Parameters.AddWithValue("@fromdate", fromdate);
                stockPurchaseAdapter.SelectCommand.Parameters.AddWithValue("@todate", todate);
                DataSet stockPurchaseDataSet = new DataSet();
                stockPurchaseAdapter.Fill(stockPurchaseDataSet, "StockPurchase");
                stockPurchaseTable = stockPurchaseDataSet.Tables["StockPurchase"];

                if (displayStockPurchase)
                    ordersgrid.DataSource = stockPurchaseTable;
                else
                    ordersgrid.DataSource = ordersTable;
            }
        }


        private void btnstockpurchase_Click(object sender, EventArgs e)
        {
            displayStockPurchase = true;
            LoadStockPurchaseTable();
            ordersgrid.DataSource = stockPurchaseTable;
        }

        private void btncuspurchase_Click(object sender, EventArgs e)
        {
            displayStockPurchase = false;
            LoadOrdersTable();
            ordersgrid.DataSource = ordersTable;
        }
    }
}
