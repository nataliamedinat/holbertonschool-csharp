using System;

namespace _100_hello_error
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.TextWriter errorWriter = Console.Error;
            errorWriter.WriteLine("and that piece of art is useful - Dora Korpar, 2015-10-19\n");
            Environment.Exit(1);
        }
    }
}
