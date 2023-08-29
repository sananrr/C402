using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq2
{
    class Program
    {
        static void Main(string[] args)
        {

            //İki ədədin cəmi ilə fərqinin hasilini tapan funksiya yazın. Funksiya dəyişənləri parametr olaraq almalıdır.
            int plus(int a, int b)
            {
                return a + b;
            }

            int minus(int a , int b)
            {
                return a - b;
            }

            int multi (int a , int b)
            {
                return a * b;

            }

            void numbers()
            {
                Console.Write("Enter the first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = plus(num1, num2);
                Console.WriteLine("The sum is: " + result);

                int difference = minus(num1, num2);
                Console.WriteLine("The difference is: " + difference);
                    
                    int multiplication = multi(result, difference);
                    Console.WriteLine("The multiplication is: " + multiplication);
                
            }

            
            numbers();
            Console.ReadLine();
        }
    }
}
