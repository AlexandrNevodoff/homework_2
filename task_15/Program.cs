// task 15 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear ();
Console.Write("Введите цифру дня недели (1-7):");
int a = Convert.ToInt32(Console.ReadLine());

if (a>7 || a<1) Console.Write ("Неверное число");
else
if (a>5) Console.Write("Да, выходной!");
else
{
    Console.Write("Нет, не выходной :(");
}