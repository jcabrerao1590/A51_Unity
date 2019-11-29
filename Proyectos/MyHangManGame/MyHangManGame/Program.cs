using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame
{
	class Program
	{
		static string secretWord = "zapato";
		static string letter = "";
		static string[] tempWord = new string[secretWord.Length];
		static int vida = secretWord.Length;
		static void Main(string[] args)
		{
			string space = "     ";
			string lword = new String('_', secretWord.Length);
			Console.WriteLine("..:: My Hang Man Game ::..");
			Console.WriteLine("");
			Console.WriteLine(space + lword);
			Console.WriteLine("");
			Console.WriteLine("Vidas: " + vida);
			Console.WriteLine("");
			requiredWord();
		}

		static void requiredWord()
		{
			Console.WriteLine("");
			Console.WriteLine("Ingrese una letra:");
			Console.WriteLine("");
			Console.WriteLine("Vidas: " + vida);
			Console.WriteLine("");
			letter = Console.ReadLine();
			int cont = 0;
			for (int i = 0; i < secretWord.Length; i++)
			{
				if (tempWord[i] == null)
				{
					tempWord[i] = "_";
				}
				if (letter == secretWord[i].ToString())
				{
					tempWord[i] = letter;
					cont++;
				}
				else if(tempWord[i] == "_")
				{
					cont++;
				}
			}
			if (cont != secretWord.Length) vida--;
			string resultado = String.Join("", tempWord);
			Console.WriteLine(resultado);
			if (vida == 0)
			{
				Console.WriteLine("YOU LOSE");
				Console.ReadLine();
			}
			else if (resultado == secretWord)
			{
				Console.WriteLine("YOU WIN");
				Console.ReadLine();
			}
			else
			{
				showWord(letter);
			}

		}

		static void showWord(string letter)
		{
			requiredWord();
		}
	}
}
