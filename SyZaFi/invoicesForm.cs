﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SyZaFi
{
    public partial class invoicesForm : Form
    {
        public invoicesForm()
        {
            InitializeComponent();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            string[] filePaths = Directory.GetFiles(dbds.path + "\\");
            foreach (string asd in filePaths)
            {
                invoicesListBox.Items.Add(asd);
            }
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Title = "Wybierz plik PDF  z fakturą";
                openFileDialog.ShowDialog();
                File.Copy(openFileDialog.FileName, dbds.path + "\\" + openFileDialog.SafeFileName);
                invoicesListBox.Items.Clear();
                string[] filePaths = Directory.GetFiles(dbds.path + "\\");
                foreach (string asd in filePaths)
                {
                    invoicesListBox.Items.Add(asd);
                }
                logWriting logWriting = new logWriting("Użytkownik dodał fakturę.");
            }
            catch (IOException ioex)
            {
                MessageBox.Show("Plik o danej nazwie już istnieje!", "Plik nie został dodany!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeInvoiceButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);

            File.Delete(invoicesListBox.SelectedItem.ToString());
            invoicesListBox.Items.Clear();
            string[] filePaths = Directory.GetFiles(dbds.path + "\\");
            foreach (string asd in filePaths)
            {
                invoicesListBox.Items.Add(asd);
            }
            logWriting logWriting = new logWriting("Użytkownik usunął fakturę.");
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openInvoiceButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(invoicesListBox.SelectedItem.ToString());
            logWriting logWriting = new logWriting("Użytkownik otworzył fakturę.");
        }
    }
}
