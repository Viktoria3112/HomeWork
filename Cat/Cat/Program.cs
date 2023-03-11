using System;

namespace Cat
{
    public class Program
    {
        public static void Main()
        {
            WriteToConsole(text: "Viktoria ");
        }

        public static void WriteToConsole(string text)
        {
            Console.WriteLine(text + "Hello!");
        }
    }
}
