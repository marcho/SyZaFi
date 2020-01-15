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
    public partial class configurationForm : Form
    {
        public configurationForm()
        {
            InitializeComponent();
        }

        private void checkFilesButton_Click(object sender, EventArgs e)
        {
            /* checkFiles(); */
        }

        private void checkDatabaseButton_Click(object sender, EventArgs e)
        {
            /* checkDB(); */
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            createNewAccountForm createNewAccountForm = new createNewAccountForm();
            createNewAccountForm.Show();
        }

        private void modifyAccountButton_Click(object sender, EventArgs e)
        {
            modifyAccountForm modifyAccountForm = new modifyAccountForm();
            modifyAccountForm.Show();
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            deleteAccountForm deleteAccountForm = new deleteAccountForm();
            deleteAccountForm.Show();
        }

        private void checkLogsButton_Click(object sender, EventArgs e)
        {
            /* code for opening the txt file with logs */
        }

        private void migrateDatabaseButton_Click(object sender, EventArgs e)
        {
            migrateDatabaseForm migrateDatabaseForm = new migrateDatabaseForm();
            migrateDatabaseForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
