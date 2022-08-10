//Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую вторую цифру этого числа
// 456-> 46
// 782 -> 72
// 918 -> 98

System.Console.Clear();

Random rnd = new Random();
int number = rnd.Next(100,1000);
  
    System.Console.WriteLine($"Вот трехзначное случайное число {number}");

int firstNumber = number / 100;
int thirdNumber = number % 10;

    System.Console.WriteLine($"Вторая цифра удалена и вот результат {firstNumber}{thirdNumber}");