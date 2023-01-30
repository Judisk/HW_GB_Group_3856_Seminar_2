// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Задание 10");

System.Console.WriteLine("Введите целое трехзначное чиcло");

int number = int.Parse(Console.ReadLine());
int numberRes=0;
if (number>100 || number>1000)
{
    numberRes = number%100;

    numberRes = numberRes/10;

System.Console.WriteLine(numberRes);
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

 System.Console.WriteLine("Задание 13");

System.Console.WriteLine("Введите число");

number = int.Parse(Console.ReadLine());

int i=1000;

while (i<=number)
{
    i*=10;
}

if (number<100)
{
     System.Console.WriteLine("Третьей цифры нет");
}
else
{
    numberRes = number%(i/100);

     numberRes = numberRes/(i/1000);

     System.Console.WriteLine(numberRes);
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Задание 15");

System.Console.WriteLine("Введите число обозначающее день недели от 1 до 7 ");

number = int.Parse(Console.ReadLine());

if (number>5)
{
    System.Console.WriteLine("Да");
}
else if(number<=5)
{
   System.Console.WriteLine("Нет");
}
else
{
    System.Console.WriteLine("Это число не в диапазоне от 1 до 7");
}
