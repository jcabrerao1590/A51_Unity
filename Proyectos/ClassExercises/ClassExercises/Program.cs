using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Character type:");
			Console.WriteLine("\t1-wizard");
			Console.WriteLine("\t2-Warrior");
			Console.WriteLine("\t3-Rogue");
			string type = Console.ReadLine();

			Console.WriteLine("Name:");
			string name = Console.ReadLine();

			Character character = null;

			switch (type)
			{
				case "1":
					character = new Wizard(name);
					break;
				case "2":
					character = new Warrior(name);
					break;
				case "3":
					character = new Rogue(name);
					break;
				default:
					break;
			}

			if (character != null)
			{
				character.ShowActionMenu();
			}

			Console.ReadLine();
		}
	}
}
