using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        // delegate signatures
        public delegate string Example();
        public delegate string ExampleWithString(string name);
        // Example Implementation Method
        public string ExampleIml()
        {
            return "Hi";
        }
        // Overloaded with string param
        public string ExampleIml(string name)
        {
            return $"Hi {name}";
        }
        // Method to assign delegate a method and print to console
        public void DoStuff()
        {
            Example myImp;
            ExampleWithString myImpString;
            myImp = ExampleIml;
            myImpString = ExampleIml;
            Console.WriteLine(myImp());
            Console.WriteLine(myImpString("Shane"));
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DoStuff();
            Console.ReadKey();
        }
    }
}
