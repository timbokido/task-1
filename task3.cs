﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Ваше число: ");
int a = Convert.ToInt16(Console.ReadLine());
if (a%2==0) {
    Console.WriteLine("число " + a + " четное");
}
else {
    Console.WriteLine("число " + a + " не четное");
}

