using System;
//using System.Collections.Generic;

namespace Networks
{
    internal class Printer: Host
    {
        // members:
        private string made;
        private bool isFree;
        // constructor:
        public Printer(string mac, string model, Switch connected,
            string made, bool isFree): base(mac, model, connected)
        {
            this.made = made;
            this.isFree = isFree;
        }
        // methods:
        public override void GetFile(File f)
        {
            if (!isFree)
                throw new Exception();
            else
            {
                Console.WriteLine("printing...");
                isFree = false;
                Console.WriteLine(f);
            }
        }
        // getters:
        public string GetMade() => this.made;
        public bool IsFree() => this.isFree;
        // setters:
        public void SetMade(string made)
        {
            this.made = made;
        }
        public void SetIsFree(bool isFree) => this.isFree = isFree;
        // override to string:
        public override string ToString()
        {
            string list = base.ToString() + "\n";
            list += "made by: " + this.made + "\n";
            list += "is free: " + this.isFree + "\n";
            return list;
        }
    }
}
