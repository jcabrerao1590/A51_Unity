using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
	public class Warrior : Character
	{
		public Warrior(string name) : base(name)
		{
		}

		public Warrior(string name, int hp) : base(name, hp)
		{

		}

		public Warrior(string name, int hp, Stats stats) : base(name, hp, stats)
		{

		}

		public void Cast()
		{
			Console.WriteLine("Cast");
		}

		public override void ShowActionMenu()
		{
			base.ShowActionMenu();
			Console.WriteLine("4 - cast");

			string action = Console.ReadLine();
			switch (action)
			{
				case "1":
					Walk();
					break;
				case "2":
					Jump();
					break;
				case "3":
					Attack();
					break;
				case "4":
					Cast();
					break;
				default:
					Console.WriteLine("Not define");
					break;
			}
		}
	}
}
