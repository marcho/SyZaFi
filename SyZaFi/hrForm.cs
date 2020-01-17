using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO:
 * - do the printing the right way, not the hacky way :)
 * - add the possibility to check what files are needed for new employee
 */
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
            newEmployeeForm.ShowDialog();
        }

        private void editEmployeeButton_Click(object sender, EventArgs e)
        {
            editEmployeeForm editEmployeeForm = new editEmployeeForm();
            editEmployeeForm.ShowDialog();
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            deleteEmployeeForm deleteEmployeeForm = new deleteEmployeeForm();
            deleteEmployeeForm.ShowDialog();
        }

        private void exitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateFilesSingleButton_Click(object sender, EventArgs e)
        {
            generateFilesSingleForm generateFilesSingleForm = new generateFilesSingleForm();
            generateFilesSingleForm.ShowDialog();
        }

        private void generateNewEmployeeFiles_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"files\Umowa o pracę - wzór.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p.CloseMainWindow())
                p.Kill();

            ProcessStartInfo info2 = new ProcessStartInfo();
            info2.Verb = "print";
            info2.FileName = @"files\Regulamin pracy.pdf";
            info2.CreateNoWindow = true;
            info2.WindowStyle = ProcessWindowStyle.Hidden;

            Process p2 = new Process();
            p2.StartInfo = info2;
            p2.Start();

            p2.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p2.CloseMainWindow())
                p2.Kill();

            logWriting logWriting = new logWriting("Użytkownik wydrukował pakiet nowego pracownika.");
        }
    }
}
