using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks
{
    internal class Slot
    {
        // members:
        private Host hostConnected;
        // constructor:
        // default constructor - don't have to write already exists
        // getters:
        public string GetMacConnected()
        {
            return this.hostConnected.GetMAC();
        }
        public Host GetHostConnected()
        {
            return this.hostConnected;
        }
        // setters:
        public void SetHostConnected(Host hostConnected)
        {
            this.hostConnected = hostConnected;
        }
        // override string to string:
        public override string ToString()
        {
            if (hostConnected != null)
                return "connected to: \n" + hostConnected.GetMAC();
            return "connected to: none\n";
        }
    }
}
