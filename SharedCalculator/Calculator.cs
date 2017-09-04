using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator
{
    public class Calculator
    {

        //public double Tal1 { get; set; }
        //public double Tal2 { get; set; }
        public double resultat = 0;
        //public string Opr { get; set; }

        //public Calculator(double tal1, double tal2, string opr)
        //{
        //    this.Tal1 = tal1;
        //    this.Tal2 = tal2;
        //    this.Opr = opr;
        //}


        public void UdskrivResultat()
        {
            Console.WriteLine("Resultatet er: " + resultat);
        }


        public double BestemLommeregner(double tal1, double tal2, string opr)
        {
            if (opr == "+")
            {
                resultat = tal1 + tal2;
            }

            if (opr == "-")
            {
                resultat = tal1 - tal2;
            }

            if (opr == "*")
            {
                resultat = tal1 * tal2;
            }

            if (opr == "/")
            {
                resultat = tal1 / tal2;
            }

            return resultat;
        }


    }
}
