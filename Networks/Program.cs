using System;
using System.Net.Mail;
using System.Runtime.InteropServices;
//using System.Collections.Generic;

namespace Networks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slot[] slots = new Slot[2];
            slots[0] = new Slot();
            slots[1] = new Slot();
            Switch s = new Switch(slots);
            Computer c1 = new Computer("12A", "Macbook", s);
            slots[0].SetHostConnected(c1);
            Printer p1 = new Printer("13A", "US12", s, "Y", true); // false --> throws exception because printer is not free now
            slots[1].SetHostConnected(p1);
            File f = new File(12, "first", ".py");
            c1.GetFile(f);
            /*Console.WriteLine(c1);
            Console.WriteLine(p1);*/
            bool resultSent = c1.SendOn(f, "13A");
            Console.WriteLine(resultSent);
            resultSent = c1.SendOn(f, "13A"); // --> throws error because now print is not free (available) - have to use setter to set free
            Console.WriteLine(resultSent); //gives false
            /*File f1 = new File(13, "second", ".cpp");
            c1.SendOn(f1, "11A");
            Console.WriteLine(c1);*/
        }
    }
}
