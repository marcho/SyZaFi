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
    public partial class hrForm : Form
    {
        public hrForm()
        {
            InitializeComponent();
        }

        private void newEmployeeButton_Click(object sender, EventArgs e)
        {
            newEmployeeForm newEmployeeForm = new newEmployeeForm();
            newEmployeeForm.Show();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            editEmployeeForm editEmployeeForm = new editEmployeeForm();
            editEmployeeForm.Show();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            deleteEmployeeForm deleteEmployeeForm = new deleteEmployeeForm();
            deleteEmployeeForm.Show();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
