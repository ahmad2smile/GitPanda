using System;

namespace GitPanda
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"Arg: {arg}");
            }

            Console.WriteLine("Hello World!");
        }
    }
}
