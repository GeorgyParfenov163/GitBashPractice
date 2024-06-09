using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitBashPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 Gosha = new Class1("Гоша", 27, "Разработчик");
            Console.WriteLine(Gosha.GetInfo()); 
            //Console.WriteLine(Gosha.Name);
        }
    }
}
