using System;
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
    public partial class restoreEmployeeForm : Form
    {
        public restoreEmployeeForm()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Open, FileAccess.Read);
            DBDataSerialization dbds = (DBDataSerialization)formatter.Deserialize(stream);
            DBConnection dBConnection = new DBConnection(dbds.dbhost, dbds.dbname, dbds.dblogin, dbds.dbpassword);

            InitializeComponent();

            List<string>[] list = dBConnection.DeletedEmployeesList();
            var index = 0;
            foreach (var item in list[0])
            {
                employeesListBox.Items.Add(list[0].ElementAt(index).ToString() + " " + list[1].ElementAt(index).ToString());
                index++;
            }
        }
    }
}
