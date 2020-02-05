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
    public partial class inventoryForm : Form
    {
        int id;
        public inventoryForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            List<string>[] list = dBConnection.CheckInventory();
            var index = 0;
            foreach (var item in list[0])
            {
                inventoryListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString());
                index++;
            }
        }

        private void inventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckInventory();
            id = int.Parse(list[0].ElementAt(inventoryListBox.SelectedIndex));
            inventoryCodeTextBox.Text = list[1].ElementAt(inventoryListBox.SelectedIndex).ToString();
            nameTextBox.Text = list[2].ElementAt(inventoryListBox.SelectedIndex).ToString();
            amountTextBox.Text = list[3].ElementAt(inventoryListBox.SelectedIndex).ToString();
        }

        private void addNewItemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inventoryCodeTextBox.Text))
            {
                MessageBox.Show("Pole indeks nie może być puste. Proszę o poprawienie.", "Puste pole indeks", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Pole nazwa nie może być puste. Proszę o poprawienie.", "Puste pole nazwa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(amountTextBox.Text))
            {
                MessageBox.Show("Pole ilość nie może być puste. Proszę o poprawienie.", "Puste pole ilość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(amountTextBox.Text, out var test))
            {
                var inventoryCode = inventoryCodeTextBox.Text;
                var name = nameTextBox.Text;
                var amount = int.Parse(amountTextBox.Text);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                dBConnection.InsertNewInventoryPosition(inventoryCode, name, amount);

                inventoryListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckInventory();
                var index = 0;
                foreach (var item in list[0])
                {
                    inventoryListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString());
                    index++;
                }
                logWriting logWriting = new logWriting("Użytkownik dodał nowy przedmiot do magazynu.");
            }
        }

        private void modifyExistingItemButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("Musisz wybrać jedną pozycję, aby móc ją edytować.", "Nie wybrano żadnej pozycji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var inventoryCode = inventoryCodeTextBox.Text;
                var name = nameTextBox.Text;
                var amount = int.Parse(amountTextBox.Text);

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                dBConnection.UpdateInventory(id, inventoryCode, name, amount);

                inventoryListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckInventory();
                var index = 0;
                foreach (var item in list[0])
                {
                    inventoryListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString());
                    index++;
                }
                logWriting logWriting = new logWriting("Użytkownik zmodyfikował przedmiot w magazynie.");
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItems.Count < 1)
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
                    dBConnection.DeleteInventoryPosition(id);

                    inventoryListBox.Items.Clear();
                    List<string>[] list = dBConnection.CheckInventory();
                    var index = 0;
                    foreach (var item in list[0])
                    {
                        inventoryListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString());
                        index++;
                    }
                    logWriting logWriting = new logWriting("Użytkownik usunął przedmiot z magazynu.");
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
