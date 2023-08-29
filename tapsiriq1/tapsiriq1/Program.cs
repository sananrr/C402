using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // İki ədədin cəmini tapan funksiya yazın. Funksiya dəyişənləri parametr olaraq almalıdır.
            int toplama(int a, int b)
            {
                return a + b;
            }
            
             void ededler()
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = toplama(num1, num2);
                Console.WriteLine("The sum is: " + result);
            }
            ededler();
            Console.ReadLine();
        }
    }
}
