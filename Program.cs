﻿/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine($"Максимально число это: {a}");
}
else if (a<b) 
{
    Console.WriteLine($"Максимальное число это: {b}");
}
else 
{
    Console.WriteLine($"Числа равны");
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b && a>c)
{
    Console.WriteLine($"максимальное число это: {a}");
}
else if (b>a && b>c)
{
    Console.WriteLine($"максимально число это: {b}");
}
else if (c>a && c>b)
{
    Console.WriteLine($"Максимально число это: {c}");
}
else {
    Console.WriteLine($"Числа равны");
}


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0) {
    Console.WriteLine($"{a} четное число");
}
else {
    Console.WriteLine($"{a} нечетное число");
}


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a>=count){
if (count%2 == 0){
    Console.WriteLine(count + " ");
}
count++;
}