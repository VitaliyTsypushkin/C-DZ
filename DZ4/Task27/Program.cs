System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
if (num == 0) sum = 0;
while (num>0)
{
    sum = sum + num % 10;
    num = num / 10;
 }
Console.WriteLine($"Сумма цифр числа = {sum}");