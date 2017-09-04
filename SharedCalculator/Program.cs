using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedCalculator;

namespace SharedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("Indtast det første tal: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Indtast operator: ");
            string opr = Console.ReadLine();

            Console.WriteLine("Indtast andet tal: ");
            string input2 = Console.ReadLine();

            Int32.Parse(input1);
            Int32.Parse(input2);

            calc.UdskrivResultat();
        }
    }
}
