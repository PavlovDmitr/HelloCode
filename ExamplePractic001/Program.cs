//Напишите программу, которая на вход принимает число и выдает его квадрат

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} равен = {sqr1}");