using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networks
{
    internal class Switch
    {
        // members:
        private Slot[] slots;
        // constructor:
        public Switch(Slot[] slots)
        {
            this.slots = slots;
        }
        // methods:
        public Host IsExist(string macConnected)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null)
                {
                    if (slots[i].GetMacConnected() == macConnected)
                        return slots[i].GetHostConnected();
                }
            }
            return null;
        }
        // override string to string:
        public override string ToString()
        {
            string list = "";
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i] != null)
                    list += (i + 1) + ": " + slots[i] + "\n";
                else
                    list += (i + 1) + ": not connected slot \n";
            }
            return list;
        }
    }
}
