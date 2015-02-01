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
           // IPAddresses myIPs = new IPAddresses();

            //myIPs.Add("Punam", "120.168.45.23");
            //myIPs.Add("Prabhat", "120.168.45.28");
            //myIPs.Add("Kiran", "120.168.45.26");
            //myIPs.Add("Gokul", "120.168.45.24");

            //Console.WriteLine("There are " + myIPs.Count + " addresses in the system");
            //Console.WriteLine("Gokul's Ip Address is :" + myIPs.Item("Gokul"));
            // myIPs.Clear();

            //Console.WriteLine("There are " +myIPs.Count + " number of ips in the system");

            //Now let us read dictionary data stored in a file.

            //for (int i = 0; i < 4; i++)
            //{
                Console.WriteLine();

                IPAddresses myIPs = new IPAddresses("C:\\GIT\\Projects\\DictionaryInC#\\DictionaryInC-Sharp\\DictionaryInCSharpExamples\\DictionaryInCSharp\\ips.txt");

                Console.WriteLine("There are {0} IP addresses in the system" , myIPs.Count);

                Console.WriteLine("Punam's IP address is {0}",myIPs.Item("Punam"));

                Console.WriteLine("Gokul's IP address is {0}", myIPs.Item("Gokul"));


            //}
        
        }
    }

    public class IPAddresses : DictionaryBase
    {
        // now we are trying to load data into dictionary fro file.
        public IPAddresses(string txtFile)// It calls a default constructor of a base class.
        {
            //string line;
            //string[] words;
            //StreamReader inFile;
            //inFile = File.OpenText(txtFile);
            //while (inFile.Peek() != -1)
            //{
            //    line = inFile.ReadLine();

            //    words = line.Split(',');
            //    this.InnerHashtable.Add(words[0], words[1]);
            //    Console.WriteLine();
            
            //}

            //inFile.Close();
            string[] lines = new string[3];
                lines = File.ReadAllLines(txtFile);

             lines.Select(l => l.Split('=')).ToDictionary(a => a[0], a => a[1]);






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
