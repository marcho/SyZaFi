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
/* TO DO:
 * 
 * Childrens - birthdays and names. Possibly in some sort of table?
 * Get the checkbox to work.
 * Check if the PESEL exists in the database.
 * 
 * */
namespace SyZaFi
{
    public partial class newEmployeeForm : Form
    {
        public newEmployeeForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            var firstName = firstNameTextBox.Text;
            var lastName = lastNameTextBox.Text;
            var fathersName = fathersNameTextBox.Text;
            var mothersName = mothersNameTextBox.Text;
            var dayOfBirth = birthdayDateTimePicker.Value.Day.ToString();
            var monthOfBirth = birthdayDateTimePicker.Value.Month.ToString();
            var yearOfBirth = birthdayDateTimePicker.Value.Year.ToString();
            var birthday = dayOfBirth + "/" + monthOfBirth + "/" + yearOfBirth;
            var placeOfResidence = placeOfResidenceTextBox.Text;
            var education = educationTextBox.Text;
            var correspondenceAddress = correspondenceAddressTextBox.Text;
            var historyOfEmployment = historyOfEmploymentTextBox.Text;
            var pesel = int.Parse(peselTextBox.Text);
            var childrensNames = childrensNamesTextBox.Text;
            var childrensBirthdays = childrensBirthdaysTextBox.Text;

            dBConnection.InsertNewEmployee(firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays);
            logWriting logWriting = new logWriting("Użytkownik dodał nowego pracownika.");
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
