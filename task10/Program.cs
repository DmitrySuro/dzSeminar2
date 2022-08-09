//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Clear();

System.Console.WriteLine("Пожайлуйста введите трехзначное число ");
int number = int.Parse(System.Console.ReadLine()!);
int result = number / 10;
System.Console.WriteLine($"Вторая цифра вашего числа {result % 10}");