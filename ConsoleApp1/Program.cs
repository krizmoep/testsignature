using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Weihnachtsmann!");
            Console.ReadKey();

            Console.WriteLine(".. und ich bin der Hampelmann");
            Console.ReadKey();

            Console.WriteLine("Hallo hallo Hallo, dritte Änderung");

            Weihnachtsmann harry = new Weihnachtsmann();

            harry.weihnachtsMann1 = "Schinkenwurst";
            Console.WriteLine(harry.weihnachtsMann1);
            Console.ReadKey();
        }
    }
}
