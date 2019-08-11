using System;

namespace ConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var my = new MyClass();
            Console.WriteLine($"Hello {my.IsAlwaysTrue()} World!");
        }
    }
}
