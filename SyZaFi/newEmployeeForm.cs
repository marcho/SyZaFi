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
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Pole imię nie może być puste. Proszę o poprawienie.", "Puste pole imię", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Pole nazwisko nie może być puste. Proszę o poprawienie.", "Puste pole nazwisko", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(fathersNameTextBox.Text))
            {
                MessageBox.Show("Pole imię ojca nie może być puste. Proszę o poprawienie.", "Puste pole imię ojca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(mothersNameTextBox.Text))
            {
                MessageBox.Show("Pole imię matki nie może być puste. Proszę o poprawienie.", "Puste pole imię matki", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(placeOfResidenceTextBox.Text))
            {
                MessageBox.Show("Pole adres zamieszkania nie może być puste. Proszę o poprawienie.", "Puste pole adres zamieszkania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(educationTextBox.Text))
            {
                MessageBox.Show("Pole wykształcenie nie może być puste. Proszę o poprawienie.", "Puste pole wykształcenie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(correspondenceAddressTextBox.Text))
            {
                MessageBox.Show("Pole adres korespondecyjny nie może być puste. Proszę o poprawienie.", "Puste pole adres korespondecyjny", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(historyOfEmploymentTextBox.Text))
            {
                MessageBox.Show("Pole historia zatrudnienia nie może być puste. Proszę o poprawienie.", "Puste pole historia zatrudnienia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(peselTextBox.Text))
            {
                MessageBox.Show("Pole pesel nie może być puste. Proszę o poprawienie.", "Puste pole pesel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(childrensNamesTextBox.Text))
            {
                MessageBox.Show("Pole imiona dzieci nie może być puste. Proszę o poprawienie.", "Puste pole imiona dzieci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(childrensBirthdaysTextBox.Text))
            {
                MessageBox.Show("Pole urodziny dzieci nie może być puste. Proszę o poprawienie.", "Puste pole urodziny dzieci", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!long.TryParse(peselTextBox.Text, out var test))
            {
                MessageBox.Show("Zawartość pola pesel musi być liczbą. Proszę o poprawienie", "Błędna wartość pola pesel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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
                var pesel = long.Parse(peselTextBox.Text);
                var childrensNames = childrensNamesTextBox.Text;
                var childrensBirthdays = childrensBirthdaysTextBox.Text;

                dBConnection.InsertNewEmployee(firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays);
                logWriting logWriting = new logWriting("Użytkownik dodał nowego pracownika.");
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
