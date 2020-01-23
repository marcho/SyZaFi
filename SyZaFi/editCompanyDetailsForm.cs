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
    public partial class editCompanyDetailsForm : Form
    {
        public editCompanyDetailsForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckCompany();
            companyNameTextBox.Text = list[1].ElementAt(0);
            companyNIPTextBox.Text = list[2].ElementAt(0);
            companyREGONTextBox.Text = list[3].ElementAt(0);
            companyKRSTextBox.Text = list[4].ElementAt(0);
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            string companyName = companyNameTextBox.Text;
            int companyNIP = int.Parse(companyNIPTextBox.Text);
            int companyREGON = int.Parse(companyREGONTextBox.Text);
            int companyKRS = int.Parse(companyKRSTextBox.Text);

            dBConnection.UpdateCompanyDetails(1, companyName, companyNIP, companyREGON, companyKRS);
            logWriting logWriting = new logWriting("Użytkownik zmodyfikował dane firmy.");
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
