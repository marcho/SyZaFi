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
    public partial class ownerForm : Form
    {
        public ownerForm()
        {
            InitializeComponent();
        }

        private void financesButton_Click(object sender, EventArgs e)
        {
            financesForm financesForm = new financesForm();
            financesForm.ShowDialog();
        }

        private void hrButton_Click(object sender, EventArgs e)
        {
            hrForm hrForm = new hrForm();
            hrForm.ShowDialog();
        }

        private void logisticsButton_Click(object sender, EventArgs e)
        {
            logisticsForm logisticsForm = new logisticsForm();
            logisticsForm.ShowDialog();
        }

        private void productionButton_Click(object sender, EventArgs e)
        {
            productionForm productionForm = new productionForm();
            productionForm.ShowDialog();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restoreEmployeeButton_Click(object sender, EventArgs e)
        {
            restoreEmployeeForm restoreEmployeeForm = new restoreEmployeeForm();
            restoreEmployeeForm.ShowDialog();
        }
    }
}
