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
    public partial class financialOperationsForm : Form
    {
        string id;
        public financialOperationsForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckFinancialOperations();
            var index = 0;
            foreach (var item in list[0])
            {
                financialOperationsListBox.Items.Add(list[0].ElementAt(index).ToString());
                index++;
            }
        }

        private void financialOperationsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckFinancialOperations();
            receiverTextBox.Text = list[0].ElementAt(financialOperationsListBox.SelectedIndex).ToString();
            amountTextBox.Text = list[1].ElementAt(financialOperationsListBox.SelectedIndex).ToString();
            categoryTextBox.Text = list[2].ElementAt(financialOperationsListBox.SelectedIndex).ToString();
            id = list[3].ElementAt(financialOperationsListBox.SelectedIndex).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeOperationButton_Click(object sender, EventArgs e)
        {
            var isSure = false;
            if (MessageBox.Show("Czy napewno chcesz usunąć wpis?", "Usuwanie wpisu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                dBConnection.DeleteFinancialOperation(id);
                financialOperationsListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckFinancialOperations();
                var index = 0;
                foreach (var item in list[3])
                {
                    financialOperationsListBox.Items.Add(list[0].ElementAt(index).ToString());
                    index++;
                }

            }
        }

        private void addOperationButton_Click(object sender, EventArgs e)
        {
            addFinancialOperation addFinancialOperation = new addFinancialOperation();
            addFinancialOperation.Show();
        }

        private void financialOperationsForm_Activated(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            financialOperationsListBox.Items.Clear();
            List<string>[] list = dBConnection.CheckFinancialOperations();
            var index = 0;
            foreach (var item in list[0])
            {
                financialOperationsListBox.Items.Add(list[0].ElementAt(index).ToString());
                index++;
            }
        }
    }
}
