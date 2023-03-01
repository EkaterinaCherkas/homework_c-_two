//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

int number = new Random().Next(100 , 1000);
Console.WriteLine(number);
int a = number / 100 ; // 918 / 10 = 91 /100 = 9 %10 = 8 %100 = 18
int b = number %100 /10;
int c = number % 10;
Console.WriteLine(b);
