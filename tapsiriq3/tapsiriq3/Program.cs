using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq3
{
    class Program
    {
        static void Main(string[] args)
        {

            //  {"salam","masin","buz","ev","kod","meymun","avtobus"} arrayinda 4 hərfdən az olan sözləri çapa verən proqram tərtib edin.

            string[] words = { "salam", "masin", "buz", "ev", "kod", "meymun", "avtobus" };

            Console.WriteLine("4 herfden az olan sozler: ");

            for (int i = 0; i < words.Length; i++)
            {

                if (i < 4)
                {
                    Console.WriteLine(words[i]);
                }

                

                // { "salam","masin","buz","ev","kod","meymun","avtobus"} arrayinda 4 hərfdən çox olan sözlərin sonuna AZE ifadəsini əlavə edərək çapa verən proqram tərtib edin.

                else
                {
                    Console.WriteLine(words[i] + "AZE");
                }
            }

            Console.WriteLine("#########");
            //{ "salam","masin","buz","ev","kod","meymun","avtobus"} arrayinda olan elementləri çapa verən proqram tərtib edin.
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            //{ "salam","masin","buz","ev","kod","meymun","avtobus"} arrayinin elemetlərini arasında boşluqlar olmaq şərti ilə yan-yana düzən proqram tərtib edin.
            Console.WriteLine("#########");

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
                Console.Write(" ");
            }


            Console.ReadLine();
        }
    }
}
