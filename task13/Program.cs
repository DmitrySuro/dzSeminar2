//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

System.Console.Clear();

System.Console.WriteLine("Введите свое число ");
int number = int.Parse(System.Console.ReadLine()!);
int thirdNumber = 0;

while (number / 1000 >= 0)
{
   
    if (number / 100 == 0)
    {
            System.Console.WriteLine("Простите но третьей цифры нет");
        break;
    }

   if (number / 1000 == 0)
    {
            thirdNumber = number % 10;
            System.Console.Write($"А вот и ваша третья цифра  {thirdNumber}");
        break;  
    }    

    number /= 10;
   
}
