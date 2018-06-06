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


        private void OnClickLogin(object sender, EventArgs e)
        {
            bool loginAttempt;
            loginAttempt = Login.ValidateCredentials(txtUsername.Text, txtPassword.Text);
            if (loginAttempt == true)
            {
                this.Hide();
                AdminAccountingAppForm adminAccAppForm = new AdminAccountingAppForm();
                adminAccAppForm.Closed += (s, args) => this.Close();
                adminAccAppForm.Show();
            }
        }

        private void OnClickRegister(object sender, EventArgs e)
        {
            RegisterAccountingAppForm registerAccAppForm = new RegisterAccountingAppForm();
            registerAccAppForm.Show();
        }

        private void OnClickRecoverPassword(object sender, EventArgs e)
        {
            LostPassAccounting lostPassForm = new LostPassAccounting();
            lostPassForm.Show();
        }

        private void btnLostPass_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterAccountingAppForm registerAccountingAppForm = new RegisterAccountingAppForm();
            registerAccountingAppForm.Show();
        }
    }
}