// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите Ваше число: ");
string str = Console.ReadLine();
int N = int.Parse(str);
Console.WriteLine();
if (N % 2 == 0)
{
    Console.Write(N);
    Console.WriteLine(" - чётное");
}
else
{
    Console.Write(N);
    Console.WriteLine(" - нечётное");
}