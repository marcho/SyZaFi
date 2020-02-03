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
using System.ComponentModel.DataAnnotations;

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
                        if (workgroupListBox.SelectedItems.Count > 0)
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
                }
                var dayOfBirth = birthdayDateTimePicker.Value.Day.ToString();
                var monthOfBirth = birthdayDateTimePicker.Value.Month.ToString();
                var yearOfBirth = birthdayDateTimePicker.Value.Year.ToString();
                var firstName = firstNameTextBox.Text;
                var lastName = lastNameTextBox.Text;
                var birthday = dayOfBirth + "/" + monthOfBirth + "/" + yearOfBirth;
                var login = loginTextBox.Text;
                var employmentMonth = employmentMonthDatePicker.Value.Month.ToString();
                var emailAddress = emailAddressTextBox.Text;
                PwdEncryption pwde = new PwdEncryption();
                string password = pwde.GenerateHash(passwordTextBox.Text);
                string pwdhash = File.ReadAllText("salt.txt");
                File.Delete("salt.txt");
                if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
                {
                    MessageBox.Show("Imię nie może być puste!", "Puste imię", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
                {
                    MessageBox.Show("Nazwisko nie może być puste!", "Puste nazwisko", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(loginTextBox.Text))
                {
                    MessageBox.Show("Login nie może być pusty!", "Puste imię administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    MessageBox.Show("Hasło nie może być puste!", "Puste hasło administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(emailAddressTextBox.Text))
                {
                    MessageBox.Show("Adres e-mail nie może być pusty!", "Pusty adres e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!isLoginUsed)
                {
                    dBConnection.InsertNewAccount(firstName, lastName, birthday, workgroup, login, password, pwdhash, employmentMonth, emailAddress);
                    MessageBox.Show("Konto utworzone poprawnie.", "Tworzenie konta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logWriting logWriting = new logWriting("Użytkownik dodał nowe konto - " + login);
                    firstNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    emailAddressTextBox.Text = "";
                    workgroupListBox.ClearSelected();
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

        private void emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (!new EmailAddressAttribute().IsValid(emailAddressTextBox.Text) || emailAddressTextBox.Text == null)
            {
                MessageBox.Show("Podany adres e-mail jest niepoprawny.", "Błędny adres e-mail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
