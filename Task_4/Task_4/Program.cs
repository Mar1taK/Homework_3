/*5) Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
Примечание. Здесь, пожалуй, удобно использовать switch-case, но можно и if-ами. Да, потребуется много веткой с соответствующими словами ))
Но их будет не 89 (10 - 99) :) Подумайте, как можно сделать поменьше. Анализируйте соответствующие цифры и выводите соответствующий текст.
*/
class Program
{
	static void Main()
	{
		Console.WriteLine("Ведите число: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int dozen = number / 10;
		int unit = number % 10;
		string firstWord = "двадцать", secondWord = "один";


		if (dozen >= 2 && dozen < 10)
		{
			switch (dozen)
			{

				case 2: firstWord = "двадцать"; break;
				case 3: firstWord = "тридцать"; break;
				case 4: firstWord = "сорок"; break;
				case 5: firstWord = "пятьдесят"; break;
				case 6: firstWord = "шестьдесят"; break;
				case 7: firstWord = "семьдесят"; break;
				case 8: firstWord = "восемьдесят"; break;
				case 9: firstWord = "девяносто"; break;
			}
			switch (unit)
			{

				case 0: secondWord = ""; break;
				case 1: secondWord = "один"; break;
				case 2: secondWord = "два"; break;
				case 3: secondWord = "три"; break;
				case 4: secondWord = "четыре"; break;
				case 5: secondWord = "пять"; break;
				case 6: secondWord = "шесть"; break;
				case 7: secondWord = "семь"; break;
				case 8: secondWord = "восемь"; break;
				case 9: secondWord = "девять"; break;
			}
			Console.WriteLine(number + " - " + firstWord + " " + secondWord);

		}
		else if (dozen == 1)
		{

			switch (number)
			{


				case 10: firstWord = "десять"; break;
				case 11: firstWord = "одиннадцать"; break;
				case 12: firstWord = "двенадцать"; break;
				case 13: firstWord = "тринадцать"; break;
				case 14: firstWord = "четырнадцать"; break;
				case 15: firstWord = "пятнадцать"; break;
				case 16: firstWord = "шестнадцать"; break;
				case 17: firstWord = "семнадцать"; break;
				case 18: firstWord = "восемнадцать"; break;
				case 19: firstWord = "девятнадцать"; break;
			}
			Console.WriteLine(number + " - " + firstWord);
		}
	}
}