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
using System.Security.Cryptography;

namespace Dashboard
{
    public partial class bill : UserControl
    {
        public bill()
        {
            InitializeComponent();
        
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int proid = int.Parse(txtproid.Text);
            int psize = int.Parse(cmbsize.Text);
            int pqty = int.Parse(txtqty.Text);
            bool found = false;
         
            

          
            
            if (billgrid.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in billgrid.Rows)
                {
                    if (Convert.ToString(row.Cells[0].Value) == txtproid.Text && Convert.ToString(row.Cells[1].Value) == cmbsize.Text && Convert.ToString(row.Cells[2].Value) == txtqty.Text)
                    {
                        row.Cells[1].Value = cmbsize.Text; // Assign the size value
                        row.Cells[2].Value = txtqty.Text;
                        row.Cells[1].Value = Convert.ToString(1 + Convert.ToInt32(row.Cells[1].Value));
                        found = true;
                    }
                }
                if (!found)
                {
                    billgrid.Rows.Add(txtproid.Text, cmbsize.Text, txtqty.Text);
                }
            }
            else
            {
                billgrid.Rows.Add(txtproid.Text, cmbsize.Text, txtqty.Text);
            }
        }
      

           
    }

    
}
