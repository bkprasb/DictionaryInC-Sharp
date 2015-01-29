using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DictionaryInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddresses myIPs = new IPAddresses();

            myIPs.Add("Punam", "120.168.45.23");
            myIPs.Add("Prabhat", "120.168.45.28");
            myIPs.Add("Kiran", "120.168.45.26");
            myIPs.Add("Gokul", "120.168.45.24");

            Console.WriteLine("There are " + myIPs.Count + " addresses in the system");
            Console.WriteLine("Gokul's Ip Address is :" + myIPs.Item("Gokul"));
             myIPs.Clear();

            Console.WriteLine("There are " +myIPs.Count + " number of ips in the system");
        
        }
    }

    public class IPAddresses : DictionaryBase
    {
        // now we are trying to load data into dictionary fro file.
        public IPAddresses()// It calls a default constructor of a base class.
        {
            //string line;
            //string[] words;
            //StreamReader inFile;


        }
        public void Add(string name, string ip)//This method is used to add key value pair in a Hash table.
        {
            base.InnerHashtable.Add(name, ip);
        }

        public string Item(string name)//This method is used to retrieve a value associated with a particular key.
        {
            return base.InnerHashtable[name].ToString();
        }

        public void Remove(string name)//This methods removes key value pair from hash table
        {
            base.InnerHashtable.Remove(name);
        }
    }
}
