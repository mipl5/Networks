using System;
//using System.Collections.Generic;

namespace Networks
{
    public class File
    {
        // members:
        private int size;
        private string name;
        private string typeExtension;
        // constructor:
        public File(int size, string name, string typeExtension)
        {
            this.size = size;
            this.name = name;
            this.typeExtension = typeExtension;
        }
        // getters:
        public int GetSize()
        {
            return this.size;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetTypeExtension()
        {
            return this.typeExtension;
        }
        // setters:
        public void SetSize(int size) => this.size = size;
        public void SetName(string name) => this.name = name;
        public void SetTypeExtension(string typeExtension)
        {
            this.typeExtension = typeExtension;
        }
        // override to string:
        public override string ToString()
        {
            return "size: " + this.size + "\n" +
                "name: " + this.name + "\n" +
                "type extension" + this.typeExtension;
        }
    }
}