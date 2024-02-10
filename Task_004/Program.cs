/*
Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.
Пример:
568 => 5,6,8
8 => 8
9542 => 9,5,4,2
*/
System.Console.Write("Введите натуральное число - ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
    Console.WriteLine("Вы ввели не натуральное чилсло!");
else
{
    Console.WriteLine("Обратный порядок:");
    int i = number;
    while (i > 0)
    {
        Console.Write(i % 10);
        i /= 10;
        if (i > 0)
            Console.Write(",");
    }

    Console.WriteLine("\nПрямой порядок:");
    
    // Находим порядок числа
    i = number;
    int order = 1; 
    while (i > 10)
    {
        i /= 10;
        order *= 10;
    }
    
    // Выводим цифры:
    while(order > 0)
    {
        System.Console.Write(number / order % 10);
        if (order > 1)
            Console.Write(",");
        order /= 10;
    }
}