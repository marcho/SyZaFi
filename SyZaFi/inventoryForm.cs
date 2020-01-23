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
        }

        private void modifyExistingItemButton_Click(object sender, EventArgs e)
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
        }

        private void removeItemButton_Click(object sender, EventArgs e)
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
