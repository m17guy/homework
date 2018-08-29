using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_collection
{
    class log
    {
        Dictionary<string, string> logd = new Dictionary<string, string>();
        public log()
        {
            logd["guy"] = "123";
            logd["mr"] = "007";
            logd["cool"] = "6969";
            logd["admin"] = "xD!3t";
        }
        public void login(string username, string password)
        {
            if (logd.ContainsKey(username) && logd[username] == password)
                Console.WriteLine("welcom");
            else
                Console.WriteLine("invalid login");
        }
    }
}
