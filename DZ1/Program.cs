//Задача 2
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b) System.Console.WriteLine("max= " + a);
//     else Console.WriteLine("max= " + b);
//////////////////////////////
// //задача 4
// Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if (a > b) max = a;
// if (a < b) max = b;
// if (max < c) max = c;
// Console.WriteLine("max= " + max);
/////////////////////////////////////////////////
//Задача 6
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 0) System.Console.WriteLine("да");
// else System.Console.WriteLine("нет");
///////////////////////////////////////////////////
//Задача 8
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 0;
// while (b < (a - 1)) 
// {
//     b = b + 2;
//     Console.Write(" " + b); 
// }
///////////////////////////////////////////////////
//Задача 7
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1000)
{
    while (a / 10000 > 0)
    {
        a /= 1000;
    }
int b = a % 10;
System.Console.WriteLine(b);
}
else System.Console.WriteLine("нет четвертой цифры");