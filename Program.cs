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
            Console.WriteLine(text == "text" ? "Unoriginal write something else" : $"\nYou wrote {text} in the consle.");
            string literal_string = @"This is a path: c:\Windows\System32";
            Console.WriteLine(literal_string);
        }
    }
}
