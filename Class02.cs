using System.Linq;
using System;

public class Program
{
	class char_Class
	{
		public int CharID { get; set; }
		public String Name { get; set; }
		public int Level { get; set; }
		public int Atk { get; set; }
		public int HP { get; set; }
	}
	
	public static void Main()
	{
		char_Class[] partyArray = { 
            new char_Class() { CharID = 1, Name = "Aelien", Level = 18, Atk = 17, HP = 34 },
			new char_Class() { CharID = 2, Name = "Eveehi", Level = 18, Atk = 23, HP = 28 },
			new char_Class() { CharID = 3, Name = "Ynzon", Level = 18, Atk = 12, HP = 54 }
        };
	}
	
	char_Class[] chars = new char_Class[10];

        int i = 0;

        foreach (char_Class member in partyArray)
        {
            if (member.Atk > 12 && member.Atk < 20)
            {
                party[i] = member;
                i++;
            }
        }
}
