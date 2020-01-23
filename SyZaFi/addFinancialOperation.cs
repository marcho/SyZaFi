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
    public partial class addFinancialOperation : Form
    {
        public addFinancialOperation()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);


            if (dBConnection.ConnectionTest())
            {
                List<string>[] list = dBConnection.CheckFinancialOperations();

                var receiver = receiverTextBox.Text;
                var amount = amountTextBox.Text;
                var category = categoryTextBox.Text;
                dBConnection.InsertNewFinancialOperation(receiver, amount, category);
                logWriting logWriting = new logWriting("Użytkownik dodał nową operację finansową.");
                this.Close();
            }
        }
    }
}
