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
using System.Data.Entity;

namespace AccountingApp
{
    public partial class LoginAccountingAppForm : Form
    {
        public LoginAccountingAppForm()
        {
            InitializeComponent();
        }

        private void AccountingAppForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        /* Connection string to database */
        //String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Gestiune.mdf;Integrated Security=True;";

        private void OnClickLogin(object sender, EventArgs e)
        {
            if(_txtUsername.Text == "" || _txtPassword.Text == "")
            {
                MessageBox.Show("Please provide a Username and Password!", "Warning");
                return;
            }
            try
            {
                /* Create a new sql connection */
                //SqlConnection sqlConnection = new SqlConnection(connectionString);
                //SqlCommand sqlCheckUserCommand = new SqlCommand("Select * from Credentials where Username = @username and Password = @password", sqlConnection);
                //sqlCheckUserCommand.Parameters.AddWithValue("@username", _txtUsername.Text);
                //sqlCheckUserCommand.Parameters.AddWithValue("@password", _txtPassword.Text);
                //sqlConnection.Open();

                var db = new GestiuneEntities();
                var loginAttempt = db.Credentials.FirstOrDefault(u => u.Username == _txtUsername.Text && u.Password == _txtPassword.Text);
                if(loginAttempt != null)
                {
                    this.Hide();
                    AdminAccountingAppForm adminAccAppForm = new AdminAccountingAppForm();
                    adminAccAppForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!", "Failure");
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
