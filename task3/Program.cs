// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

Console.WriteLine("Введите цифру дня недели");
int dayofweek = int.Parse(Console.ReadLine());
if (dayofweek <= 5){
    Console.WriteLine("no");
}
else if (dayofweek == 6 || dayofweek == 7)
{
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("This day not a weekday");
}