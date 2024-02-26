// Напишите программу, которая принимает на вход натуральное число N,
// а на выходе показывает его цифры через запятую.

int N = int.Parse(Console.ReadLine()!);

string A;
A = " ";
while (N > 0)
{
    A = (N % 10) + "," + A;
    N = N / 10;
}
A = A.Substring(0, A.Length - 2);
Console.Write(A);