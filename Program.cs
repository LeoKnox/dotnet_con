using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWrite some text! ");
            var text = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nYou wrote {text} in the consle.");
        }
    }
}
