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
    public partial class createNewAccountForm : Form
    {
        public createNewAccountForm()
        {
            InitializeComponent();
        }

        private void registerNewAccountButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            string checkLogin = loginTextBox.Text;
            bool isLoginUsed = false;
            if (dBConnection.ConnectionTest())
            {
                List<string>[] list = dBConnection.CheckLogin();
                string workgroup = "";
                foreach (var item in list[0])
                {
                    if (item == checkLogin)
                    {
                        MessageBox.Show("Login jest już w użyciu! Proszę wprowadzić inny login.", "Błąd dodawania użytkownika.");
                        isLoginUsed = true;
                    }
                    else
                    {

                        switch (workgroupListBox.SelectedItem.ToString())
                        {
                            case "Finanse i rachunkowość":
                                {
                                    workgroup = "finances";
                                    break;
                                }
                            case "Logistyka i magazyny":
                                {
                                    workgroup = "logistics";
                                    break;
                                }
                            case "Produkcja":
                                {
                                    workgroup = "production";
                                    break;
                                }
                            case "Właściciel":
                                {
                                    workgroup = "owner";
                                    break;
                                }
                            case "Zasoby ludzkie":
                                {
                                    workgroup = "hr";
                                    break;
                                }
                            default:
                                {
                                    workgroup = "";
                                    MessageBox.Show("Zła grupa robocza. Spróbuj jeszcze raz.");
                                    break;
                                }
                        }
                    }
                }
                var dayOfBirth = birthdayDateTimePicker.Value.Day.ToString();
                var monthOfBirth = birthdayDateTimePicker.Value.Month.ToString();
                var yearOfBirth = birthdayDateTimePicker.Value.Year.ToString();
                var firstName = firstNameTextBox.Text;
                var lastName = lastNameTextBox.Text;
                var birthday = dayOfBirth + "/" + monthOfBirth + "/" + yearOfBirth;
                var login = loginTextBox.Text;
                //var password = passwordTextBox.Text;
                var employmentMonth = employmentMonthDatePicker.Value.Month.ToString();
                var emailAddress = emailAddressTextBox.Text;
                PwdEncryption pwde = new PwdEncryption();
                string password = pwde.GenerateHash(passwordTextBox.Text);
                string pwdhash = File.ReadAllText("salt.txt");
                File.Delete("salt.txt");

                if (!isLoginUsed)
                {
                    dBConnection.InsertNewAccount(firstName, lastName, birthday, workgroup, login, password, pwdhash, employmentMonth, emailAddress);
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
