using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class forgotPasswordForm : Form
    {
        public forgotPasswordForm()
        {
            InitializeComponent();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToForgotCredentialsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remindPasswordButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string employmentMonth = employmentMonthTextBox.Text;

            DBConnection dBConnection = new DBConnection("localhost", "syzafi", "root", "");
            if (dBConnection.ConnectionTest())
            {
                List<string>[] list = dBConnection.CheckLogin();
                var indexOfLogin = 0;
                bool loginSuccessfull = false;
                foreach (string emailInList in list[5])
                {
                    if (emailInList == emailAddress)
                    {
                        loginSuccessfull = true;
                        break;
                    }
                    indexOfLogin++;
                }
                if (loginSuccessfull)
                {
                    var loginFromDb = list[0].ElementAt(indexOfLogin);
                    var emailAddressFromDb = list[5].ElementAt(indexOfLogin);
                    var employmentMonthFromDb = list[6].ElementAt(indexOfLogin);
                    if (loginFromDb == login || emailAddressFromDb == emailAddress || employmentMonthFromDb == employmentMonth)
                    {
                        /* send an email with password from db */
                    }
                    else
                    {
                        /* send an email to administrator with information about possible break in */
                        /* show window about problem and close the app */
                        Application.Exit();
                    }

                }
            }
        }
    }
}
