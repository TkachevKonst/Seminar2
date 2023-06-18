Console.Clear();
Console.Write("Введите любое число:");
int num1 = int.Parse(Console.ReadLine());
if (num1<99)
{
    Console.WriteLine("двухзначное число");
    return;
}
while (num1>1000)
{
   num1/=10;
 }
    Console.WriteLine(num1);
    Console.WriteLine(num1%10);