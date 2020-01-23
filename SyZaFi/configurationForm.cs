using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SyZaFi
{
    public partial class configurationForm : Form
    {
        public configurationForm()
        {
            InitializeComponent();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            createNewAccountForm createNewAccountForm = new createNewAccountForm();
            createNewAccountForm.ShowDialog();

        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            modifyAccountForm modifyAccountForm = new modifyAccountForm();
            modifyAccountForm.ShowDialog();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            deleteAccountForm deleteAccountForm = new deleteAccountForm();
            deleteAccountForm.ShowDialog();
        }

        private void checkLogsButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"log\log.log");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
