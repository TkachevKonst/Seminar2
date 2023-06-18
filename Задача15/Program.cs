Console.Clear();
Console.Write("Введите любое число:");
int num1 = int.Parse(Console.ReadLine());
if (num1 ==6 || num1==7)
{
    Console.WriteLine("Выходной");
}
else if (num1 > 0 && num1 < 6)
{
    Console.WriteLine("Будний");
}
else
{
    Console.WriteLine("Ошибка");
}