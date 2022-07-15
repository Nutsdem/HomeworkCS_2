// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число = ");
int num = int.Parse(Console.ReadLine());

if(num < 100)
{
    Console.WriteLine("Третего числа нет!");
}
if(num > 99 & num < 1000)
{
    Console.WriteLine((num - (num % 100)) / 100);
}

if (num > 999)
{
    Console.WriteLine(((num % 1000) - (num % 100)) % 10);
}
else
{
    Console.WriteLine(((num % 1000) - (num % 100)) % 10);
}
