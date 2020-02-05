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
    public partial class ordersForm : Form
    {
        int id;
        public ordersForm()
        {
            InitializeComponent();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            ordersListBox.Items.Clear();
            List<string>[] list = dBConnection.CheckOrders();
            var index = 0;
            foreach (var item in list[0])
            {
                ordersListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                index++;
            }
        }

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckOrders();
            id = int.Parse(list[0].ElementAt(ordersListBox.SelectedIndex));
            clientTextBox.Text = list[1].ElementAt(ordersListBox.SelectedIndex).ToString();
            itemNameTextBox.Text = list[2].ElementAt(ordersListBox.SelectedIndex).ToString();
            amountTextBox.Text = list[3].ElementAt(ordersListBox.SelectedIndex).ToString();
            dateTextBox.Text = list[4].ElementAt(ordersListBox.SelectedIndex).ToString();
        }

        private void addNewOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text))
            {
                MessageBox.Show("Pole klient nie może być puste. Proszę o poprawienie.", "Puste pole klient", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(itemNameTextBox.Text))
            {
                MessageBox.Show("Pole nazwa nie może być puste. Proszę o poprawienie.", "Puste pole nazwa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
                MessageBox.Show("Pole ilość nie może być puste. Proszę o poprawienie.", "Puste pole ilość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(dateTextBox.Text))
            {
                MessageBox.Show("Pole data nie może być puste. Proszę o poprawienie.", "Puste pole data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(amountTextBox.Text, out var test))
            {
                var client = clientTextBox.Text;
                var itemname = itemNameTextBox.Text;
                var amount = int.Parse(amountTextBox.Text);
                var date = dateTextBox.Text;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                dBConnection.InsertNewOrder(client, itemname, amount, date);

                ordersListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckOrders();
                var index = 0;
                foreach (var item in list[0])
                {
                    ordersListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                    index++;
                }
                logWriting logWriting = new logWriting("Użytkownik dodał nowe zamówienie.");
            }
        }

        private void modifyOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersListBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("Aby móc zmodyfikować pozycję, najpierw musisz jakąś wybrać.", "Nie wybrano pozycji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var client = clientTextBox.Text;
                var itemname = itemNameTextBox.Text;
                var amount = int.Parse(amountTextBox.Text);
                var date = dateTextBox.Text;

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                dBConnection.UpdateOrders(id, client, itemname, amount, date);

                ordersListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckOrders();
                var index = 0;
                foreach (var item in list[0])
                {
                    ordersListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                    index++;
                }
                logWriting logWriting = new logWriting("Użytkownik zmodyfikował istniejące zamówienie.");
            }
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if (ordersListBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("Musisz wybrać jedną pozycję, aby móc ją usunąć.", "Nie wybrano żadnej pozycji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną pozycję?", "Usunięcie pozycji", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                    DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                    DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                    dBConnection.DeleteOrder(id);

                    ordersListBox.Items.Clear();
                    List<string>[] list = dBConnection.CheckOrders();
                    var index = 0;
                    foreach (var item in list[0])
                    {
                        ordersListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                        index++;
                    }
                    logWriting logWriting = new logWriting("Użytkownik się zalogował.");
                }
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
