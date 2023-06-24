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

namespace Dashboard
{
    public partial class registerform : Form
    {
        public registerform()
        {
            InitializeComponent();
           
        }
        string role;

        private void radioadmin_CheckedChanged_1(object sender, EventArgs e)
        {
            role = "Admin";
        }

        private void radioemp_CheckedChanged_1(object sender, EventArgs e)
        {
            role = "Employee";
        }

        private void submit_Click_1(object sender, EventArgs e)
        {

                int age, telno, id;
                string name = txtname.Text;
                string address = txtaddress.Text;
                int.TryParse(txtage.Text, out age);
                string email = txtemail.Text;
                int.TryParse(txttel.Text, out telno);
                string username = txtusername.Text;
                string password = txtpass.Text;
                int.TryParse(txtid.Text, out id);


                bool validateform()
                {
                    bool isValid = true;
                    string Errormsg = "";

                    if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(txtage.Text) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(txttel.Text) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(txtid.Text))
                    {
                        isValid = false;
                        Errormsg = "Please fill in all the fields.";

                    }
                    else if (Regex.IsMatch(username, "^[a-z]{10,}$")) //regex is use to find a search pattern
                    {
                        isValid = false;
                        Errormsg = "Username should only contain lowercase letters.";
                    }

                    else if (age < 18)
                    {
                        isValid = false;
                        Errormsg = "You must be at least 18 years of age to sign up.";
                    }

                    else if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zAZ0-9-]+\.[a-zA-Z0-9-.]+$"))
                    {
                        isValid = false;
                        Errormsg = "The email address is not valid.";
                    }
                    else if (password.Length < 5)
                    {
                        isValid = false;
                        Errormsg = "Password is too short";
                    }
                    else if (!radioadmin.Checked || radioemp.Checked)
                    {
                        isValid = false;
                        Errormsg = "Select User";
                    }

                    if (!isValid)
                    {
                        MessageBox.Show(Errormsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\New folder\\shoeshop.mdf\";Integrated Security=True;Connect Timeout=30";

                        SqlConnection conn = new SqlConnection(connectionstring);

                        string qury = "Insert Into [User] VALUES('" + id + "','" + name + "','" + address + "','" + age + "','" + email + "','" + telno + "','" + username + "','" + password + "','" + role + "')";
                        SqlCommand cmd = new SqlCommand(qury, conn);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data inserted Successfully");
                            conn.Close();
                            Log objlog = new Log();

                            objlog.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    return isValid;
                }

                validateform();

               
            }

        private void registerform_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
    }
    
}
