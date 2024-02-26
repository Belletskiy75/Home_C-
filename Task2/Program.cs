// Напишите программу, которая принимает на вход координаты тоски(X,Y),
//прочем X#0 Y#0, и выдает номер координатной четверти, в которой находится точка.

int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

if (X > 0 && Y > 0)

    Console.WriteLine("1");

else if (X < 0 && Y > 0)

            Console.WriteLine("2");

    else if (X < 0 && Y < 0)

           Console.WriteLine("3");

     else if (X > 0 && Y < 0)

           Console.WriteLine("4");
