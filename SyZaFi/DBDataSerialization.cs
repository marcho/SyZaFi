using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SyZaFi
{
    [Serializable]
    public class DBDataSerialization
    {
        public string dbhost;
        public string dbname;
        public string dblogin;
        public string dbpassword;

        public void SerializeIt(string host, string name, string login, string password)
        {
            DBDataSerialization dbds = new DBDataSerialization();
            dbds.dbhost = host;
            dbds.dbname = name;
            dbds.dblogin = login;
            dbds.dbpassword = password;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("conf.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, dbds);
            stream.Close();
        }
    }
}
