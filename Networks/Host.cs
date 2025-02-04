using System;
//using System.Collections.Generic;
using System.Diagnostics;

namespace Networks
{
    internal abstract class Host
    {
        // members:
        private string mac;
        private string model;
        private Switch connected;
        // constructor:
        public Host(string mac, string model, Switch connected)
        {
            this.mac = mac;
            this.model = model;
            this.connected = connected;
        }
        // methods:
        public abstract void GetFile(File f);
        public bool SendOn(File f, string mac)
        {
            Host sendTo = connected.IsExist(mac);
            if (sendTo != null)
            {
                sendTo.GetFile(f);
                return true;
            }
            return false;
        }
        // getters:
        public string GetMAC() => this.mac;
        public string GetModel() => this.model;
        public Switch GetSwitchConnected()
        {
            return this.connected;
        }
        // setters:
        public void SetMAC(string mac)
        {
            this.mac = mac;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void SetSwitchConnected(Switch connected)
        {
            this.connected = connected;
        }
        // override string to string:
        public override string ToString()
        {
            return "mac: " + this.mac + "\n" +
                "model: " + this.model + "\n" +
                "switch connected: \n" + this.connected;
        }
    }
}