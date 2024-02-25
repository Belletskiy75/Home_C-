//Напишете програму, которая принимает на вход число
//и проверяет кратно оно одновременно 7 и 23.

int num = int.Parse(Console.ReadLine()!);

if (num % 7 == 0 && num % 23 == 0)

    Console.WriteLine("yes");
else
    Console.WriteLine("no");
