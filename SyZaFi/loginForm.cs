using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SyZaFi
{
    public partial class loginForm : Form
    {
        public static string loginForLogs;
        public loginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            loginForLogs = loginTextBox.Text;
            string login = loginTextBox.Text;
            PwdEncryption pwde = new PwdEncryption();
            if (dBConnection.ConnectionTest())
            {
                string pwdhash = dBConnection.GetPwdHash(login);
                byte[] salt = Convert.FromBase64String(pwdhash);
                string adminPassword = pwde.GenerateHashOnLogin(passwordTextBox.Text, salt);
            
                List<string>[] list = dBConnection.CheckLogin();
                var indexOfLogin = 0;
                bool loginSuccessfull = false;
                foreach (string loginInList in list[0])
                {
                    if (loginInList == login)
                    {
                        loginSuccessfull = true;
                        break;
                    }
                    indexOfLogin++;
                }
                if (loginSuccessfull)
                {
                    logWriting logWriting = new logWriting("Użytkownik się zalogował.");
                    var passwordFromDb = list[1].ElementAt(indexOfLogin);
                    var workgroupFromDb = list[2].ElementAt(indexOfLogin);
                    if (passwordFromDb == adminPassword)
                    {
                        switch (workgroupFromDb)
                        {
                            case "owner":
                                {
                                    ownerForm ownerForm = new ownerForm();
                                    ownerForm.Show();
                                    this.Hide();
                                    break;
                                }
                            case "hr":
                                {
                                    hrForm hrForm = new hrForm();
                                    hrForm.Show();
                                    this.Hide();
                                    break;
                                }
                            case "finances":
                                {
                                    financesForm financesForm = new financesForm();
                                    financesForm.Show();
                                    this.Hide();
                                    break;
                                }
                            case "logistics":
                                {
                                    logisticsForm logisticsForm = new logisticsForm();
                                    logisticsForm.Show();
                                    this.Hide();
                                    break;
                                }
                            case "production":
                                {
                                    productionForm productionForm = new productionForm();
                                    productionForm.Show();
                                    this.Hide();
                                    break;
                                }
                            case "administrator":
                                {
                                    configurationForm configurationForm = new configurationForm();
                                    configurationForm.Show();
                                    this.Hide();
                                    break;
                                }
                        }
                    }
                }
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void forgotCredentialsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby przypomnieć dane, udaj się do Administratora systemu.", "Przypomnienie danych", MessageBoxButtons.OK);
        }
    }
}
