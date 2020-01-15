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
    public partial class forgotCredentialsForm : Form
    {
        public forgotCredentialsForm()
        {
            InitializeComponent();
        }

        private void forgotLoginButton_Click(object sender, EventArgs e)
        {
            forgotLoginForm forgotLoginForm = new forgotLoginForm();
            forgotLoginForm.Show();
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            forgotPasswordForm forgotPasswordForm = new forgotPasswordForm();
            forgotPasswordForm.Show();
        }

        private void forgotBothButton_Click(object sender, EventArgs e)
        {
            forgotBothForm forgotBothForm = new forgotBothForm();
            forgotBothForm.Show();
        }

        private void returnToLoginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
