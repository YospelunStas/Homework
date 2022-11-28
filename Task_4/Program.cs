// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Введите второе число");
str = Console.ReadLine();
int b = int.Parse(str);
Console.WriteLine("Введите третье число");
str = Console.ReadLine();
int c = int.Parse(str);
Console.WriteLine();
if (a > b && a > c)
{
    Console.Write(a);
    Console.WriteLine(" = max");
}
 else if (a == b && a != c)
 {
    Console.Write(a);
    Console.WriteLine(" = max");
 }
if (b > a && b > c)
{
    Console.Write(b);
    Console.WriteLine(" = max");
}
 else if (b == c && b != a)
 {
    Console.Write(b);
    Console.WriteLine(" = max");
 }
if (c > b && c > a)
{
    Console.Write(c);
    Console.WriteLine(" = max");
}
 else if (a == c)
 {
    Console.Write(a);
    Console.WriteLine(" = max");
 }