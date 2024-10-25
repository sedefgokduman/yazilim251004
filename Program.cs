using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilim251004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı girin");
            int sayi= Convert.ToInt32(Console.ReadLine());
            if (sayi >= 0 && sayi <=100)
            {
                Console.WriteLine("sayı 0 ile 100 arasındadır");
            }
            else
            {
                Console.WriteLine("sayı 0 ile 100 arasında değildir");
            }
            Console.ReadKey();
        }
    }
}
