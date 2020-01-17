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
    public partial class productionForm : Form
    {
        public productionForm()
        {
            InitializeComponent();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.ShowDialog();
        }

        private void productionPlanButton_Click(object sender, EventArgs e)
        {
            productionPlanForm productionPlanForm = new productionPlanForm();
            productionPlanForm.ShowDialog();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
