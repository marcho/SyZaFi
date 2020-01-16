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

namespace SyZaFi
{
    /*
     * TODO:
     * 
     * Find a way, to have the 'connection code' in one place. New method maybe?
    */
    public partial class deleteAccountForm : Form
    {
        string id;
        public deleteAccountForm()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            InitializeComponent();
            List<string>[] list = dBConnection.CheckLogin();
            var index = 0;
            foreach (var item in list[3])
            {
                existingAccountsListBox.Items.Add(list[3].ElementAt(index).ToString() + " " + list[4].ElementAt(index).ToString());
                index++;
            }
        }
        private void existingAccountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckLogin();
            id = list[8].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            var isSure = false;
            if (MessageBox.Show("Czy napewno chcesz usunąć konto?", "Usuwanie konta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
                DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
                DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
                List<string>[] list2 = dBConnection.CheckLogin();
                logWriting logWriting = new logWriting("Użytkownik usunął konto - " + list2[0].ElementAt(existingAccountsListBox.SelectedIndex).ToString());
                dBConnection.Delete(id);
                existingAccountsListBox.Items.Clear();
                List<string>[] list = dBConnection.CheckLogin();
                var index = 0;
                foreach (var item in list[3])
                {
                    existingAccountsListBox.Items.Add(list[3].ElementAt(index).ToString() + " " + list[4].ElementAt(index).ToString());
                    index++;
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
