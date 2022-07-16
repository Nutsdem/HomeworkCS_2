// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число = ");
int num = int.Parse(Console.ReadLine());

string str = num.ToString();
int[] array = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     array[i] = int.Parse(str[i].ToString());
}

if(str.Length > 2)
{
Console.WriteLine(array[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}