/*3) Пользователь вводит три числа (A, B и С). Выведите их в консоль в порядке возрастания. 
 Можно использовать сложное условное выражение, но можно и if'ами.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] numbers = { number1, number2, number3 };
        var orderedvs = from i in numbers
                        orderby i ascending
                        select i;
        foreach (int i in orderedvs)
            Console.WriteLine(i);
    }

}