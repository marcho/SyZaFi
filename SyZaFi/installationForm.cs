using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class installationForm : Form
    {
        string path;
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
            if (!dBConnection.ConnectionTest())
            {
                databaseHostTextBox.Text = null;
                databasePasswordTextBox.Text = null;
                databaseNameTextBox.Text = null;
                databaseLoginTextBox.Text = null;
                progressBar.Value = 0;
            }
            else if (string.IsNullOrWhiteSpace(adminLoginTextBox.Text))
            {
                MessageBox.Show("Login administratora nie może być pusty!", "Pusty login administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(adminPasswordTextBox.Text))
            {
                MessageBox.Show("Hasło administratora nie może być puste!", "Puste hasło administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(adminFirstNameTextBox.Text))
            {
                MessageBox.Show("Imię administratora nie może być puste!", "Puste imię administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(adminLastNameTextBox.Text))
            {
                MessageBox.Show("Nazwisko administratora nie może być puste!", "Puste nazwisko administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(adminEmailTextBox.Text))
            {
                MessageBox.Show("Adres e-mail administratora nie może być pusty!", "Pusty adres e-mail administratora", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(databaseHostTextBox.Text))
            {
                MessageBox.Show("Host bazy danych nie może być pusty!", "Pusty host bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(databasePasswordTextBox.Text))
            {
                MessageBox.Show("Hasło do bazy danych nie może być puste!", "Puste hasło do bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(databaseNameTextBox.Text))
            {
                MessageBox.Show("Nazwa bazy danych nie może być pusta!", "Pusta nazwa bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(databaseLoginTextBox.Text))
            {
                MessageBox.Show("Login do bazy danych nie może być pusty!", "Pusty login do bazy danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(companyNameTextBox.Text))
            {
                MessageBox.Show("Nazwa firmy nie może być pusta!", "Pusta nazwa firmy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(companyNIPTextBox.Text))
            {
                MessageBox.Show("NIP nie może być pusty!", "Pusty NIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(companyREGONTextBox.Text))
            {
                MessageBox.Show("REGON nie może być pusty!", "Pusty REGON", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(companyKRSTextBox.Text))
            {
                MessageBox.Show("KRS nie może być pusty!", "Pusty KRS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                createTable();
                dBConnection.CreateTable();

                PwdEncryption pwde = new PwdEncryption();
                string adminPassword = pwde.GenerateHash(adminPasswordTextBox.Text);
                string adminPwdSalt = File.ReadAllText("salt.txt");
                File.Delete("salt.txt");

                insertDataIntoSQLFiles(adminLogin, adminPassword, adminPwdSalt, adminFirstName, adminLastName, adminEmail, adminBirthday, workgroup, monthOfEmployment);
                dBConnection.CreateAdmin();

                progressBar.Value = 20;

                var companyName = companyNameTextBox.Text;
                var companyNIP = long.Parse(companyNIPTextBox.Text);
                var companyREGON = long.Parse(companyREGONTextBox.Text);
                var companyKRS = long.Parse(companyKRSTextBox.Text);
                dBConnection.InsertNewCompany(companyName, companyNIP, companyREGON, companyKRS);



                progressBar.Value = 75;

                DBDataSerialization bwr = new DBDataSerialization();
                bwr.SerializeIt(databaseHostTextBox.Text, databaseNameTextBox.Text, databaseLoginTextBox.Text, databasePasswordTextBox.Text, path);

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

        private void fileServerLocalisationButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
        }

        private void adminEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (!new EmailAddressAttribute().IsValid(adminEmailTextBox.Text) || adminEmailTextBox.Text == null)
            {
                MessageBox.Show("Podany adres e-mail jest niepoprawny.", "Błędny adres e-mail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void companyNIPTextBox_Leave(object sender, EventArgs e)
        {
            if (companyNIPTextBox.Text != "")
            {
                try
                {
                    int.Parse(companyNIPTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Błędny format NIPu. Proszę wprowadzić poprawny NIP.", "Błędny NIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyNIPTextBox.Clear();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Zbyt duży NIP. Proszę wprowadzić poprawny NIP.", "Zbyt długi NIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyNIPTextBox.Clear();
                }
            }

            if (companyNIPTextBox.Text.Length != 10 && companyNIPTextBox.Text.Length > 0)
            {
                MessageBox.Show("Niepoprawna długość NIPu. NIP ma 10 cyfr. Proszę wprowadzić poprawny NIP.", "Błędny NIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyNIPTextBox.Clear();
            }
        }

        private void companyREGONTextBox_Leave(object sender, EventArgs e)
        {
            if (companyREGONTextBox.Text != "")
            {
                try
                {
                    long.Parse(companyREGONTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Błędny format REGON. Proszę wprowadzić poprawny REGON.", "Błędny REGON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyREGONTextBox.Clear();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Zbyt duży REGON. Proszę wprowadzić poprawny REGON.", "Zbyt długi REGON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyREGONTextBox.Clear();
                }
            }

            if (companyREGONTextBox.Text.Length > 0 && companyREGONTextBox.Text.Length != 9 && companyREGONTextBox.Text.Length != 14)
            {

                MessageBox.Show("Błędny REGON. Posiada on 9 albo 14 cyfr.", "Błędny REGON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyREGONTextBox.Clear();
            }
        }

        private void companyKRSTextBox_Leave(object sender, EventArgs e)
        {
            if (companyKRSTextBox.Text != "")
            {
                try
                {
                    int.Parse(companyKRSTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Błędny format nr KRS. Proszę wprowadzić poprawny nr KRS.", "Błędny nr KRS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyKRSTextBox.Clear();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Zbyt długi nr KRS. Proszę wprowadzić poprawny nr KRS.", "Zbyt długi nr KRS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    companyKRSTextBox.Clear();
                }
            }

            if (companyKRSTextBox.Text.Length != 10 && companyKRSTextBox.Text.Length > 0)
            {
                MessageBox.Show("Zbyt długi nr KRS. Proszę wprowadzić poprawny nr KRS.", "Zbyt długi nr KRS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyKRSTextBox.Clear();
            }
        }
    }
}
