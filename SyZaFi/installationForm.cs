using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class installationForm : Form
    {
        public installationForm()
        {
            InitializeComponent();
        }
        
        private void installButton_Click(object sender, EventArgs e)
        {
            string adminLogin = adminLoginTextBox.Text;
            string adminFirstName = adminFirstNameTextBox.Text;
            string adminLastName = adminLastNameTextBox.Text;
            string adminEmail = adminEmailTextBox.Text;
            string databaseHost = databaseHostTextBox.Text;
            string databasePassword = databasePasswordTextBox.Text;
            string databaseName = databaseNameTextBox.Text;
            string databaseLogin = databaseLoginTextBox.Text;

            var dayOfBirth = adminBirthdayDatePicker.Value.Day.ToString();
            var monthOfBirth = adminBirthdayDatePicker.Value.Month.ToString();
            var yearOfBirth = adminBirthdayDatePicker.Value.Year.ToString();
            var adminBirthday = dayOfBirth + "/" + monthOfBirth + "/" + yearOfBirth;
            var workgroup = "administrator";

            var monthOfEmployment = employmentMonthDatePicker.Value.Month.ToString();

            progressBar.Visible = true;
            progressBar.Value = 0;

            DBConnection dBConnection = new DBConnection(databaseHost, databaseName, databaseLogin, databasePassword);
            createTable();
            dBConnection.CreateTable();

            PwdEncryption pwde = new PwdEncryption();
            string adminPassword = pwde.GenerateHash(adminPasswordTextBox.Text);
            string adminPwdSalt = File.ReadAllText("salt.txt");
            File.Delete("salt.txt");

            insertDataIntoSQLFiles(adminLogin, adminPassword, adminPwdSalt, adminFirstName, adminLastName, adminEmail, adminBirthday, workgroup, monthOfEmployment);
            dBConnection.CreateAdmin();

            progressBar.Value = 20;

            
            if (!dBConnection.ConnectionTest())
            {
                adminLoginTextBox.Text = null;
                adminPasswordTextBox.Text = null;
                adminFirstNameTextBox.Text = null;
                adminLastNameTextBox.Text = null;
                databaseHostTextBox.Text = null;
                databasePasswordTextBox.Text = null;
                databaseNameTextBox.Text = null;
                databaseLoginTextBox.Text = null;
                progressBar.Value = 0;
            }
            else
            {
                progressBar.Value = 75;

                DBDataSerialization bwr = new DBDataSerialization();
                bwr.SerializeIt(databaseHostTextBox.Text, databaseNameTextBox.Text, databaseLoginTextBox.Text, databasePasswordTextBox.Text);
                
                progressBar.Value = 100;

                MessageBox.Show("Wszystko w porządku. Można używać programu.", "OK");
                loginForm loginForm = new loginForm();
                loginForm.Show();
                loginForm.Activate();
                this.Hide();
                
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createTable()
        {
            string text = File.ReadAllText("createTableSource.sql");
            File.WriteAllText("createTable.sql", text);
        }
        private void insertDataIntoSQLFiles(string adminLogin, string adminPassword, string adminPwdHash, string adminFirstName, string adminLastName, string adminEmail, string adminBirthday, string workgroup, string monthOfEmployment)
        {
            string text = File.ReadAllText("createAdminAccountSource.sql");
            text = text.Replace("adminFirstName", adminFirstName);
            text = text.Replace("adminLastName", adminLastName);
            text = text.Replace("adminBirthday", adminBirthday);
            text = text.Replace("adminworkgroup", workgroup);
            text = text.Replace("adminLogin", adminLogin);
            text = text.Replace("adminPassword", adminPassword);
            text = text.Replace("adminPwdHash", adminPwdHash);
            text = text.Replace("adminEmploymentMonth", monthOfEmployment);
            text = text.Replace("adminEmailAddress", adminEmail);
            File.WriteAllText("createAdminAccount.sql", text);
        }
    }
}
