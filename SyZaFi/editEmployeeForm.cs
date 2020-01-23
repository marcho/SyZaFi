using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class editEmployeeForm : Form
    {
        int id;
        public editEmployeeForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.EmployeesList();
            var index = 0;
            foreach (var item in list[3])
            {
                employeesListBox.Items.Add(list[0].ElementAt(index).ToString() + " " + list[1].ElementAt(index).ToString());
                index++;
            }
        }

        private void employeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.EmployeesList();
            firstNameTextBox.Text = list[0].ElementAt(employeesListBox.SelectedIndex).ToString();
            lastNameTextBox.Text = list[1].ElementAt(employeesListBox.SelectedIndex).ToString();
            fathersNameTextBox.Text = list[2].ElementAt(employeesListBox.SelectedIndex).ToString();
            mothersNameTextBox.Text = list[3].ElementAt(employeesListBox.SelectedIndex).ToString();
            birthdayTextBox.Text = list[4].ElementAt(employeesListBox.SelectedIndex).ToString();
            placeOfResidenceTextBox.Text = list[5].ElementAt(employeesListBox.SelectedIndex).ToString();
            correspondenceAddressTextBox.Text = list[6].ElementAt(employeesListBox.SelectedIndex).ToString();
            educationTextBox.Text = list[7].ElementAt(employeesListBox.SelectedIndex).ToString();
            historyOfEmploymentTextBox.Text = list[8].ElementAt(employeesListBox.SelectedIndex).ToString();
            peselTextBox.Text = list[9].ElementAt(employeesListBox.SelectedIndex).ToString();
            childrensNamesTextBox.Text = list[10].ElementAt(employeesListBox.SelectedIndex).ToString();
            childrensBirthdaysTextBox.Text = list[11].ElementAt(employeesListBox.SelectedIndex).ToString();
            id = int.Parse(list[12].ElementAt(employeesListBox.SelectedIndex).ToString());
        }

        private void modifyEmployeeButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fathersName = fathersNameTextBox.Text;
            string mothersName = mothersNameTextBox.Text;
            string birthday = birthdayTextBox.Text;
            string placeOfResidence = placeOfResidenceTextBox.Text;
            string correspondenceAddress = correspondenceAddressTextBox.Text;
            string education = educationTextBox.Text;
            string historyOfEmployment = historyOfEmploymentTextBox.Text;
            int pesel = int.Parse(peselTextBox.Text);
            string childrensNames = childrensNamesTextBox.Text;
            string childrensBirthdays = childrensBirthdaysTextBox.Text;
            dBConnection.UpdateEmployee(firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays, id);
            logWriting logWriting = new logWriting("Użytkownik zmodyfikował pracownika.");

            employeesListBox.Items.Clear();
            List<string>[] list = dBConnection.EmployeesList();
            var index = 0;
            foreach (var item in list[3])
            {
                employeesListBox.Items.Add(list[0].ElementAt(index).ToString() + " " + list[1].ElementAt(index).ToString());
                index++;
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
