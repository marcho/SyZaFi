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
    public partial class deleteEmployeeForm : Form
    {
        int id;
        string firstName;
        string lastName;
        string fathersName;
        string mothersName;
        string birthday;
        string placeOfResidence;
        string correspondenceAddress;
        string education;
        string historyOfEmployment;
        int pesel;
        string childrensNames;
        string childrensBirthdays;

        public deleteEmployeeForm()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            InitializeComponent();
            List<string>[] list = dBConnection.EmployeesList();
            var index = 0;
            foreach (var item in list[0])
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
            id = int.Parse(list[12].ElementAt(employeesListBox.SelectedIndex));
            firstName = list[0].ElementAt(employeesListBox.SelectedIndex);
            lastName = list[1].ElementAt(employeesListBox.SelectedIndex);
            fathersName = list[2].ElementAt(employeesListBox.SelectedIndex);
            mothersName = list[3].ElementAt(employeesListBox.SelectedIndex);
            birthday = list[4].ElementAt(employeesListBox.SelectedIndex);
            placeOfResidence = list[5].ElementAt(employeesListBox.SelectedIndex);
            correspondenceAddress = list[6].ElementAt(employeesListBox.SelectedIndex);
            education = list[7].ElementAt(employeesListBox.SelectedIndex);
            historyOfEmployment = list[8].ElementAt(employeesListBox.SelectedIndex);
            pesel = int.Parse(list[9].ElementAt(employeesListBox.SelectedIndex));
            childrensNames = list[10].ElementAt(employeesListBox.SelectedIndex);
            childrensBirthdays = list[11].ElementAt(employeesListBox.SelectedIndex);
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            dBConnection.MoveEmployeeToRemovedEmployees(firstName, lastName, fathersName, mothersName, birthday, placeOfResidence, correspondenceAddress, education, historyOfEmployment, pesel, childrensNames, childrensBirthdays);

            List<string>[] list2 = dBConnection.EmployeesList();
            logWriting logWriting = new logWriting("Użytkownik usunął pracownika - " + list2[0].ElementAt(employeesListBox.SelectedIndex));
            dBConnection.DeleteEmployee(id);
            employeesListBox.Items.Clear();
            List<string>[] list = dBConnection.EmployeesList();
            var index = 0;
            foreach (var item in list[0])
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
