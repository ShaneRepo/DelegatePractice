using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        public delegate string Example();

        public string ExampleIml()
        {
            return "Hi";
        }

        public void DoStuff()
        {
            Example myImp;
            myImp = ExampleIml;
            Console.WriteLine(myImp());
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DoStuff();
            Console.ReadKey();
        }
    }
}
