using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
	public abstract class Character
	{
		public string name { get; set; }
		public int hp { get; set; }
		public Stats stats { get; set; }

		public Character()
		{
			Console.Write(">Creando character");
		}

		public Character(string name)
		{
			this.name = name;
		}

		public Character(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
		}

		public Character(string name, int hp, Stats stats)
		{
			this.name = name;
			this.hp = hp;
			this.stats = new Stats();
		}

		public void Attack() {
			Console.WriteLine("Attack!!!");
		}

		public void Jump()
		{
			Console.WriteLine("Jump!!!");
		}

		public void Walk() {
			Console.WriteLine("Walk!!!");
		}

		public virtual void ShowActionMenu() {
			Console.WriteLine("ACTIONS");
			Console.WriteLine("=======");
			Console.WriteLine("1 - walk");
			Console.WriteLine("2 - jump");
			Console.WriteLine("3 - attack");

			//string action = Console.ReadLine();

			//switch (action) {
			//	case "1":
			//		Walk();
			//		break;
			//	case "2":
			//		Jump();
			//		break;
			//	case "3":
			//		Attack();
			//		break;
			//	default:
			//		Console.WriteLine("Not define");
			//		break;
			//}
		}
	}
}
