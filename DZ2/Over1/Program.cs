System.Console.WriteLine("введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
int num1 = (int) num * 1000 / 1000;
System.Console.WriteLine(num1);
System.Console.WriteLine(num % 1);
if (num1 % 100 > 10 ) Console.WriteLine((num1 / 100 * 10 + num % 1 + num1 % 10));
else System.Console.WriteLine("Второй цифры нет");
