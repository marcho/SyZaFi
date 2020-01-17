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
using System.Drawing.Printing;
using System.Diagnostics;
/*
 * TODO:
 * - generate those documents, not use available ones
 * - use something different than Adobe for printing
 */
namespace SyZaFi
{
    public partial class generateFilesSingleForm : Form
    {
        public generateFilesSingleForm()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            InitializeComponent();

            List<string>[] list = dBConnection.EmployeesList();
            var index = 0;
            foreach (var item in list[0])
            {
                employeesListBox.Items.Add(list[0].ElementAt(index).ToString() + " " + list[1].ElementAt(index).ToString());
                index++;
            }
        }

        private void contractOfEmploymentButton_Click(object sender, EventArgs e)
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

            logWriting logWriting = new logWriting("Użytkownik wydrukował umowę o pracę.");
        }

        private void contractOfMandateButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"files\Umowa zlecenie - wzór.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p.CloseMainWindow())
                p.Kill();

            logWriting logWriting = new logWriting("Użytkownik wydrukował umowę zlecenie.");
        }

        private void contractWorkButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"files\Umowa o dzieło - wzór.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p.CloseMainWindow())
                p.Kill();

            logWriting logWriting = new logWriting("Użytkownik wydrukował umowę o dzieło.");
        }

        private void annexChangeOfSalaryButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"files\Aneks - podwyżka.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p.CloseMainWindow())
                p.Kill();

            logWriting logWriting = new logWriting("Użytkownik wydrukował aneks - podwyżka.");
        }

        private void annexChangeOfPositionButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = @"files\Aneks - zmiana stanowiska.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(5000);
            if (false == p.CloseMainWindow())
                p.Kill();

            logWriting logWriting = new logWriting("Użytkownik wydrukował aneks - zmiana stanowiska.");
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
