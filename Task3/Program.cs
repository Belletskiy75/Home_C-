﻿// Напишите программу, которая принимает на вход целое число
// из отрезка [10,99] и показывает максимальную цифру числа.


int N = int.Parse(Console.ReadLine()!);
int a = N / 10;
int b = N % 10;

if (N > 10 && N < 99)

    if (a > b)

        Console.Write(a);

    else

        Console.Write(b);

