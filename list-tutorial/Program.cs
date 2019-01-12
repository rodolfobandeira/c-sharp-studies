using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Rodolfo", "Bandeira" };
            foreach (var name in names)
            {
                Console.WriteLine($"{name.ToUpper()}!");
            }
        }
    }
}