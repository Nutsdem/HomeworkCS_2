// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число = ");
int num = int.Parse(Console.ReadLine());
int day = 0;
if(num < 1 ^ num > 7)
{
    Console.WriteLine("Нет такого дня недели.");
}
else
{
    day = num;
}
if(day == 6 ^ day == 7)
{
    Console.WriteLine("Выходной");
}

if(day == 1 ^ day == 2 ^ day == 3 ^ day == 4 ^ day == 5)
{
    Console.WriteLine("На завод");
}
