// task 13 Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК

Console.Clear ();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (a > 1000)
        a = a/10;
        Console.WriteLine(a%10);
}