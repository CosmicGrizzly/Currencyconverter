using System;
using System.Text;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("What is the first? ");
            double A = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("What is the Second? ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the Third? ");
            double C = Convert.ToDouble(Console.ReadLine());

            double Total = A + B + C;
            double Average = Total / 3.0;
            double Smallest = 0.0;
            double Largest = 0.0;
            
            if (A < B && A < C)
            {
                Smallest = A;
            }
            else if (B < A && B < C)
            {
                Smallest = B;
            }
            else if (C < A && C < B)
            {
                Smallest = C;
            }

            if (A > B && A > C)
            {
                Largest = A;
            }
            else if (B > A && B > C)
            {
                Largest = B;
            }
            else if (C > A && C > B)
            {
                Largest = C;
            }

            Console.WriteLine("Total: " + Total);
            Console.WriteLine("Average: " + Average);
            Console.WriteLine("Smallest: " + Smallest);
            Console.WriteLine("Largest: " + Largest);
            string CurrencyUS = Total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
            string CurrencySE = Total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("sv-se")).Replace(".", " "); 
            string CurrencyJP = Total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("ja-jp"));
            string CurrencyTH = Total.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("th-th"));

            Console.WriteLine(CurrencyUS);
            Console.WriteLine(CurrencySE);
            Console.WriteLine(CurrencyJP);
            Console.WriteLine(CurrencyTH);
            //Console.WriteLine(A + B + C);
            Console.ReadLine();
        }
    }
}
