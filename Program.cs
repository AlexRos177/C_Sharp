using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMiniCalculators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double skA, skB;
                string action;

                try
                {
                    Console.WriteLine("Ievadi skA");
                    skA = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ievadi skB");
                    skB = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Nederīgas rakstzīmes!");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Ievadi mathOperation: '+' '-' '*' '/'");
                action = Console.ReadLine();
                Console.WriteLine("Result: ");
                

                switch (action)
                {
                    case "+":

                        Console.WriteLine(skA + skB);
                        break;

                    case "-":

                        Console.WriteLine(skA - skB);
                        break;

                    case "*":
                        Console.WriteLine(skA * skB);

                        break;

                    case "/":

                        if (skB == 0)

                        Console.WriteLine(0);

                        else

                        Console.WriteLine(skA / skB);
                       
                        break;
                        
                }
                Console.ReadLine();
            }
        }
    }
}
