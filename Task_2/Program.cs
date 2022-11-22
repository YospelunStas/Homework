// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int b = int.Parse(str);
Console.WriteLine();
if (a > b)
{
    Console.Write(a);
    Console.WriteLine(" = max");
    Console.Write(b);
    Console.WriteLine(" = min");
}
else
{
    Console.Write(b);
    Console.WriteLine(" = max");
    Console.Write(a);
    Console.WriteLine(" = min");
}