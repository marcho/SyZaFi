using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SyZaFi
{
    public partial class forgotBothForm : Form
    {
        public forgotBothForm()
        {
            InitializeComponent();
        }

        private void returnToForgotCredentialsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void remindCredentialsButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string emailAddres = emailTextBox.Text;
            string employmentMonth = monthOfEmploymentTextBox.Text;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            if (dBConnection.ConnectionTest())
            {
                List<string>[] list = dBConnection.CheckLogin();
                var indexOfLogin = 0;
                bool loginSuccessfull = false;
                foreach (string emailInList in list[5])
                {
                    if (emailInList == emailAddres)
                    {
                        loginSuccessfull = true;
                        break;
                    }
                    indexOfLogin++;
                }
                if (loginSuccessfull)
                {
                    var firstNameFromDb = list[3].ElementAt(indexOfLogin);
                    var lastNameFromDb = list[4].ElementAt(indexOfLogin);
                    var employmentMonthFromDb = list[6].ElementAt(indexOfLogin);
                    if (firstNameFromDb == firstName || lastNameFromDb == lastName || employmentMonthFromDb == employmentMonth)
                    {
                        /* send an email with login and password from db */
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
