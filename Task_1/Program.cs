/* 1) Пользователь вводит два числа (A и B). Если A > B, подсчитать A+B, если A == B, подсчитать A*B, если A < B, подсчитать A-B.
Сделать лесенкой из двух if'ов.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) Console.WriteLine("Сумма этих чисел равна: " + (num1 + num2));
        else if (num1 == num2) Console.WriteLine("Произведение этих чисел равно: " + (num1 * num2));
        else if (num1 < num2) Console.WriteLine("Разность этих чисел равна: " + (num1 - num2));
    }
}