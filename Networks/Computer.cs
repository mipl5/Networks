//using System.Collections.Generic;

using Microsoft.SqlServer.Server;
using System.Security.AccessControl;
using System.Threading;

namespace Networks
{
    internal class Computer : Host
    {
        // members:
        private File[] files;
        private int counter;
        // constructor:
        public Computer(string mac, string model, Switch connected) : base(mac, model, connected)
        {
            this.files = new File[10];
            counter = 0;
        }
        // methods:
        public override void GetFile(File f)
        {
            if (counter < files.Length)
                files[counter++] = f;
        }
        // override string to string:
        public override string ToString()
        {
            string list = base.ToString() + "\nfiles:\n";
            for (int i = 0; i < counter; i++)
                if (files != null)
                    list += files[i] + "\n";
            return list;
        }
    }
}
