/*
Задача 3: Напишите программу, которая принимает
на вход целое число из отрезка [10, 99] и показывает
наибольшую цифру числа.
Пример:
40 => 4
96 => 9
72 => 7
*/
System.Console.Write("Введите целое число из отрезка [10, 99] - ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 10 || number > 99)
    Console.WriteLine("Вы ввели не двузначное чилсло!");
else
{
if(number / 10 > number % 10)
    Console.WriteLine(number / 10);
else
    Console.WriteLine(number % 10);
}