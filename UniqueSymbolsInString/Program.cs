using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UniqueSymbolsInString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//принимаем строку
			string inputString = "Hello World";
			RemoveUnUniqueSymbols(inputString);
			Console.ReadKey();
		}
		static void RemoveUnUniqueSymbols(string inputString)
		{
			List<char> charredInputString = inputString.ToList();
			for (int i = 0; i < charredInputString.Count; i++)
			{
				Console.WriteLine(i);

				Console.Write(charredInputString[i]);
				//проходимся по слову и достаем каждый символ
				for (int j = i; j < charredInputString.Count - 1; j++)
				{
					//отсеиваем одинаковые следующие символы
					if (charredInputString[i] != charredInputString[j + 1])
					{
						Console.Write(charredInputString[j + 1]);

					}
					else if (charredInputString[i] == charredInputString[j + 1])
					{
						//удалить элемент из массива
						Console.Write("Совпадает");
						charredInputString.RemoveAt(j+1);
					}
				}
                Console.WriteLine();

				//выводим количество уникальных символов в этой строке
				

			}
			Console.WriteLine("Ответ:");
			foreach (char c in charredInputString)
			{
				Console.Write(c);
			}
		}
	}
}
