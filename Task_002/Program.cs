/*
Задача 2: Напишите программу, которая принимает
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.
Пример:
2, 3 => 1
-5, 3 => 2
-3, -2 => 3
4, -2 => 4
*/
System.Console.Write("Введите координату X точки - ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y точки - ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
    Console.WriteLine("Точка находится на координатной оси.");
else if(x > 0 && y > 0)
    Console.WriteLine("1");
else if(x < 0 && y > 0)
    Console.WriteLine("2");
else if(x < 0 && y < 0)
    Console.WriteLine("3");
else
    Console.WriteLine("4");
