using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// must add in additional libraries yourself
using System.Xml;
using System.Xml.Linq;
// pulls in library for Console, so you don't have to call to the library each time
// you want to write a line to the console
using static System.Console;

namespace ReadAndQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Loading an XML doc");

            // use Load method on class to load up an xml doc that already exists
            XDocument myDoc = XDocument.Load("Inventory3.xml");
            WriteLine(myDoc + "\n");

            // walking the dom tree finding car objects
            var result = from car in myDoc.Descendants("Car")
                         where ((string)car.Attribute("ID")).Equals("2")
                         select car;
            
            // using deferred execution
            foreach(var car in result)
            {
                WriteLine(car);
            }



        }
    }
}
