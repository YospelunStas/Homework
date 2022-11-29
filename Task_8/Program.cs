// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите Ваше число: ");
string str = Console.ReadLine();
int N = int.Parse(str);
int a = 1;
Console.WriteLine();
Console.Write(N);
Console.Write(": ");
while (a <= N)
{
    if (a % 2 == 0)
    {
        Console.Write(a + ", ");
        a++;
    }
    else
    {
        a++;
    }
}