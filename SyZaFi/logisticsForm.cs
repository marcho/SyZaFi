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
    public partial class logisticsForm : Form
    {
        public logisticsForm()
        {
            InitializeComponent();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            inventoryForm inventoryForm = new inventoryForm();
            inventoryForm.ShowDialog();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ordersForm ordersForm = new ordersForm();
            ordersForm.ShowDialog();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
