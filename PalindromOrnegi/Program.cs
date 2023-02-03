using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Lutfen Veri Giriniz.:");
            Console.Write(">");
            string veri = Console.ReadLine();
            if (string.IsNullOrEmpty(veri))
            {
                goto basadon;
            }
            char[] normal = veri.ToArray();
            char[] ters = veri.ToArray();
            Array.Reverse(ters);
            //araba
            // a r a b a
            // a b a r a

            bool palindrom = true;
            for (int i = 0; i < veri.ToArray().Count(); i++)
            {
                if (normal[i] != ters[i])
                {
                    palindrom = false;
                }
            }

            Console.WriteLine("Palindrom Mu.?" + palindrom);
            Console.WriteLine(" ");

            goto basadon;

            Console.ReadLine();
        }
    }
}
