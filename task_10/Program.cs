// task 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear ();
Console.Write("Введите трехзначное число:");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 999 || a < 100) Console.WriteLine("Число не трехзначное");
else
{
    while (a > 100)
        a = a/10;
        Console.WriteLine(a%10);
}
