﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyZaFi
{
    public partial class productionPlanForm : Form
    {
        int id;
        public productionPlanForm()
        {
            InitializeComponent();

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            List<string>[] list = dBConnection.CheckProductionPlan();
            var index = 0;
            foreach (var item in list[0])
            {
                planListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                index++;
            }
        }

        private void planListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            List<string>[] list = dBConnection.CheckProductionPlan();
            id = int.Parse(list[0].ElementAt(planListBox.SelectedIndex));
            itemTextBox.Text = list[1].ElementAt(planListBox.SelectedIndex).ToString();
            amountTextBox.Text = list[2].ElementAt(planListBox.SelectedIndex).ToString();
            positionTextBox.Text = list[3].ElementAt(planListBox.SelectedIndex).ToString();
            dateTextBox.Text = list[4].ElementAt(planListBox.SelectedIndex).ToString();
        }

        private void addNewProductionButton_Click(object sender, EventArgs e)
        {
            var item = itemTextBox.Text;
            var amount = int.Parse(amountTextBox.Text);
            var position = positionTextBox.Text;
            var date = dateTextBox.Text;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            dBConnection.InsertNewProduction(item, amount, position, date);

            planListBox.Items.Clear();
            List<string>[] list = dBConnection.CheckProductionPlan();
            var index = 0;
            foreach (var i in list[0])
            {
                planListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                index++;
            }
        }

        private void modifyProductionButton_Click(object sender, EventArgs e)
        {
            var item = itemTextBox.Text;
            var amount = int.Parse(amountTextBox.Text);
            var position = positionTextBox.Text;
            var date = dateTextBox.Text;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            dBConnection.UpdateProductionPlan(id, item, amount, position, date);

            planListBox.Items.Clear();
            List<string>[] list = dBConnection.CheckProductionPlan();
            var index = 0;
            foreach (var i in list[0])
            {
                planListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                index++;
            }
        }

        private void deleteProductionButton_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);
            dBConnection.DeleteProduction(id);

            planListBox.Items.Clear();
            List<string>[] list = dBConnection.CheckProductionPlan();
            var index = 0;
            foreach (var item in list[0])
            {
                planListBox.Items.Add(list[1].ElementAt(index).ToString() + " | " + list[2].ElementAt(index).ToString() + " | " + list[3].ElementAt(index).ToString() + " | " + list[4].ElementAt(index).ToString());
                index++;
            }
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
