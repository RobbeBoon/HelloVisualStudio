using System;

namespace HelloVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#");
        }
        private const string Hello = "Hello";

        public static string SayHello => Hello;
    }
}
