using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SyZaFi
{
    class logWriting
    {
        public logWriting(string text)
        {
            using (StreamWriter sw = File.AppendText(@"log\log.log"))
            {
                sw.WriteLine(loginForm.loginForLogs + " " + DateTime.Now.ToString() + " " + text);
            }
        }
    }
}
