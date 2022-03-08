/* 2) Пользователь вводит два числа (X и Y). Определить какой четверти координатной плоскости принадлежит точка с координатами (X,Y).
Примечание. Нумерацию четвертей принять такую:
 4 | 1
--------
 3 | 2
*/

class Program 
{ 
    static void Main(String[] args) 
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        if (num1 >= 0 && num2 >= 0) Console.WriteLine("Точка с заданными координатами принадлежит четверти 1");
        if (num1 < 0 && num2 >= 0) Console.WriteLine("Точка с заданными координатами принадлежит четверти 2");
        if (num1 < 0 && num2 < 0) Console.WriteLine("Точка с заданными координатами принадлежит четверти 3");
        if (num1 >= 0 && num2 < 0) Console.WriteLine("Точка с заданными координатами принадлежит четверти 4");
    }
}