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
/*
 * TODO:
 * Figure out a way to have 'connection code' in one place.
 * */
namespace SyZaFi
{
    public partial class modifyAccountForm : Form
    {
        string id;

        public modifyAccountForm()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            InitializeComponent();
            List<string>[] list = dBConnection.CheckLogin();
            var index = 0;
            foreach (var item in list[3])
            {
                existingAccountsListBox.Items.Add(list[3].ElementAt(index).ToString() + " " + list[4].ElementAt(index).ToString());
                index++;
            }
        }

        private void existingAccountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckLogin();
            firstNameTextBox.Text = list[3].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            lastNameTextBox.Text = list[4].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            loginTextBox.Text = list[0].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            passwordTextBox.Text = list[1].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            emailAddressTextBox.Text = list[5].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            birthdayTextBox.Text = list[7].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            employmentTextBox.Text = list[6].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
            id = list[8].ElementAt(existingAccountsListBox.SelectedIndex).ToString();

        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string login = loginTextBox.Text;
            string emailAddress = emailAddressTextBox.Text;
            string birthday = birthdayTextBox.Text;
            string employmentMonth = employmentTextBox.Text;
            PwdEncryption pwde = new PwdEncryption();
            string password = pwde.GenerateHash(passwordTextBox.Text);
            string pwdhash = File.ReadAllText("salt.txt");
            File.Delete("salt.txt");
            dBConnection.Update(firstName, lastName, birthday, login, employmentMonth, emailAddress, password, pwdhash, id);
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
