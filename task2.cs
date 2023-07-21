// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("первое число = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("второе число = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("третее число = ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b) & (a > c))
{
Console.WriteLine("max = " + a);
}
if ((b > a) & (b > c))
{
Console.WriteLine("max = " + b);
}
if ((c > b) & (c > a))
{
Console.WriteLine("max = " + c);
}
