using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq4
{
    class Program

    { 
            static void Main(string[] args)
        {
            //0-dan 100-ə qədər olan ədədləri çapa verən proqram tərtib edin. 
            //Console.WriteLine("0-dan 100-e qeder olan ededlər:");
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //0 - dan 100 - ə qədər olan cüt ədədləri çap edən proqram tərtib edin.

            //Console.WriteLine("0-dan 100-e qeder olan cut ededler:");
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //0-dan 100-ə qədər olan tək ədədlərin cəmini tapan proqram tərtib edin.


            //int sum = 0;

            //for (int number = 1; number <= 100; number += 2)
            //{
            //    sum += number;
            //}
            //Console.Write("0-dan 100-e qeder olan tek ededlerin cemi: " +sum);


            //0 - dan 100 - ə qədər olan ədədlər içərisində rəqəmləri bir birinə bərabər olan iki rəqəmli ədədləri çap edən proqram tərtib edin.

            //Console.WriteLine("0 - dan 100-e qeder olan ededlerin reqemleri bir birine beraber olanlar: ");

            //for (int number = 10; number < 100; number++)
            //{
            //    int onluq = number / 10;
            //    int teklik = number % 10;

            //    if (onluq == teklik)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //İstənilən arrayin 1-ci elementini çapa verən funksiya yazın. Funksiya arraylari parametr olaraq alacaq.

            void arrprint<A>(A[] arr)
            {
                if (arr.Length > 0)
                {
                    Console.WriteLine("The first element is: " + arr[0]);
                }

                if (arr.Length > 0)
                {
                    Console.WriteLine("The last element is: " + arr [arr.Length - 1]);
                }

            }


            string[] myarr = { "coxluq1", "coxluq2", "coxluq3", "coxluq4", "coxluq5" };
            arrprint(myarr);

            Console.ReadLine();
        
        }
    }
}
