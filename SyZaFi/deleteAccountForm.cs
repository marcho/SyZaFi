using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class deleteAccountForm : Form
    {
        DBConnection dBConnection = new DBConnection("localhost", "syzafi", "root", "");
        string id;
        public deleteAccountForm()
        {
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
            List<string>[] list = dBConnection.CheckLogin();
            id = list[8].ElementAt(existingAccountsListBox.SelectedIndex).ToString();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
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
