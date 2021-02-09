using System.Linq;
using System;

public class Program
{
	public static void Main()
	{
		string[] char_names = {"Elric", "Conan", "Sonya", "Eveehi" };
		
		var myChars = from name in char_names
        	where name.Contains('E')
        	select name;
		
		foreach(var name in myChars)
			Console.WriteLine(name);
	}
}
