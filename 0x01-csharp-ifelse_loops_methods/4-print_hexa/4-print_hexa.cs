using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int dec = 0; dec <= 98; dec++)
            Console.WriteLine("{0:D} = 0x{0:x}", dec);
        }
    }
}
