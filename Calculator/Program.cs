using System;

namespace Test
{
	class Calculator {

	static void Main(string[] args) {

		string znak, str;

		int a = 1, b = 2, c = 3, d = 4;

		Console.WriteLine("Какое математическое действие вы хотите сделать? \n 1 - Додавание \n 2 - Вычитание \n 3 - Умножение \n 4 - Деление");

		znak = Console.ReadLine();



		if (znak == a.ToString()) {

			Console.WriteLine("Выберите 1 число: ");

			str = Console.ReadLine();

			a = Convert.ToInt32(str);

			Console.WriteLine("Выберите 2 число: ");

			str = Console.ReadLine();

			b = Convert.ToInt32(str);

			int resultplus = a + b;

			Console.WriteLine("Результат вычисления: " + resultplus);

		}

		else if (znak == b.ToString()) {

			Console.WriteLine("Выберите 1 число: ");

			str = Console.ReadLine();

			a = Convert.ToInt32(str);

			Console.WriteLine("Выберите 2 число: ");

			str = Console.ReadLine();

			b = Convert.ToInt32(str);

			int resultminus = a - b;

			Console.WriteLine("Результат вычисления: " + resultminus);
		}

		else if (znak == c.ToString()) {

			Console.WriteLine("Выберите 1 число: ");

			str = Console.ReadLine();

			a = Convert.ToInt32(str);

			Console.WriteLine("Выберите 2 число: ");

			str = Console.ReadLine();

			b = Convert.ToInt32(str);

			int resultmulti = a * b;

			Console.WriteLine("Результат вычисления: " + resultmulti);
		}

		else if (znak == d.ToString()) {

			Console.WriteLine("Выберите 1 число: ");

			str = Console.ReadLine();

			a = Convert.ToInt32(str);

			Console.WriteLine("Выберите 2 число: ");

			str = Console.ReadLine();

			b = Convert.ToInt32(str);

			int resultdivide = a / b;

			Console.WriteLine("Результат вычисления: " + resultdivide);
		}

		}
	}
}